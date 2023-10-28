import React from 'react';
import store from '../../store/Store';
import { addProductToOrder } from '../../store/actions/ProductSelectorActions';

const Product = ({ product }) => {
  const handleProductSelect = (product) => {
    store.dispatch(addProductToOrder(product));
  };

  return (
    <li>
      <h2>{product.name}</h2>
      <p>Precio: ${product.price}</p>
        <button onClick={() => handleProductSelect(product)}>+</button>
    </li>
  );
};

export default Product;