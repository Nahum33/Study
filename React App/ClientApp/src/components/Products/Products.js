import React, { Component } from 'react';
import Product from './Product';
import store from '../../store/Store';

export default class Products extends Component {
  state = {
    products: store.getState().productSelectorReducer.products
  };

  handleStoreChange = () => {
    const productsFromStore = store.getState().productSelectorReducer.products;
    this.setState({ products: productsFromStore });
  }
  
  componentDidMount() {
    this.unsubscribeHandleStoreChange = store.subscribe(this.handleStoreChange);
  }

  componentWillUnmount() {
    this.unsubscribeHandleStoreChange();
  }

  render() {
    const { products } = this.state

    return (
      <ul>
        {products.map(product => (
          <Product key={product.productId} product={product} />
        ))}
      </ul>
    );
  }
}