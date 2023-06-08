import React from "react";
import store from '../../redux/Store';
import { addSelectedProduct } from '../../components/Products/Actions';

class BasketProductItem extends React.Component {
  state = {
    product: this.props.product
  };

  handleProductSelect(product){
    store.dispatch(addSelectedProduct(product));
  }

  render() {
    const { product } = this.state

    return (
      <li>
        <h2>{product.name}</h2>
        <p>Precio: ${product.price}</p>
      </li>
    );
  }
}

export default BasketProductItem;