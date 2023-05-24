const initialState = {
  products: [],
  isFetchingResults: false,
  error: null
};

export default function rootReducer(state = initialState, action) {
  switch (action.type) {
    case 'FETCH_PRODUCTS_REQUEST':
      return {
        ...state,
        isFetchingResults: true,
        products: [
          { id: 1, name: "Producto 1", price: 10 },
          { id: 2, name: "Producto 2", price: 20 },
          { id: 3, name: "Producto 3", price: 30 }
        ]
      };
    case 'FETCH_PRODUCTS_SUCCESS':
      return { ...state, products: action.payload, isFetchingResults: false, error: null };
    case 'FETCH_PRODUCTS_FAILURE':
      return { ...state, isFetchingResults: false, error: action.payload };
    default:
      return state;
  }
}