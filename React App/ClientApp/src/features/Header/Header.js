import React, { Component } from 'react';
import './Header.css';

export default class Header extends Component {
  constructor(props) {
    super(props);
    this.state = {
      menuOpen: false,
    };
  }

  toggleMenu = () => {
    this.setState((prevState) => ({
      menuOpen: !prevState.menuOpen,
    }));
  }

  render() {
    const { menuOpen } = this.state;

    return (
      
      <nav className={menuOpen ? 'topnav responsive' : 'topnav'} id="myTopnav">
        <a className='active' href="/">Home</a>
        <a href="/about-us">Acerca de Nosotros</a>
        <button className="icon" onClick={this.toggleMenu}>
          <i class="fa fa-bars"></i>
        </button>
      </nav>
    );
  }
}