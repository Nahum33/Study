import React from 'react';
import { createRoot } from 'react-dom/client';
import AppRoutes from './AppRoutes';

const appRoutesComponent = createRoot(document.querySelector('[data-app-component]'));
appRoutesComponent.render(<AppRoutes />);

