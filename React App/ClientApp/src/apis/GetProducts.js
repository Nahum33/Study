/**
 * getProducts: function to fetching the products data.
 * @returns a products list or throw an error.
 */
async function getProducts(filters) {
  const queryParams = new URLSearchParams(filters).toString();
  const url = `/search/getresults?${queryParams}`;

  const promise = await fetch(url);
  if (!promise.ok) {
    throw new Error('Connection error');
  }

    const response = await promise.json();
    if(response.value && response.value.products){
      return response.value.products;
    }

    throw new Error(response.value.message);
  }

  export default getProducts;