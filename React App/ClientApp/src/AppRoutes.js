import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom";

import Home from './components/Home/Home';
import Counter from './components/Counter/Counter';
import FetchData from './components/FetchData/FetchData';

export default class AppRoutes extends Component {

  render() {
    return (
      <BrowserRouter>
        <Routes>
          <Route exact path="/" element={<Home />} />
          <Route path="/counter" element={<Counter />} />
          <Route path="/about" element={<FetchData />} />
        </Routes>
      </BrowserRouter>
    );
  }
}
