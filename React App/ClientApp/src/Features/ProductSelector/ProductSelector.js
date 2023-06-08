import React, { Component } from "react";
import store from '../../redux/Store';
import Products from '../../components/Products/Products';
import FilterBar from '../../components/FilterBar/FilterBar';
import sortByPropertyAndSearchTerm from '../../components/Utils/ListSorterHelper';
import { fetchProductsRequest, updateProducts } from '../../components/Products/Actions';

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