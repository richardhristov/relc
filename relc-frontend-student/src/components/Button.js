import React, { Component } from 'react';
import {
  Link,
} from "react-router-dom";

class Button extends Component {
  render() {
    if (this.props.hidden) {
      return null;
    }
    
    const modifiers = this.props.modifiers || ['pill',];
    const modifierClassnames = modifiers
      .map(m => `btn--${m}`);
    const className = this.props.className || ['btn', ...modifierClassnames].join(' ');

    let type = this.props.type ? this.props.type : 'button';
    if (this.props.href) {
      type = null;
    }

    let Tag = 'button';
    if (this.props.href) {
      Tag = 'a';
    }
    if (this.props.to) {
      Tag = Link;
    }

    return (
      <Tag
        href={this.props.href}
        to={this.props.to}
        type={type}
        className={className}
        disabled={this.props.disabled}
        title={this.props.title}
        onClick={this.props.onClick}
      >
        {this.props.children}
      </Tag>
    );
  }
}

export default Button
