import React, { Component } from 'react';
import './FilterBar.css';
import store from '../../store/Store';
import { onSearchTermValueChange, onCategoryValueChange } from '../../store/actions/FilterBarActions';
import './FilterBar.css'

export default class FilterBar extends Component {

  handleInputChange = (event) => {
    const newInputValue = event.target.value;
    store.dispatch(onSearchTermValueChange(newInputValue));
  };

  handleSelectChange = (event) => {
    const selectedValue = event.target.value;
    store.dispatch(onCategoryValueChange(selectedValue));
  };

  render() {
    return (
      <form className='search-form'>
        <div className='select-wrapper'>
          <select name='category' className='search-select' onChange={this.handleSelectChange}>
            <option className='select-option' value='' defaultValue>Todos los productos</option>
            <option className='select-option' value='fruta'>Frutas</option>
            <option className='select-option' value='verdura'>Verduras</option>
            <option className='select-option' value='hortaliza'>Hortalizas</option>
            <option className='select-option' value='otro'>Varios</option>
          </select>
          <span className='select-icon'>
            <i className='fa fa-chevron-down'></i>
          </span>
        </div>
        <div className='search-wrapper'>
          <input type='text' name='search' className='search-input' placeholder='Buscar frutas, verduras y otros productos' onChange={this.handleInputChange}/>
          <button type='button' className='search-button'>
            <i className='fa fa-search search-button-icon'></i>Buscar
          </button>
        </div>
      </form>
    );
  }
}
