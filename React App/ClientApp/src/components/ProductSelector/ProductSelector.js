import React, { Component } from 'react';
import store from '../../store/Store';
import Products from '../Products/Products';
import { updateProductNameFilter, updateProductCategoryFilter, fetchProductsRequest } from '../../store/actions/ProductSelectorActions';
import './ProductSelector.css';

export default class ProductSelector extends Component {

  handleSearchTermChange(){
    const searchTerm = store.getState().filterBarReducer.searchTerm;
    const productNameFilter = store.getState().productSelectorReducer.filters.productName;
    if(searchTerm === productNameFilter){
      return;
    }
    store.dispatch(updateProductNameFilter(searchTerm));
    store.dispatch(fetchProductsRequest());
  }

  handleCategoryChange(){
    const category = store.getState().filterBarReducer.category;
    const productCategoryFilter = store.getState().productSelectorReducer.filters.productCategory;
    if(category === productCategoryFilter){
      return;
    }
    store.dispatch(updateProductCategoryFilter(category));
    store.dispatch(fetchProductsRequest());
  }

  handleSelectedProductsChange(){
  }

  componentDidMount() {
    this.unsubscribeSearchTerm = store.subscribe(this.handleSearchTermChange.bind(this));
    this.unsubscribeSelectedProducts = store.subscribe(this.handleSelectedProductsChange.bind(this));
    this.unsubscribeHandleCategoryChange = store.subscribe(this.handleCategoryChange.bind(this));
    store.dispatch(fetchProductsRequest());
  }

  componentWillUnmount() {
    this.unsubscribeSearchTerm();
    this.unsubscribeSelectedProducts();
    this.unsubscribeHandleCategoryChange();
  }

  render() {
    return (
      <>
        <Products />
      </>
    );
  }
};