import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Heading from './Heading';
import Page from './Page';
import Button from './Button';

class Dashboard extends Component {
  static contextType = Context;

  constructor(props) {
    super(props);

    this.state = {
      redirect: false,
      loading: true,
      username: '',
      nameFirst: '',
      nameLast: '',
    };
  }

  async componentDidMount() {
    document.title = 'Dashboard';

    const login = await this.context.api.get(`/logins/${this.context.loginId}`);
      this.setState({
        ...this.state,
        loading: false,
        username: login.data.username,
        nameFirst: login.data.nameFirst,
        nameLast: login.data.nameLast,
      });
  }

  logoutClicked() {
    this.context.token = null;
    localStorage.removeItem('token');
    this.context.loginId = null;
    localStorage.removeItem('loginId');

    this.setState({
      ...this.state,
      loading: false,
      redirect: '/',
    });
  }

  render() {
    if (this.state.redirect) {
      return <Redirect to={this.state.redirect} />
    }

    return (
      <Page>
        <Heading
          title="Dashboard"
        >
          Hello there, {this.state.nameFirst} {this.state.nameLast}
        </Heading>
        
        <ul className="list mt-1">
          <li className="list__item">
            <Button href="/exams">Exams</Button>
          </li>
          <li className="list__item">
            <Button href="/attempts">Exam attempts</Button>
          </li>
          <li className="list__item">
          <Button onClick={this.logoutClicked.bind(this)}>Logout</Button>
          </li>
        </ul>
      </Page>
    );
  }
}

export default Dashboard
