import React, { Component } from 'react';
import SelectedProducts from '../../components/SelectedProducts/SelectedProducts';
import './SelectedProductToteBag.css';

export default class SelectedProductToteBag extends Component {

  render() {
    return (
      <section className='selected-product-tote-bag'>
        <header>
          <h2>Canasta de productos</h2>
        </header>
        <div className='selected-products'>
          <SelectedProducts />
        </div>        
      </section>
    );
  }
};