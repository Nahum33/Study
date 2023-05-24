import React, { Component } from 'react';
import Products from '../../components/Products/Products';

export default class Home extends Component {
  constructor({ store }) {
    super();
    this.store = store
  }

  componentDidMount() {
    this.store.dispatch({ type: 'FETCH_PRODUCTS_REQUEST' });
  }

  render() {

    return (
      <section>
        <header>
          <h1>Verdifrut</h1>
          <p>Podés pedir los productos verdifrut que ves a continuación, lo más fresco de verduras y frutas hasta la puerta de tu casa.</p>
        </header>

        <hr />

        <Products store={ this.store } />

      </section>
    );
  }
}
