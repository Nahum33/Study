import React, { Component } from 'react';
import './FilterBar.css';
import store from '../../Store';
import { onFilterBarChange } from './Actions';

export default class FilterBar extends Component {

  handleInputChange = (event) => {
    const newInputValue = event.target.value;
    store.dispatch(onFilterBarChange(newInputValue));
  };

  render() {
    return (
        <div>
          <input
            type="text"
            onChange={this.handleInputChange}
            placeholder="Search for products"
          />
        </div>
    );
  }
}
