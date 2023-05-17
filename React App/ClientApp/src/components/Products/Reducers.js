const initialState = {
  products: [],
  isFetchingResults: false,
  error: null
};

export default function rootReducer(state = initialState, action) {
  switch (action.type) {
    case 'FETCH_PRODUCTS_REQUEST':
      return { ...state, isFetchingResults: true };
    case 'FETCH_PRODUCTS_SUCCESS':
      return { ...state, products: action.payload, isFetchingResults: false, error: null };
    case 'FETCH_PRODUCTS_FAILURE':
      return { ...state, isFetchingResults: false, error: action.payload };
    default:
      return state;
  }
}