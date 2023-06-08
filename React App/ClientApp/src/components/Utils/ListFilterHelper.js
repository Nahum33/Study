/**
 * 
 * @param {Object} settings
 * @returns 
 */
export const  getDifferenceListFromTwoLists = (settings) => {
  const listA = settings.listA;
  const listB = settings.listB;
  const difference = [...listA.filter(itemA => !listB.some(itemB => itemA.id === itemB.id)), ...listB.filter(itemB => !listA.some(itemA => itemB.id === itemA.id))];
  return difference;
};

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
