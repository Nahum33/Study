const initialState = {
  searchTerm: '',
  category: ''
};

export default function filterBarReducer(state = initialState, action) {
  const actionHandlers = {
    ON_SEARCH_TERM_VALUE_CHANGE: (state, action) => ({
      ...state,
      searchTerm: action.payload
    }),
    ON_CATEGORY_VALUE_CHANGE: (state, action) => ({
      ...state,
      category: action.payload
    })
  };

  const handler = actionHandlers[action.type];
  return handler ? handler(state, action) : state;
}