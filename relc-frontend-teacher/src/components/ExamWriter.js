import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Heading from './Heading';
import Page from './Page';
import Input from './Input';
import Button from './Button';

class Option extends Component {
  render() {
    return (
      <Input
          label={`Option #${this.props.visualKey}`}
          value={this.props.text}
          maxLength="100"
          onChange={this.props.onChange.bind(this)}
      />
    );
  }
}

class Question extends Component {
  render() {
    let optionsList = null;

    if (this.props.type === 2) {
      optionsList = (
        <div>
          <ul className="list">
            {this.props.optionsList.map((o, index) => {
              return (
                <li className="list__item" key={index}>
                  <Option
                    key={index}
                    visualKey={index}
                    text={o}
                    onChange={this.props.onOptionChange.bind(this, index)} />
                </li>
              );
            })}
          </ul>
          <Button onClick={this.props.addOptionClicked.bind(this)}>Add option</Button>
        </div>
      );
    }

    return (
      <div className="question">
        <Input
          label={`Question #${this.props.visualKey}`}
          value={this.props.name}
          maxLength="200"
          onChange={this.props.onChange.bind(this, 'name')}
        />
        <select className="input__tag" onChange={this.props.onChange.bind(this, 'type')}>
          <option value={0}>Type: String</option>
          <option value={1}>Type: Int</option>
          <option value={2}>Type: Multiple choice, single answer</option>
        </select>
        {optionsList}
        <Input
          label="Answer"
          value={this.props.answer}
          onChange={this.props.onChange.bind(this, 'answer')}
        />
        <Input
          label="Score"
          value={this.props.score}
          type="number"
          onChange={this.props.onChange.bind(this, 'score')}
        />
      </div>
    );
  }
}

class ExamWriter extends Component {
  static contextType = Context;

  constructor(props) {
    super(props);

    this.state = {
      redirect: false,
      loading: true,
      error: null,
      editing: false,
      exam: {
        examId: undefined,
        isActive: false,
        isEditable: true,
        name: '',
        timeLimitSeconds: 2700,
        gradingScoreMax: 0,
        gradingScoreMin: 0,
        roundingMethod: 0,
        questions: [],
      },
    };
  }

  async componentDidMount() {
    document.title = 'Create exam';

    if (this.props.location && this.props.location.state && this.props.location.state.examId) {
      await this.load(this.props.location.state.examId);
    }

    this.setState({
      ...this.state,
      loading: false,
    });
  }

  async load(examId) {
    const response = await this.context.api.get(`/teacher/exams/${examId}`);
    this.setState({
      ...this.state,
      editing: true,
      exam: response.data,
    });
    document.title = 'Edit exam';
  }

  valueChangedForExam(type, event) {
    const newState = {
      ...this.state,
    };
    newState.exam[type] = event.target.value;
    newState.exam.gradingScoreMax = parseInt(newState.exam.gradingScoreMax);
    newState.exam.gradingScoreMin = parseInt(newState.exam.gradingScoreMin);
    newState.exam.roundingMethod = parseInt(newState.exam.roundingMethod);
    newState.exam.timeLimitSeconds = parseInt(newState.exam.timeLimitSeconds);
    this.setState(newState);
  }

  valueChangedForQuestion(index, type, event) {
    const newState = {
      ...this.state,
    };
    newState.exam.questions[index][type] = event.target.value;
    newState.exam.questions[index].type = parseInt(newState.exam.questions[index].type);
    newState.exam.questions[index].score = parseInt(newState.exam.questions[index].score);
    this.setState(newState);
  }

  valueChangedForQuestionOption(index, indexOption, event) {
    const newState = {
      ...this.state,
    };
    newState.exam.questions[index].optionsList[indexOption] = event.target.value;
    this.setState(newState);
  }

  addQuestionClicked() {
    const newState = {
      ...this.state,
    };
    newState.exam.questions.push({
      name: '',
      type: 0,
      optionsList: [],
      answer: '',
      score: 0,
      isOptional: false,
    });
    this.setState(newState);
  }

  addOptionClicked(index) {
    const newState = {
      ...this.state,
    };
    newState.exam.questions[index].optionsList.push('');
    this.setState(newState);
  }

