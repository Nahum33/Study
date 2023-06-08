import { applyMiddleware } from 'redux';
import { productsMiddleware } from '../components/Products/Actions';

const composedMiddleware = applyMiddleware(productsMiddleware);

export default composedMiddleware;