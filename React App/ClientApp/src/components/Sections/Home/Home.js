import React, { Component } from 'react';
import ProductSelector from '../../ProductSelector/ProductSelector';
import Banner from '../Banner/Banner';
import SideBar from '../SideBar/SideBar';
import FilterBar from '../../FilterBar/FilterBar';
import './Home.css';

export default class Home extends Component {

  render() {
    return (
      <section className='home-page'>
        <section className='home-page-banner'>
          <Banner/>
        </section>
        <section className='home-page-main-section'>
          <header className='home-page-main-section-header'>
            <FilterBar />
          </header>
          <div className='home-page-main-section-product-selector'>
            <ProductSelector/>
          </div>
        </section>
        <aside className='home-page-main-section-side-bar'>
          <SideBar/>
        </aside>
      </section>
    );
  }
}
