import React from 'react';
import store from '../../store/Store';
import { addSelectedProduct } from '../../store/actions/ProductsActions';

const Product = ({ product }) => {
  const handleProductSelect = (product) => {
    store.dispatch(addSelectedProduct(product));
  };

  return (
    <li>
      <h2>{product.name}</h2>
      <p>Precio: ${product.price}</p>
      {!product.isSelected && (
        <button onClick={() => handleProductSelect(product)}>Agregar a la canasta</button>
      )}
    </li>
  );
};

export default Product;