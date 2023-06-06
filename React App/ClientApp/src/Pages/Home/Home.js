import React, { Component } from 'react';
import ProductSelector from '../../Features/ProductSelector/ProductSelector';

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
      </section>
    );
  }
}
