/**
 * sortObjectsByPropertyAndSearchTerm: function to sort a list of objects
 * based on a property name and a search term value.
 * @param {Object} settings 
 * @returns a sorted list of objects.
 */
function sortObjectsByPropertyAndSearchTerm(settings) {
  const searchTerm = settings.searchTerm;
  const objectList = settings.objectList;
  const propertyName = settings.propertyName;

  objectList.sort((object1, object2) => {
    const propertyValueObject1 = object1[propertyName].toLowerCase();
    const propertyValueObject2 = object2[propertyName].toLowerCase();
    const searchTermLowerCase = searchTerm.toLowerCase();
    
    const doesStartWithObject1 = propertyValueObject1.startsWith(searchTermLowerCase);
    const doesStartWithObject2 = propertyValueObject2.startsWith(searchTermLowerCase);
    
    if (doesStartWithObject1 && !doesStartWithObject2) {
      return -1;
    } else if (!doesStartWithObject1 && doesStartWithObject2) {
      return 1;
    } else {
      return propertyValueObject1.localeCompare(propertyValueObject2);
    }
  });
  
  return objectList;
}

export default sortObjectsByPropertyAndSearchTerm;