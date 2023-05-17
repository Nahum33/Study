export const fetchProductsRequest = () => {
  return { type: 'FETCH_PRODUCTS_REQUEST' };
};

export const fetchProductsSuccess = (products) => {
  return { type: 'FETCH_PRODUCTS_SUCCESS', payload: products };
};

export const fetchProductsFailure = (error) => {
  return { type: 'FETCH_PRODUCTS_FAILURE', payload: error };
};

export const fetchProducts = () => {
  return (dispatch) => {
    dispatch(fetchProductsRequest());
    fetch('/home/getinitialdata')
      .then((response) => response.json())
      .then((data) => dispatch(fetchProductsSuccess(data)))
      .catch((error) => dispatch(fetchProductsFailure(error.message)));
  };
};