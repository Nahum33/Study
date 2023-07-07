import { combineReducers } from 'redux';
import productSelectorReducer from './reducers/ProductSelectorReducer';
import filterBarReducer from './reducers/FilterBarReducer';

const rootReducer = combineReducers({
  productSelectorReducer: productSelectorReducer,
  filterBarReducer: filterBarReducer
});

export default rootReducer;

