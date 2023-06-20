import React, { Component } from 'react';
import SelectedProducts from '../../components/SelectedProducts/SelectedProducts';

export default class SelectedProductToteBag extends Component {

  render() {
    return (
      <div>
        Canasta de productos | EDITAR | ELIMINAR
        <SelectedProducts />
      </div>
    );
  }
};