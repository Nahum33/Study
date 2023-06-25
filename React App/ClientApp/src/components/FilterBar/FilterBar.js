import React, { Component } from 'react';
import './FilterBar.css';
import store from '../../store/Store';
import { onFilterBarChange } from '../../store/actions/FilterBarActions';
import './FilterBar.css'

export default class FilterBar extends Component {

  handleInputChange = (event) => {
    const newInputValue = event.target.value;
    store.dispatch(onFilterBarChange(newInputValue));
  };

  render() {
    return (
      <form className='search-form'>
        <div className='search-wrapper'>
          <select name='category' className='search-select'>
            <option className='select-option' value='defaultValue' defaultValue>Todas las categorías</option>
            <option className='select-option' value='fruta'>Fruta</option>
            <option className='select-option' value='verdura'>Verdura</option>
            <option className='select-option' value='hortaliza'>Hortaliza</option>
          </select>
          <span className='select-icon'>
            <i className='fa fa-chevron-down'></i>
          </span>
        </div>
        <input type='text' name='search' className='search-input' placeholder='Buscar frutas, verduras y otros productos' onChange={this.handleInputChange}/>
        <button type='button' className='search-button'>
          <i className='fa fa-search search-button-icon'></i>Buscar
        </button>
      </form>
    );
  }
}
