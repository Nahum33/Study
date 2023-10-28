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
            <option className='select-option' value='' defaultValue>Categorias</option>
            <option className='select-option' value='fruta'>Hamburguesas</option>
            <option className='select-option' value='verdura'>Sandwichs</option>
            <option className='select-option' value='hortaliza'>Con Papas</option>
            <option className='select-option' value='otro'>Pollos</option>
            <option className='select-option' value='otro'>Refrescos</option>
          </select>
          <span className='select-icon'>
            <i className='fa fa-chevron-down'></i>
          </span>
        </div>
        <div className='search-wrapper'>
          <input type='text' name='search' className='search-input' placeholder='Nombre del combo' onChange={this.handleInputChange}/>
          <button type='button' className='search-button'>
            <i className='fa fa-search search-button-icon'></i>Buscar
          </button>
        </div>
      </form>
    );
  }
}
