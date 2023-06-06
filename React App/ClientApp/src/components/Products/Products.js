import React, { Component } from 'react';
import Product from "./Product";
import store from '../../Redux/Store';

export default class Products extends Component {
  state = {
    products: store.getState().productsReducer.products
  };

  handleStoreChange = () => {
    const productsFromStore = store.getState().productsReducer.products;
    this.setState({ products: productsFromStore });
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