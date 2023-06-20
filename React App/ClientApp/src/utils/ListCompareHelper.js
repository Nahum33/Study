/**
 * isEqualLists: compare two list if are equal from values
 * @param {*} settings 
 * @returns boolean value
 */
export const isEqualLists = (settings)  => { 
  const listA = settings.listA;
  const listB = settings.listB;
  return JSON.stringify(listA) === JSON.stringify(listB);
};
