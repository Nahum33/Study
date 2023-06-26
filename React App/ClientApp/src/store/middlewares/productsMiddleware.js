import { fetchProductsSuccess, fetchProductsFailure } from '../actions/ProductsActions';
import getProducts from '../../apis/GetProducts';
import ERROR_CODES  from '../../apis/ErrorCodes';

/**
 * productsMiddleware: function to separate the side effects for products fetching
 * @param {object} store global store
 * @returns an action.
 */
export function productsMiddleware(store) {
    return function wrapDispatch(next) {
      return async function handleAction(action) {
        const { dispatch } = store;
        if (action.type === 'FETCH_PRODUCTS_REQUEST') {
          try {
            const products = await getProducts(action.payload);
            dispatch(fetchProductsSuccess(products));
          } catch (error) {
            const errorCode = ERROR_CODES[error.message];
            dispatch(fetchProductsFailure(errorCode));
          }
        }
  
        return next(action);
      }
    }
  }