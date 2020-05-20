import React, { Component } from 'react';
import {
  Redirect,
} from "react-router-dom";

import Context from '../Context';

import Heading from './Heading';
import Wrapper from './Wrapper';
import Input from './Input';
import Button from './Button';

class Login extends Component {
  static contextType = Context;

  constructor(props) {
    super(props);

    this.state = {
      redirect: false,
      loading: true,
      error: null,
      username: '',
      password: '',
    };
  }

  async componentDidMount() {
    document.title = 'Login';
    if (this.context && this.context.token && this.context.loginId) {
      const login = await this.context.api.get(`/logins/${this.context.loginId}`);
      if (login && login.data && login.data.loginId) {
        this.setState({
          ...this.state,
          redirect: '/dashboard',
        });
        return;
      }
    }

    this.setState({
      ...this.state,
      loading: false,
    });
  }

  valueChanged(type, event) {
    const newState = {
      ...this.state,
    };
    newState[type] = event.target.value;
    this.setState(newState);
  }

  async submitClicked() {
    if (this.state.loading) {
      return;
    }

    this.setState({
      ...this.state,
      loading: true,
    });

    let response = null;
    try {
      response =  await this.context.api.post(`/logins/authenticate`, {
        username: this.state.username,
        password: this.state.password,
      });
    } catch(e) {}

    if (!response || !response.data || !response.data.token || !response.data.loginId) {
      this.setState({
        ...this.state,
        error: 'Username or password were invalid',
        loading: false,
      });
      return;
    }

    this.context.token = response.data.token;
    localStorage.setItem('token', response.data.token);
    this.context.loginId = response.data.loginId;
    localStorage.setItem('loginId', response.data.loginId);

    this.setState({
      ...this.state,
      redirect: '/dashboard',
    });
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
      <Wrapper
        vertical={true}
        modifiers={this.props.modifiers}
      >
        <Heading
          title="Student Login"
        >
          Please input your credentials to login.
        </Heading>

        <ul className="list mt-1 list--100">
          {error}
          <li className="list__item">
            <Input
              label="Username"
              value={this.state.username}
              maxLength="30"
              onChange={this.valueChanged.bind(this, 'username')}
            />
          </li>
          <li className="list__item">
            <Input
              label="Password"
              value={this.state.password}
              maxLength="60"
              type="password"
              onChange={this.valueChanged.bind(this, 'password')}
            />
          </li>
          <li className="list__item">
            <Button
              onClick={this.submitClicked.bind(this)}
              disabled={!(this.state.username.length >= 3 && this.state.password.length >= 3)}
            >
              Submit
            </Button>
          </li>
        </ul>
      </Wrapper>
    );
  }
}

export default Login
