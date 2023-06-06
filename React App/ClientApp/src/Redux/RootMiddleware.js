import { applyMiddleware } from 'redux';
import { productsMiddleware } from '../Components/Products/Actions';

const composedMiddleware = applyMiddleware(productsMiddleware);

export default composedMiddleware;