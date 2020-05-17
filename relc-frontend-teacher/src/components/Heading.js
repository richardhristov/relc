import React, { Component } from 'react';

class Heading extends Component {
  render() {
    var image = null;
    if (this.props.image) {
      image = (
        <img
          className="heading__image"
          alt={this.props.title}
          src={this.props.image} />
      );
    }

    return (
      <div className="heading">
        {image}
        <h1 className="heading__title">{this.props.title}</h1>
        {this.props.children}
      </div>
    );
  }
}

export default Heading