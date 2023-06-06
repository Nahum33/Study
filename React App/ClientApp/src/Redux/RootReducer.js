import { combineReducers } from 'redux';
import productsReducer from '../Components/Products/Reducer';
import filterBarReducer from '../Components/FilterBar/Reducer';

const rootReducer = combineReducers({
  productsReducer: productsReducer,
  filterBarReducer: filterBarReducer
});

export default rootReducer;

