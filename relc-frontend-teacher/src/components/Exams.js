import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Heading from './Heading';
import Page from './Page';
import Button from './Button';

class ExamListItem extends Component {
  render() {
    return (
      <div className="exam">
        <b>{this.props.name}</b>, status: <b>{this.props.isActive ? 'active' : 'inactive'}</b>
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
      exams: [],
    };
  }

  async componentDidMount() {
    document.title = 'Exams';

    await this.load();
  }

  async load() {
    const response = await this.context.api.get(`/teacher/exams`);
    this.setState({
      ...this.state,
      loading: false,
      exams: response.data,
    });
  }

  async deleteClicked(id) {
    await this.context.api.delete(`/teacher/exams/${id}`);

    await this.load();
  }

  async activateClicked(id, exam) {
    await this.context.api.put(`/teacher/exams/${id}`, {
      ...exam,
      isActive: true,
    });

    await this.load();
  }

  async deactivateClicked(id, exam) {
    await this.context.api.put(`/teacher/exams/${id}`, {
      ...exam,
      isActive: false,
    });

    await this.load();
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

        <ul className="list">
          {this.state.exams.map((exam, index) => {
            return (
              <li
                className="list__item"
                key={index}
              >
                <ExamListItem
                  key={index}
                  name={exam.name}
                  isActive={exam.isActive} />
                <Button 
                  hidden={!exam.isEditable} 
                  to={{
                    pathname: '/exams-edit',
                    state: { examId: exam.examId }
                  }}
                >
                  Edit
                </Button>
                <Button 
                  hidden={!exam.isEditable} 
                  onClick={this.deleteClicked.bind(this, exam.examId)}
                >
                  Delete
                </Button>
                <Button
                  hidden={exam.isActive} 
                  onClick={this.activateClicked.bind(this, exam.examId, exam)}
                >
                  Activate
                </Button>
                <Button
                  hidden={!exam.isActive} 
                  onClick={this.deactivateClicked.bind(this, exam.examId, exam)}
                >
                  Deactivate
                </Button>
                <Button 
                  to={{
                    pathname: '/attempts',
                    state: { examId: exam.examId }
                  }}
                >
                  Show attempts
                </Button>
              </li>
            );
          })}
        </ul>

        <ul className="list mt-1">
          <li className="list__item">
            <Button href="/exams-create">Create exam</Button>
          </li>
          <li className="list__item">
          <Button href="/dashboard">Back to dashboard</Button>
          </li>
        </ul>
      </Page>
    );
  }
}

export default Exams
