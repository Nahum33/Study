import React, { Component } from 'react';
import Product from "./Product";
import store from '../../Store';

export default class Products extends Component {
  state = {
    products: store.getState().productsReducer.products
  };

  handleStoreChange = () => {
    this.setState({ products: store.getState().productsReducer.products });
  }
  
  componentDidMount() {
    store.subscribe(this.handleStoreChange);
  }

  componentWillUnmount() {
    store.unsubscribe(this.handleStoreChange);
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