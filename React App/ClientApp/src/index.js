import React from 'react';
import { createRoot } from 'react-dom/client';

import AppRoutes from './AppRoutes';
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';

const appRoutes = createRoot(document.querySelector('[data-app-component]'));
const header = createRoot(document.querySelector('[data-header-component]'));
const footer = createRoot(document.querySelector('[data-footer-component]'));

header.render(<Header />);
appRoutes.render(<AppRoutes />);
footer.render(<Footer />);
