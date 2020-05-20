import React, { Component } from 'react';

class Attempt extends Component {
  render() {
    return (
      <div class="attempt">
        <b>{this.props.examName}</b>, grade: <b>{this.props.gradeRounded}</b>, score: {this.props.score}, time taken: {this.props.timeTaken}
      </div>
    );
  }
}

export default Attempt
