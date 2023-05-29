import React, { Component } from "react";
import store from '../../Store';
import Products from '../Products/Products';
import FilterBar from '../FilterBar/FilterBar';
import sortByPropertyAndSearchTerm from '../Utils/ListSorterHelper';
import { fetchProductsRequest, updateProducts } from '../Products/Actions';

export default class ProductSelector extends Component {

  handleStoreChange(){
    const searchTermFromStore = store.getState().filterBarReducer.searchTerm;
    const productsFromStore = store.getState().productsReducer.products;
    const sortedProductsList = sortByPropertyAndSearchTerm({
      searchTerm: searchTermFromStore,
      objectList: productsFromStore,
      propertyName: "name"
    });

    if(sortedProductsList !== productsFromStore){
      store.dispatch(updateProducts(sortedProductsList)); 
    }
  }
  
  componentDidMount() {
    store.subscribe(this.handleStoreChange);
    store.dispatch(fetchProductsRequest());    
  }

  componentWillUnmount() {
    store.unsubscribe(this.handleStoreChange);
  }

  render() {
    return (
      <div>
        <FilterBar />
        <Products />
      </div>
    );
  }
};