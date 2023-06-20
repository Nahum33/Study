/**
 * getListWithUpdatedPropertyByIdList: update a specific value from object that are contained on an idList
 * @param {*} settings 
 * @returns list of object
 */
export const getListWithUpdatedPropertyByIdList = (settings)  => { 
  const objectList = settings.objectList;
  const propertyName = settings.propertyName;
  const value = settings.value;
  const filterIdList = settings.filterIdList;

  const updatedList = objectList.map((object) => {
    if (filterIdList.some((id) => id === object.id)) {
      return {
        ...object,
        [propertyName]: value,
      };
    }
    return object;
  });

  return updatedList;
};
