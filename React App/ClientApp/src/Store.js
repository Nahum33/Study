import { createStore } from 'redux';
import rootReducer from './RootReducer';
import composedMiddleware from './RootMiddleware';

const store = createStore(rootReducer, composedMiddleware);
export default store;