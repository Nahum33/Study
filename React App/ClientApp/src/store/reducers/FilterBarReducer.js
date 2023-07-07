const initialState = {};

export default function filterBarReducer(state = initialState, action) {
  const actionHandlers = {
    ON_SEARCH_TERM_VALUE_CHANGE: (state, action) => {
      const newState = {...state, searchTerm: action.payload };
    
      if (!action.payload) {
        delete newState.searchTerm;
      }
    
      return newState;
    },
    ON_CATEGORY_VALUE_CHANGE: (state, action) => {
      const newState = {...state, category: action.payload };
    
      if (!action.payload) {
        delete newState.category;
      }
    
      return newState;
    }
  };

  const handler = actionHandlers[action.type];
  return handler ? handler(state, action) : state;
}