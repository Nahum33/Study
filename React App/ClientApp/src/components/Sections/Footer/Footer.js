import React, { Component } from 'react';
import './Footer.css';

export default class Footer extends Component {
  render() {
    return (
    <footer className='footer'>
      <p className='copyright-text'>© 2023 Verdifrut. Todos los derechos reservados.</p>
      <ui className='social-media-list'>
        <li>
          <a href="https://www.facebook.com/ejemplo"><i class="fa fa-facebook-square fa-3x"></i></a>
        </li>
        <li>
          <a href="https://twitter.com/ejemplo"><i class="fa fa-twitter-square fa-3x"></i></a>
        </li>
        <li>
          <a href="https://www.instagram.com/ejemplo"><i class="fa fa-instagram fa-3x"></i></a>
        </li>
      </ui>
    </footer>
    );
  }
}
