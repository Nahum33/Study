export const onSearchTermValueChange = (searchTerm) => { 
  return { type: 'ON_SEARCH_TERM_VALUE_CHANGE', payload: searchTerm };
};

export const onCategoryValueChange = (searchTerm) => { 
  return { type: 'ON_CATEGORY_VALUE_CHANGE', payload: searchTerm };
};