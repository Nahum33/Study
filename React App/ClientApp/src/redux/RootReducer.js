import { combineReducers } from 'redux';
import productsReducer from './reducers/ProductsReducer';
import filterBarReducer from './reducers/FilterBarReducer';

const rootReducer = combineReducers({
  productsReducer: productsReducer,
  filterBarReducer: filterBarReducer
});

export default rootReducer;

