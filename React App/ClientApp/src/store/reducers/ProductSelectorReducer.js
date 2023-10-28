const initialState = {
  products: [],
  order: [],
  filters: {},
  isFetchingResults: false,
  errorCode: null
};

export default function productsReducer(state = initialState, action) {
  const actionHandlers = {
    FETCH_PRODUCTS_REQUEST: (state) => ({
      ...state,
      isFetchingResults: true,
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
    UPDATE_PRODUCT_NAME_FILTER: (state, action) => {
      const newState = {...state, filters: { ...state.filters, productName: action.payload }};
    
      if (!action.payload) {
        delete newState.filters.productName;
      }
    
      return newState;
    },
    UPDATE_CATEGORY_FILTER: (state, action) => {
      const newState = {...state, filters: { ...state.filters, productCategory: action.payload }};
    
      if (!action.payload) {
        delete newState.filters.productCategory;
      }
    
      return newState;
    },
    ADD_PRODUCT_TO_ORDER: (state, action) => ({
      ...state,
      order: [...state.order, action.payload],
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