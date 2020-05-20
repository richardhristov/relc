import React, { Component } from 'react';

import Header from './Header';
import Footer from './Footer';
import Wrapper from './Wrapper';

class Page extends Component {
  render() {
    return (
      <div>
        <Header />
        <Wrapper
          vertical={this.props.vertical}
          modifiers={this.props.modifiers}
        >
          {this.props.children}
        </Wrapper>
        <Footer />
      </div>
    );
  }
}

export default Page
