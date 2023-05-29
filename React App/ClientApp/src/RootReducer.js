import { combineReducers } from 'redux';
import productsReducer from './components/Products/Reducer';
import filterBarReducer from './components/FilterBar/Reducer';

const rootReducer = combineReducers({
  productsReducer: productsReducer,
  filterBarReducer: filterBarReducer
});

export default rootReducer;

