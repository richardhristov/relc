import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Attempt from './Attempt';
import Heading from './Heading';
import Page from './Page';
import Button from './Button';

class Attempts extends Component {
  static contextType = Context;

  constructor(props) {
    super(props);

    this.state = {
      redirect: false,
      loading: true,
      attempts: [],
    };
  }

  async componentDidMount() {
    document.title = 'Exam attempts';

    await this.load();
  }

  async load() {
    const response = await this.context.api.get(`/student/attempts`);
    this.setState({
      ...this.state,
      loading: false,
      attempts: response.data,
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
          Here you can see your exam attempts
        </Heading>

        <ul className="list">
          {this.state.attempts.map((attempt, index) => {
            return (
              <li key={index}>
                <Attempt
                  key={index}
                  examName={attempt.exam.name}
                  score={attempt.score}
                  grade={attempt.grade}
                  gradeRounded={attempt.gradeRounded}
                  timeTaken={attempt.timeTaken} />
              </li>
            );
          })}
        </ul>

        <Button href="/dashboard">Back to dashboard</Button>
      </Page>
    );
  }
}

export default Attempts
