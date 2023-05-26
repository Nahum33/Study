import React, { Component } from 'react';
import store from '../../Store';
import Products from '../../components/Products/Products';
import { fetchProductsRequest } from '../../components/Products/Actions';

export default class Home extends Component {

  componentDidMount() {
    store.dispatch(fetchProductsRequest());
  }

  render() {

    return (
      <section>
        <header>
          <h1>Verdifrut</h1>
          <p>Pod�s pedir los productos verdifrut que ves a continuaci�n, lo m�s fresco de verduras y frutas hasta la puerta de tu casa.</p>
        </header>
        <hr />
        <Products />
      </section>
    );
  }
}
