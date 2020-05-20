import React, { Component } from 'react';
import InputNumber from 'react-input-just-numbers';
import InputMask from 'react-input-mask';

class Input extends Component {
  onChange(e) {
    if (!this.props.onChange) {
      return;
    }
    if (this.props.mask && this.props.maskRegex) {
      const maskRegex = new RegExp(this.props.maskRegex);
      const m = maskRegex.exec(e.target.value)
      e.target.rawValue = e.target.value;
      e.target.value = m && m[1] ? m[1] : null;
    }
    this.props.onChange(e);
  }

  render() {
    if (this.props.hidden) {
      return null;
    }

    const modifiers = this.props.modifiers || ['underline',];
    const modifierClassnames = modifiers
      .map(m => `input--${m}`);
    const className = this.props.className || ['input', ...modifierClassnames].join(' ');

    let Tag = 'input';
    let type = this.props.type || 'text';
    if (type === 'textarea') {
      Tag = 'textarea';
      type = null;
    }
    if (type === 'number') {
      Tag = InputNumber;
    }

    let label = null;
    let id = null;
    if (this.props.label) {
      id = `input${Math.random()}`;
      label = (
        <label
          className="input__label"
          htmlFor={id}
        >
          {this.props.label}
        </label>
      );
    }

    const maskProps = {};
    if ((type === 'number' || type === 'text') && this.props.mask) {
      Tag = InputMask;
      maskProps['mask'] = this.props.mask;
      maskProps['maskChar'] = this.props.maskChar || ' ';
      maskProps['alwaysShowMask'] = this.props.alwaysShowMask;
    }

    // TODO validation
    return (
      <div
        className={className}
      >
        {label}
        <Tag
          className="input__tag"
          id={id}
          placeholder={this.props.label || this.props.placeholder}
          type={type}
          value={this.props.type !== 'textarea' ? this.props.value || '' : null}
          readOnly={this.props.readOnly}
          disabled={this.props.disabled}
          maxLength={this.props.maxLength}
          {...maskProps}
          onClick={this.props.onClick}
          onChange={this.onChange.bind(this)}
        >
          {this.props.type === 'textarea' ? this.props.value : null}
        </Tag>
      </div>
    );
  }
}

export default Input
