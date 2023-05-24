import React, { Component } from 'react';
import Product from "./Product";

export default class Products extends Component {
  constructor({ store }) {
    super();
    this.store = store
    this.state = {
      products: store.getState().productsReducer.products
    };
  }

  handleStoreChange = () => {
    this.setState({ products: this.store.getState().productsReducer.products });
  }
  
  componentDidMount() {
    this.store.subscribe(this.handleStoreChange);
  }

  componentWillUnmount() {
    this.store.unsubscribe(this.handleStoreChange);
  }

  render() {
    const { products } = this.state

    return (
      <ul>
        {products.map(product => (
          <Product key={product.id} product={product} />
        ))}
      </ul>
    );
  }
}