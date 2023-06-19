import React from 'react';
import store from '../../redux/Store';
import { addSelectedProduct } from '../../components/Products/Actions';

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