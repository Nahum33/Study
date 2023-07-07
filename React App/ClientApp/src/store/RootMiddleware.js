import { applyMiddleware } from 'redux';
import { productSelectorMiddleware } from './middlewares/productSelectorMiddleware';

const composedMiddleware = applyMiddleware(productSelectorMiddleware);

export default composedMiddleware;