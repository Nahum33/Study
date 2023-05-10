import React, { Component } from 'react';

export default class Home extends Component {

  render() {
    return (
      <article>
        <h2>Nahum Blanco Rojas</h2>
        <p>Welcome to my personal website, here you can see some applications that are using a few design patterns and architectural designs.</p>

        <hr />

        <p>Here you can see a a list of application and a simple description.</p>

        <ul>
          <li><a href='/'>Example 1</a></li>
          <li><a href='/'>Example 2</a></li>
          <li><a href='/'>Example 3</a></li>
        </ul>

      </article>
    );
  }
}
