import { combineReducers } from 'redux';
import productsReducer from './components/Products/Reducer';

const rootReducer = combineReducers({
  productsReducer: productsReducer
});

export default rootReducer;

