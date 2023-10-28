import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './Header.css';

export default class Header extends Component {
  constructor(props) {
    super(props);
    this.state = {
      isNavOpen: false,
      activeLink: new URL(window.location.href).pathname
    };
  }

  toggleMenu = () => {
    this.setState((prevState) => ({
      isNavOpen: !prevState.isNavOpen,
    }));
  }

  handleLinkClick = (event) => {
    const targetLink = event.currentTarget;
    const url = new URL(targetLink.href);
    this.setState({
      activeLink: url.pathname,
    });
  }

  render() {
    const { isNavOpen, activeLink } = this.state;

    return (
      <header className='header'>
        <nav className={isNavOpen ? 'header-nav responsive' : 'header-nav'}>
          <ul className='nav-list'>
            <li className={activeLink === '/' ? 'active' : ''}>
              <Link onClick={this.handleLinkClick} to='/'>LOGO</Link>
            </li>
            <li className={activeLink === '/contactos' ? 'active' : ''}>
              <Link onClick={this.handleLinkClick} to='/contactos'>Contactos</Link>
            </li>
            <li className={activeLink === '/about-us' ? 'active' : ''}>
              <Link onClick={this.handleLinkClick} to='/about-us'>Acerca de nosotros</Link>
            </li>
          </ul>
        </nav>
        <button className='header-hamburger-button' onClick={this.toggleMenu}>
          <i className='fa fa-bars'></i>
        </button>
      </header>
    );
  }
}
