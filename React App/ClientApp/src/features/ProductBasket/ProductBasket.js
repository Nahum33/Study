import React, { Component } from 'react';
import BasketProductItems from '../../components/BasketProductItems/BasketProductItems';

export default class ProductBasket extends Component {

  render() {
    return (
      <div>
        Canasta de productos | EDITAR | ELIMINAR
        <BasketProductItems />
      </div>
    );
  }
};