import React, { Component } from 'react';
import ProductSelector from '../../ProductSelector/ProductSelector';
import Banner from '../Banner/Banner';
import './Home.css';

export default class Home extends Component {

  render() {
    return (
      <>
        <Banner/>
        <ProductSelector/>
      </>
    );
  }
}
