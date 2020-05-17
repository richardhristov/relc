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
    };
  }

  async componentDidMount() {
    document.title = 'Dashboard';

    const login = await this.context.api.get(`/logins/${this.context.loginId}`);
      this.setState({
        ...this.state,
        loading: false,
        username: login.data.username,
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
          Hello there, {this.state.username}
        </Heading>
        
        <Button href="/exams">Exams</Button>
        <Button href="/attempts">Exam attempts</Button>
      </Page>
    );
  }
}

export default Dashboard
