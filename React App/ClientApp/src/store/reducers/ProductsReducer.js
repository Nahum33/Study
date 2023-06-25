const initialState = {
  products: [],
  selectedProducts: [],
  isFetchingResults: false,
  errorCode: null
};

export default function productsReducer(state = initialState, action) {
  const actionHandlers = {
    FETCH_PRODUCTS_REQUEST: (state) => ({
      ...state,
      isFetchingResults: true
    }),
    FETCH_PRODUCTS_SUCCESS: (state, action) => ({
      ...state,
      products: action.payload,
      isFetchingResults: false,
      errorCode: null
    }),
    UPDATE_PRODUCTS: (state, action) => ({
      ...state,
      products: action.payload
    }),
    ADD_SELECTED_PRODUCT: (state, action) => ({
      ...state,
      selectedProducts: [...state.selectedProducts, action.payload],
    }),
    FETCH_PRODUCTS_FAILURE: (state, action) => ({
      ...state,
      isFetchingResults: false,
      errorCode: action.payload
    })
  };

  const handler = actionHandlers[action.type];
  return handler ? handler(state, action) : state;
}