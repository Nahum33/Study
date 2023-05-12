import React from "react";


const Product = ({ product }) => {
  return (
    <li>
      <h2>{product.name}</h2>
      <p>Precio: ${product.price}</p>
    </li>
  );
};

export default Product;