  async saveClicked() {
    if (this.state.loading) {
      return;
    }

    this.setState({
      ...this.state,
      error: null,
      loading: true,
    });

    if (this.state.exam.name.length < 3) {
      this.setState({
        ...this.state,
        error: 'The name cannot be shorter than 3 characters.',
        loading: false,
      });
      return;
    }


    if (isNaN(parseInt(this.state.exam.timeLimitSeconds))) {
      this.setState({
        ...this.state,
        error: 'The time limit must be an integer.',
        loading: false,
      });
      return;
    }

    if (isNaN(parseInt(this.state.exam.gradingScoreMin))) {
      this.setState({
        ...this.state,
        error: 'The min grading score must be an integer.',
        loading: false,
      });
      return;
    }

    if (isNaN(parseInt(this.state.exam.gradingScoreMax))) {
      this.setState({
        ...this.state,
        error: 'The max grading score must be an integer.',
        loading: false,
      });
      return;
    }


    if (parseInt(this.state.exam.timeLimitSeconds) <= 0) {
      this.setState({
        ...this.state,
        error: 'The time limit must be greater than 0.',
        loading: false,
      });
      return;
    }

    if (parseInt(this.state.exam.gradingScoreMin) <= 0) {
      this.setState({
        ...this.state,
        error: 'The min grading score must be greater than 0.',
        loading: false,
      });
      return;
    }

    if (parseInt(this.state.exam.gradingScoreMax) <= 0) {
      this.setState({
        ...this.state,
        error: 'The max grading score must be greater than 0.',
        loading: false,
      });
      return;
    }


    if (this.state.exam.questions.length <= 0) {
      this.setState({
        ...this.state,
        error: 'There must be at least one question in the test.',
        loading: false,
      });
      return;
    }


    if (this.state.exam.questions.filter(q => q.name.length < 3).length > 0) {
      this.setState({
        ...this.state,
        error: 'All questions must have a name longer than 2 characters.',
        loading: false,
      });
      return;
    }

    if (this.state.exam.questions.filter(q => isNaN(parseInt(q.score))).length > 0) {
      this.setState({
        ...this.state,
        error: 'All questions must have integer scores.',
        loading: false,
      });
      return;
    }

    if (this.state.exam.questions.filter(q => parseInt(q.score) <= 0).length > 0) {
      this.setState({
        ...this.state,
        error: 'All questions must have integer scores greater than 0.',
        loading: false,
      });
      return;
    }

    if (this.state.exam.questions.filter(q => q.answer.length <= 0).length > 0) {
      this.setState({
        ...this.state,
        error: 'All questions must have answers',
        loading: false,
      });
      return;
    }

    try {
      let response = null;
      if (this.state.editing) {
        response = await this.context.api.put(`/teacher/exams/${this.state.exam.examId}`, {
          ...this.state.exam,
          scoreMax: this.getScore(),
        });
      } else {
        response = await this.context.api.post(`/teacher/exams`, {
          ...this.state.exam,
          scoreMax: this.getScore(),
        });
      }
    } catch(err) {
      this.setState({
        ...this.state,
        error: 'There was an error, please try again.',
        loading: false,
      });
      return;
    }

    this.setState({
      ...this.state,
      redirect: '/exams',
    });
  }

  getScore() {
    return this.state.exam.questions
      .filter(q => !q.isOptional)
      .map(q => q.score)
      .reduce((a, b) => parseInt(a) + parseInt(b), 0);
  }

  render() {
    if (this.state.redirect) {
      return <Redirect to={this.state.redirect} />
    }

    const score = this.getScore();

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
          title="Exam Writer"
        >
          {this.state.editing ? `Here you can edit an exam` : `Here you can create an exam`}
        </Heading>

        <ul className="list list--dashed mt-1">
          {error}
          <li className="list__item">
            <Input
              label="Exam name"
              value={this.state.exam.name}
              maxLength="200"
              onChange={this.valueChangedForExam.bind(this, 'name')}
            />
          </li>

          {this.state.exam.questions.map((q, index) => {
            return (
              <li
                className="list__item"
                key={index}
              >
                <Question
                  key={index}
                  visualKey={index}
                  name={q.name}
                  type={q.type}
                  optionsList={q.optionsList}
                  answer={q.answer}
                  score={q.score}
                  isOptional={q.isOptional}
                  onChange={this.valueChangedForQuestion.bind(this, index)}
                  onOptionChange={this.valueChangedForQuestionOption.bind(this, index)}
                  addOptionClicked={this.addOptionClicked.bind(this, index)} />
              </li>
            );
          })}

          <li className="list__item">
            <Button onClick={this.addQuestionClicked.bind(this)}>Add question</Button>
          </li>

          <li className="list__item">
            <Input
              label="Time limit in seconds"
              value={this.state.exam.timeLimitSeconds}
              type="number"
              onChange={this.valueChangedForExam.bind(this, 'timeLimitSeconds')}
            />
          </li>
          
          <li className="list__item">
            <Input
              label="Score for a minimum grade"
              value={this.state.exam.gradingScoreMin}
              type="number"
              onChange={this.valueChangedForExam.bind(this, 'gradingScoreMin')}
            />
          </li>

          <li className="list__item">
            <Input
              label="Score for a maximum grade"
              value={this.state.exam.gradingScoreMax}
              type="number"
              onChange={this.valueChangedForExam.bind(this, 'gradingScoreMax')}
            />
          </li>

          <li className="list__item">
            Total possible score: {score}
          </li>

          <li className="list__item">
            <select className="input__tag" onChange={this.valueChangedForExam.bind(this, 'roundingMethod')}>
              <option value={0}>Rounding: Closest</option>
              <option value={1}>Rounding: Up</option>
              <option value={2}>Rounding: Down</option>
            </select>
          </li>

          <li className="list__item">
            <Button onClick={this.saveClicked.bind(this)}>Save</Button>
            <Button href="/exams">Back to exams</Button>
          </li>
        </ul>
      </Page>
    );
  }
}

export default ExamWriter
