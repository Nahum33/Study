import React from 'react';
import { createRoot } from 'react-dom/client';
import Header from './features/Header/Header';
import AppRoutes from './AppRoutes';
import Footer from './features/Footer/Footer';


const headerComponent = createRoot(document.querySelector('[data-header-component]'));
const appRoutesComponent = createRoot(document.querySelector('[data-app-component]'));
const footerComponent = createRoot(document.querySelector('[data-footer-component]'));

headerComponent.render(<Header />);
appRoutesComponent.render(<AppRoutes />);
footerComponent.render(<Footer />);

