import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Heading from './Heading';
import Page from './Page';
import Button from './Button';

class Attempt extends Component {
  render() {
    return (
      <div className="attempt">
        <b>{this.props.examName}</b>, student username: {this.props.studentUsername}, grade: {this.props.grade}=>{this.props.gradeRounded}, score: {this.props.score}, time taken: {this.props.timeTaken}
      </div>
    );
  }
}

class Attempts extends Component {
  static contextType = Context;

  constructor(props) {
    super(props);

    this.state = {
      redirect: false,
      loading: true,
      examId: null,
      attempts: [],
    };
  }

  async componentDidMount() {
    document.title = 'Exam attempts';

    if (this.props.location && this.props.location.state && this.props.location.state.examId) {
      await this.load(this.props.location.state.examId);
      return;
    }

    await this.load();
  }

  async load(examId) {
    const response = await this.context.api.get(`/teacher/attempts`);
    let attempts = response.data;
    if (examId) {
      console.log(attempts);
      attempts = attempts.filter(a => a.examId === examId);
      console.log(attempts);
    }
    this.setState({
      ...this.state,
      loading: false,
      attempts,
    });
  }

  render() {
    if (this.state.redirect) {
      return <Redirect to={this.state.redirect} />
    }

    return (
      <Page>
        <Heading
          title="Exam attempts"
        >
          Here you can see all the exam attempts by students
        </Heading>

        <ul className="list mt-1">
          {this.state.attempts.map((attempt, index) => {
            return (
              <li className="list__item" key={index}>
                <Attempt
                  key={index}
                  examName={attempt.exam.name}
                  studentUsername={attempt.login.username}
                  score={attempt.score}
                  grade={attempt.grade}
                  gradeRounded={attempt.gradeRounded}
                  timeTaken={attempt.timeTaken} />
              </li>
            );
          })}
        </ul>

        <div className="mt-1">
          <Button href="/dashboard">Back to dashboard</Button>
        </div>
      </Page>
    );
  }
}

export default Attempts
