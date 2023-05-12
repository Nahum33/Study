import React, { Component } from 'react';
import Products from '../../components/Products/Products';

export default class Home extends Component {

  render() {
    return (
      <section>
        <header>
          <h1>Verdifrut</h1>
          <p>Podés pedir los productos verdifrut que ves a continuación, lo más fresco de verduras y frutas hasta la puerta de tu casa.</p>
        </header>

        <hr />

        <Products />

        <ul>
          <li><a href='/'>Example 1</a></li>
          <li><a href='/'>Example 2</a></li>
          <li><a href='/'>Example 3</a></li>
        </ul>

      </section>
    );
  }
}
