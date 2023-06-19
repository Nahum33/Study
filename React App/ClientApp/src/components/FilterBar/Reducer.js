const initialState = {
  searchTerm: ''
};

export default function filterBarReducer(state = initialState, action) {
  const actionHandlers = {
    ON_FILTER_BAR_CHANGE: (state, action) => ({
      ...state,
      searchTerm: action.payload
    })
  };

  const handler = actionHandlers[action.type];
  return handler ? handler(state, action) : state;
}