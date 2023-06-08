import React, { Component } from "react";
import store from '../../redux/Store';
import Products from '../../components/Products/Products';
import FilterBar from '../../components/FilterBar/FilterBar';
import getSortedObjectsListByPropertyAndSearchTerm from '../../components/Utils/ListSorterHelper';
import { getDifferenceListFromTwoLists, getListWithUpdatedPropertyByIdList } from '../../components/Utils/ListFilterHelper';
import { fetchProductsRequest, updateProducts } from '../../components/Products/Actions';

export default class ProductSelector extends Component {
  state = {
    searchTerm: store.getState().filterBarReducer.searchTerm,
    chosenProducts: store.getState().productsReducer.chosenProducts,
  };

  handleSearchTermChange(){
    const searchTermFromStore = store.getState().filterBarReducer.searchTerm;
    const { searchTerm } = this.state

    if(searchTerm === searchTermFromStore){
      return;
    }

    const productsFromStore = store.getState().productsReducer.products;
    const sortedProductsList = getSortedObjectsListByPropertyAndSearchTerm({
      searchTerm: searchTermFromStore,
      objectList: productsFromStore,
      propertyName: "name"
    });

    if(sortedProductsList !== productsFromStore){
      this.setState({ searchTerm: searchTermFromStore });
      store.dispatch(updateProducts(sortedProductsList));
    }
  }

  handleChosenProductsChange(){
    const { chosenProducts } = this.state
    const chosenProductsFromStore = store.getState().productsReducer.chosenProducts;

    if(chosenProducts === chosenProductsFromStore){
      return;
    }

    const productsIdListToUpdate  = getDifferenceListFromTwoLists({
      listA: chosenProducts,
      listB: chosenProductsFromStore,
    }).map(obj => obj.id);

    const ProductsFromStore = store.getState().productsReducer.products;
    const newProductsList = getListWithUpdatedPropertyByIdList({
      objectList: ProductsFromStore,
      propertyName: "isSelected",
      value: false,
      filterIdList: productsIdListToUpdate
    });

    this.setState({ chosenProducts: chosenProductsFromStore });
    store.dispatch(updateProducts(newProductsList));
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