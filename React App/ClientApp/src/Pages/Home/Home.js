import React, { Component } from 'react';
import ProductSelector from '../../features/ProductSelector/ProductSelector';
import ProductBasket from '../../features/ProductBasket/ProductBasket';

export default class Home extends Component {

  render() {
    return (
      <section>
        <header>
          <h1>Verdifrut</h1>
          <p>Podés pedir los productos verdifrut que ves a continuación, lo más fresco de verduras y frutas hasta la puerta de tu casa.</p>
        </header>
        <hr />
        <ProductSelector/>
        <ProductBasket/>
      </section>
    );
  }
}
