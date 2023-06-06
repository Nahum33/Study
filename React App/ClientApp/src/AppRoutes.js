import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from './Pages/Home/Home';

export default class AppRoutes extends Component {

  render() {
    return (
      <BrowserRouter>
        <Routes>
          <Route exact path="/" element={<Home />} />
        </Routes>
      </BrowserRouter>
    );
  }
}
