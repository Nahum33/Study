import React from 'react';
import { createRoot } from 'react-dom/client';
import { createStore, combineReducers } from 'redux';
import { Provider } from 'react-redux';

import Header from './components/Header/Header';
import AppRoutes from './AppRoutes';
import Footer from './components/Footer/Footer';

import productsReducer from './components/Products/Reducers';

const rootReducer = combineReducers({
  products: productsReducer
});
const store = createStore(rootReducer);

/*console.log(store.getState());
store.subscribe(() => console.log('store', store.getState()))
store.dispatch({ type: 'FETCH_PRODUCTS_REQUEST' });*/

const appRoutesComponent = createRoot(document.querySelector('[data-app-component]'));
const headerComponent = createRoot(document.querySelector('[data-header-component]'));
const footerComponent = createRoot(document.querySelector('[data-footer-component]'));

headerComponent.render(<Header />);
appRoutesComponent.render(<Provider store={store}><AppRoutes /></Provider>);
footerComponent.render(<Footer />);

