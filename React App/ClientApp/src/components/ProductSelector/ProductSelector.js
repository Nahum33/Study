import React, { Component } from 'react';
import store from '../../store/Store';
import Products from '../Products/Products';

import { getSortedObjectsListByPropertyAndSearchTerm } from '../../utils/ListSorterHelper';
import { isEqualLists } from '../../utils/ListCompareHelper';
import { getListWithUpdatedPropertyByIdList } from '../../utils/ListFilterHelper';
import { fetchProductsRequest, updateProducts } from '../../store/actions/ProductsActions';
import './ProductSelector.css';

export default class ProductSelector extends Component {

  handleSearchTermChange(){
    const searchTermFromStore = store.getState().filterBarReducer.searchTerm;
    const productsFromStore = store.getState().productsReducer.products;
    const sortedProductsList = getSortedObjectsListByPropertyAndSearchTerm({
      searchTerm: searchTermFromStore,
      objectList: productsFromStore,
      propertyName: 'name'
    });

    if(!isEqualLists({ listA: sortedProductsList, listB: productsFromStore})){
      store.dispatch(updateProducts(sortedProductsList));
    }
  }

  handleCategoryChange(){
    const categoryFromStore = store.getState().filterBarReducer.category;
    const currentListNameFromStore = store.getState().productsReducer.currentListName;
    if(!categoryFromStore || categoryFromStore === currentListNameFromStore){
      return;
    }

    const filters = {
      listName: categoryFromStore,
    }
    store.dispatch(fetchProductsRequest(filters));
  }

  SelectedProductsChange(){
    const productsFromStore = store.getState().productsReducer.products;
    const selectedProductsFromStore = store.getState().productsReducer.selectedProducts;
    const productsIdListToUpdate = selectedProductsFromStore.map(obj => obj.id);
    const updatedProductsList = getListWithUpdatedPropertyByIdList({
      objectList: productsFromStore,
      propertyName: 'isSelected',
      value: true,
      filterIdList: productsIdListToUpdate
    });

    if(!isEqualLists({ listA: updatedProductsList, listB: productsFromStore})){
      store.dispatch(updateProducts(updatedProductsList));
    }
  }

  componentDidMount() {
    this.unsubscribeSearchTerm = store.subscribe(this.handleSearchTermChange.bind(this));
    this.unsubscribeSelectedProducts = store.subscribe(this.SelectedProductsChange.bind(this));
    this.unsubscribeHandleCategoryChange = store.subscribe(this.handleCategoryChange.bind(this));
    const filters = {
      listName: 'loMasVendido',
    }
    store.dispatch(fetchProductsRequest(filters));
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