import React, { Component } from 'react';
import './Banner.css';

export default class Banner extends Component {

  render() {
    return (
      <div className='banner'>
        <div className='bane-info'>
          <h1>The Food Truck Zuñiga</h1>
          <p>Ahora en puerto viejo con nuestros productos, la mejor comida rápida de Talamanca</p>
          <p>Podés ordernar aquí con solo hacer click</p>
        </div>
      </div>
    );
  }
}
