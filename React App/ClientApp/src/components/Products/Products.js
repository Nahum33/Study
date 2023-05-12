import React, { Component } from 'react';
import Product from "./Product";

export default class Products extends Component {

  constructor(properties) {
    super(properties);
    this.products = [
      { id: 1, name: "Producto 1", price: 10 },
      { id: 2, name: "Producto 2", price: 20 },
      { id: 3, name: "Producto 3", price: 30 }
    ];
  }

  render() {
    return (
      <ul>
        {this.products.map(product => (
          <Product key={product.id} product={product} />
        ))}
      </ul>
    );
  }
}