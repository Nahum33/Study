export const fetchProductsRequest = (filters) => { 
  return { type: 'FETCH_PRODUCTS_REQUEST', payload: filters };
};
  
export const fetchProductsSuccess = (products)  => { 
  return { type: 'FETCH_PRODUCTS_SUCCESS', payload: products };
};

export const updateProducts = (products)  => { 
  return { type: 'UPDATE_PRODUCTS', payload: products };
};

export const fetchProductsFailure = (errorCode) => {
  return { type: 'FETCH_PRODUCTS_FAILURE', payload: errorCode };
};

export const addSelectedProduct = (product) => {
  return { type: 'ADD_SELECTED_PRODUCT', payload: product };
};
