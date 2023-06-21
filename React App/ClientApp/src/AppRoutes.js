import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import { createBrowserHistory } from 'history';
import Home from './components/Sections/Home/Home';
import AboutUs from './components/Sections/AboutUs/AboutUs';
import Contactos from './components/Sections/Contactos/Contactos';
import Header from './components/Sections/Header/Header';
import Footer from './components/Sections/Footer/Footer';
const history = createBrowserHistory();

export default class AppRoutes extends Component {
  render() {
    return (
      <BrowserRouter history={history}>
        <Header />
        <Routes>
          <Route exact path='/' element={<Home />} />
          <Route exact path='/about-us' element={<AboutUs />} />
          <Route exact path='/contactos' element={<Contactos />} />
        </Routes>
        <Footer />
    </BrowserRouter>
    );
  }
}