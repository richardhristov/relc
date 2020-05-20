import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Heading from './Heading';
import Page from './Page';
import Input from './Input';
import Button from './Button';

class Question extends Component {
  render() {
    let answerField = (
      <Input
        label="Answer"
        value={this.props.answer}
        maxLength="60"
        type={this.props.type === 1 ? "number" : "text"}
        onChange={this.props.onChange.bind(this)}
      />
    );

    if (this.props.type === 2) {
      answerField = (
        <div className="input">
          <label
            className="input__label"
          >
            Answer
          </label>
          <select className="input__tag" onChange={this.props.onChange.bind(this)}>
            <option value={-1}>-- Select an answer --</option>
            {this.props.optionsList.map((o, index) => {
              return (
                <option value={index} selected={index === this.props.answers}>{ o }</option>
              );
            })}
          </select>
        </div>
      );
    }

    return (
      <div className="question">
        <div className="question__name">
          <b>#{this.props.visualKey}</b> {this.props.name} - <b>{this.props.score} points {this.props.isOptional ? `(BONUS QUESTION)` : ''}</b>
        </div>
        <div className="question__answer">
          {answerField}
        </div>
      </div>
    );
  }
}

class ExamTaker extends Component {
  static contextType = Context;

  constructor(props) {
    super(props);

    this.state = {
      redirect: false,
      loading: true,
      error: null,
      exam: {
        name: '',
        timeLimitSeconds: null,
        questions: [],
      },
      timeTaken: 0,
    };
  }

  async componentDidMount() {
    document.title = 'Take exam';

    if (this.props.location && this.props.location.state && this.props.location.state.examId) {
      await this.load(this.props.location.state.examId);
    } else {
      this.setState({
        ...this.state,
        redirect: '/dashboard',
      });
      return;
    }

    this.setState({
      ...this.state,
      loading: false,
    });

    this.interval = setInterval(this.tick.bind(this), 1000);
  }

  async load(examId) {
    const response = await this.context.api.get(`/student/exams/${examId}`);
    this.setState({
      ...this.state,
      exam: response.data,
    });
  }

  tick() {
    this.setState({
      ...this.state,
      timeTaken: this.state.timeTaken + 1,
    });
  }

  timeRemaining() {
    return this.state.exam.timeLimitSeconds - this.state.timeTaken;
  }

  timeRemainingFormatted() {
    var date = new Date(null);
    date.setSeconds(this.timeRemaining());
    return date.toISOString().substr(11, 8);
  }

  async submitClicked() {
    if (this.state.loading) {
      return;
    }

    this.setState({
      ...this.state,
      loading: true,
      error: null,
    });

    const nullAnswers = this.state.exam.questions.filter(q => q.answer === null);
    if (nullAnswers.length > 0) {
      this.setState({
        ...this.state,
        loading: false,
        error: 'Answer all questions!',
      });
      return;
    }

    const attempt = {
      attemptId: undefined,
      examId: this.state.exam.examId,
      timeTaken: this.state.timeTaken,
    };
    const answers = this.state.exam.questions.map(q => ({
      attemptAnswerId: undefined,
      attemptId: undefined,
      questionId: q.questionId,
      score: 1,
      answer: q.type > 0 ? parseInt(q.answer) : q.answer,
    }));
    const response = await this.context.api.post(`/student/attempts`, {
      ...attempt,
      answers,
    });

    this.setState({
      ...this.state,
      redirect: '/exams',
    });
  }

  valueChangedForAnswer(index, event) {
    const newState = {
      ...this.state,
      error: null,
    };
    newState.exam.questions[index].answer = event.target.value || 0;
    this.setState(newState);
  }

  render() {
    if (this.state.redirect) {
      return <Redirect to={this.state.redirect} />
    }

    let error = null;
    if (this.state.error) {
      error = (
        <li className="list__item error">
          {this.state.error}
        </li>
      );
    }

    return (
      <Page>
        <Heading
          title="Exam Taker"
        >
          Here you can take an exam
        </Heading>

        <ul className="list mt-1">
          {error}

          <li className="list__item">
            Time remaining: <b>{this.timeRemainingFormatted()}</b>
          </li>

          {this.state.exam.questions.map((q, index) => {
            return (
              <li className="list__item" key={index}>
                <Question
                  key={index}
                  visualKey={index}
                  name={q.name}
                  type={q.type}
                  optionsList={q.optionsList}
                  score={q.score}
                  isOptional={q.isOptional}
                  answer={q.answer}
                  onChange={this.valueChangedForAnswer.bind(this, index)} />
              </li>
            );
          })}

          <li className="list__item">
            <Button onClick={this.submitClicked.bind(this)}>Submit</Button>
          </li>
        </ul>
      </Page>
    );
  }
}

export default ExamTaker
