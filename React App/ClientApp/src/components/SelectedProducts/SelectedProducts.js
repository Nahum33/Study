import React, { Component } from 'react';
import SelectedProduct from './SelectedProduct';
import store from '../../store/Store';

export default class SelectedProducts extends Component {
  state = {
    selectedProducts: store.getState().productsReducer.selectedProducts
  };

  handleStoreChange = () => {
    const selectedProductsFromStore = store.getState().productsReducer.selectedProducts;
    this.setState({ selectedProducts: selectedProductsFromStore });
  }
  
  componentDidMount() {
    this.unsubscribeHandleStoreChange = store.subscribe(this.handleStoreChange);
  }

  componentWillUnmount() {
    this.unsubscribeHandleStoreChange();
  }

  render() {
    const { selectedProducts } = this.state

    return (
      <ul>
        {selectedProducts.map(selectedProduct => (
          <SelectedProduct key={selectedProduct.id} product={selectedProduct} />
        ))}
      </ul>
    );
  }
}