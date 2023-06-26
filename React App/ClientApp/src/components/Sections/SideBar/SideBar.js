import React, { Component } from 'react';
import './SideBar.css';

export default class SideBar extends Component {

  componentDidMount() {
  }

  componentWillUnmount() {
  }

  render() {
    return (
      <aside>
        <ul>
          <li>
            <div>
              DATO 1
            </div>
          </li>
          <li>
            <div>
              DATO 2
            </div>
          </li>
          <li>
            <div>
              DATO 3
            </div>
          </li>
          <li>
            <div>
              DATO 4
            </div>
          </li>
        </ul>
      </aside>
    );
  }
};