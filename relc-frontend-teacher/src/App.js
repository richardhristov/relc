import React, { Component, useContext } from 'react';
import {
  BrowserRouter as Router,
  Route,
  Redirect,
} from "react-router-dom";
import axios from 'axios';

import config from './config';
import Context from './Context';
import Login from './components/Login';
import Dashboard from './components/Dashboard';
import Exams from './components/Exams';
import ExamWriter from './components/ExamWriter';
import Attempts from './components/Attempts';

function RouteAuth({ component: Component, ...rest }) {
  const context = useContext(Context);

  return (
    <Route
      {...rest}
      render={props =>
        context.token && context.loginId ? (
          <Component {...props} />
        ) : (
          <Redirect to="/" />
        )
      }
    />
  );
}

class App extends Component {
  render() {
    const context = {
      token: null,
      loginId: null,
    };

    const token = localStorage.getItem('token');
    const loginId = localStorage.getItem('loginId');
    if (token && loginId) {
      context.token = token;
      context.loginId = loginId;
    }

    const api = axios.create({
      baseURL: `http://${config.domainApi}`,
    });
    api.interceptors.request.use(config => {
      if (context.token) {
        config.headers.Authorization = 'Bearer ' + context.token;
      }
      return config;
    });
    api.interceptors.response.use(
      response => response,
      function (error) {
        // TODO better error handling
        console.error(error);
        //window.alert(error);
        return Promise.reject(error);
      }
    );
    context.api = api;

    return (
      <Context.Provider value={context}>
        <Router>
          <Route exact path="/" component={Login} />

          <RouteAuth path="/dashboard" component={Dashboard} />
          <RouteAuth path="/exams" component={Exams} />
          <RouteAuth path="/exams-create" component={ExamWriter} />
          <RouteAuth path="/exams-edit" component={ExamWriter} />
          <RouteAuth path="/attempts" component={Attempts} />
        </Router>
      </Context.Provider>
    );
  }
}

export default App
