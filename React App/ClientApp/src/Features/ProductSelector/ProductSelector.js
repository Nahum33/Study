import React, { Component } from "react";
import store from '../../Redux/Store';
import Products from '../../Components/Products/Products';
import FilterBar from '../../Components/FilterBar/FilterBar';
import sortByPropertyAndSearchTerm from '../../Components/Utils/ListSorterHelper';
import { fetchProductsRequest, updateProducts } from '../../Components/Products/Actions';

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