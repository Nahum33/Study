import React, { Component } from "react";
import store from '../../redux/Store';
import Products from '../../components/Products/Products';
import FilterBar from '../../components/FilterBar/FilterBar';
import { getSortedObjectsListByPropertyAndSearchTerm } from '../../components/Utils/ListSorterHelper';
import { isEqualLists } from '../../components/Utils/ListCompareHelper';
import { getListWithUpdatedPropertyByIdList } from '../../components/Utils/ListFilterHelper';
import { fetchProductsRequest, updateProducts } from '../../components/Products/Actions';

export default class ProductSelector extends Component {

  handleSearchTermChange(){
    const searchTermFromStore = store.getState().filterBarReducer.searchTerm;
    const productsFromStore = store.getState().productsReducer.products;
    const sortedProductsList = getSortedObjectsListByPropertyAndSearchTerm({
      searchTerm: searchTermFromStore,
      objectList: productsFromStore,
      propertyName: "name"
    });

    if(!isEqualLists({ listA: sortedProductsList, listB: productsFromStore})){
      store.dispatch(updateProducts(sortedProductsList));
    }
  }

  handleChosenProductsChange(){
    const productsFromStore = store.getState().productsReducer.products;
    const chosenProductsFromStore = store.getState().productsReducer.chosenProducts;
    const productsIdListToUpdate = chosenProductsFromStore.map(obj => obj.id);
    const updatedProductsList = getListWithUpdatedPropertyByIdList({
      objectList: productsFromStore,
      propertyName: "isSelected",
      value: true,
      filterIdList: productsIdListToUpdate
    });

    if(!isEqualLists({ listA: updatedProductsList, listB: productsFromStore})){
      store.dispatch(updateProducts(updatedProductsList));
    }
  }

  componentDidMount() {
    store.subscribe(this.handleSearchTermChange.bind(this));
    store.subscribe(this.handleChosenProductsChange.bind(this));
    store.dispatch(fetchProductsRequest());
  }

  componentWillUnmount() {
    store.unsubscribe(this.unsubscribeSearchTerm);
    store.unsubscribe(this.unsubscribeChosenProducts);
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