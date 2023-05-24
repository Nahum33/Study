import React from 'react';
import { createRoot } from 'react-dom/client';
import Header from './components/Header/Header';
import AppRoutes from './AppRoutes';
import Footer from './components/Footer/Footer';


const headerComponent = createRoot(document.querySelector('[data-header-component]'));
const appRoutesComponent = createRoot(document.querySelector('[data-app-component]'));
const footerComponent = createRoot(document.querySelector('[data-footer-component]'));

headerComponent.render(<Header />);
appRoutesComponent.render(<AppRoutes />);
footerComponent.render(<Footer />);

