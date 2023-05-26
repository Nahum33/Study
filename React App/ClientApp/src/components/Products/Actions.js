import getProducts from '../../components/Apis/GetProducts';
import ERROR_CODES  from '../../components/Apis/ErrorCodes';

export const fetchProductsRequest = () => { 
  return { type: 'FETCH_PRODUCTS_REQUEST', payload: "Me cago en todo" };
};
  
export const fetchProductsSuccess = (products)  => { 
  return { type: 'FETCH_PRODUCTS_SUCCESS', payload: products };
};

export const fetchProductsFailure = (error) => {
  const errorCode = ERROR_CODES[error];
  return { type: 'FETCH_PRODUCTS_FAILURE', payload: errorCode };
};

/**
 * productsMiddleware: function to separate the side effects for products fetching
 * @param {*} store global store
 * @returns an action.
 */
export function productsMiddleware(store) {
  return function wrapDispatch(next) {
    return async function handleAction(action) {
      const { dispatch } = store;
      if (action.type === 'FETCH_PRODUCTS_REQUEST') {
        try {
          const products = await getProducts();
          dispatch(fetchProductsSuccess(products));
        } catch (error) {
          dispatch(fetchProductsFailure(error.message));
        }
      }

      return next(action);
    }
  }
}