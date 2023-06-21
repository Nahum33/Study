import React from 'react';
import store from '../../redux/Store';
import { addSelectedProduct } from '../../redux/actions/ProductsActions';

class SelectedProduct extends React.Component {
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

export default SelectedProduct;