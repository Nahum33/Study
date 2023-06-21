import React, { Component } from 'react';
import './Banner.css';

export default class Banner extends Component {

  render() {
    return (
      <section className='banner'>
        <div className='bane-info'>
          <h1>Verdifrut</h1>
          <p>Podés pedir los productos verdifrut que ves a continuación, lo más fresco de verduras y frutas y otros productos hasta la puerta de tu casa.</p>
          <p>Ordená tu pedido, nosotros te lo llevamos gratis por una copra mínima de 5 mil colones</p>
        </div>
      </section>
    );
  }
}
