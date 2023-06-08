import React, { Component } from 'react';
import BasketProductItem from "./BasketProductItem";
import store from '../../redux/Store';

export default class BasketProductItems extends Component {
  state = {
    chosenProducts: store.getState().productsReducer.chosenProducts
  };

  handleStoreChange = () => {
    const chosenProductsFromStore = store.getState().productsReducer.chosenProducts;
    this.setState({ chosenProducts: chosenProductsFromStore });
  }
  
  componentDidMount() {
    store.subscribe(this.handleStoreChange);
  }

  componentWillUnmount() {
    store.unsubscribe(this.handleStoreChange);
  }

  render() {
    const { chosenProducts } = this.state

    return (
      <ul>
        {chosenProducts.map(chosenProduct => (
          <BasketProductItem key={chosenProduct.id} product={chosenProduct} />
        ))}
      </ul>
    );
  }
}