import { applyMiddleware } from 'redux';
import { productsMiddleware } from './middlewares/productsMiddleware';

const composedMiddleware = applyMiddleware(productsMiddleware);

export default composedMiddleware;