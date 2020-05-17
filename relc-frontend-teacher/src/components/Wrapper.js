import React, { Component } from 'react';

class Wrapper extends Component {
  render() {
    const modifiers = this.props.modifiers || ['page',];
    const modifierClassnames = modifiers
      .map(m => `wrapper--${m}`);
    const className = this.props.className || ['wrapper', ...modifierClassnames].join(' ');
    
    const wrapper = (
      <main className={className}>
        {this.props.children}
      </main>
    );

    if (!this.props.vertical) {
      return wrapper;
    }

    return (
      <div className="wrapper-vertical">
        {wrapper}
      </div>
    );
  }
}

export default Wrapper
