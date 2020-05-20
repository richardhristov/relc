import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Heading from './Heading';
import Page from './Page';
import Button from './Button';
import Attempt from './Attempt';

class ExamListItem extends Component {
  render() {
    if (this.props.taken) {
      return (
        <Attempt
          examName={this.props.taken.exam.name}
          gradeRounded={this.props.taken.gradeRounded}
          score={this.props.taken.score}
          timeTaken={this.props.taken.timeTaken} />
      );
    }
    return (
      <div className="exam">
        <b>{this.props.name}</b>
      </div>
    );
  }
}

class Exams extends Component {
  static contextType = Context;

  constructor(props) {
    super(props);

    this.state = {
      redirect: false,
      loading: true,
      taken: null,
      exams: [],
    };
  }

  async componentDidMount() {
    document.title = 'Exams';

    await this.load('untaken');
  }

  async load(taken) {
    const response = await this.context.api.get(
      taken === 'untaken' ? `/student/exams/untaken` : '/student/attempts');
    this.setState({
      ...this.state,
      loading: false,
      exams: response.data,
      taken,
    });
  }

  async takenChanged(event) {
    this.setState({
      ...this.state,
      exams: [],
      loading: true,
    });
    await this.load(event.target.value);
  }

  render() {
    if (this.state.redirect) {
      return <Redirect to={this.state.redirect} />
    }

    return (
      <Page>
        <Heading
          title="Exams"
        >
          Here you can see all the exams
        </Heading>



        <ul className="list mt-1">
          <li className="list__item">
            <select className="input__tag" onChange={this.takenChanged.bind(this)} value={this.state.taken}>
              <option value={'untaken'}>Show untaken exams</option>
              <option value={'taken'}>Show taken exams</option>
            </select>
          </li>
          {this.state.exams.map((exam, index) => {
            return (
              <li
                className="list__item"
                key={index}
              >
                <ExamListItem
                  key={index}
                  name={exam.name}
                  isActive={exam.isActive}
                  taken={this.state.taken === 'taken' ? exam : false} />
                <Button 
                  hidden={!exam.isActive || this.state.taken === 'taken'} 
                  to={{
                    pathname: '/exams-take',
                    state: { examId: exam.examId }
                  }}
                >
                  Take
                </Button>
              </li>
            );
          })}

          <li className="list__item">
            <Button href="/dashboard">Back to dashboard</Button>
          </li>
        </ul>
      </Page>
    );
  }
}

export default Exams
