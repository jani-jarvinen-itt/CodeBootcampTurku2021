import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';
import AsiakkaatTaulukko from './AsiakkaatTaulukko';
// import App from './App';
// import ToDoLista from './ToDoLista';
// import PieniKomponentti from './PieniKomponentti';
// import LuokkaKomponentti from './LuokkaKomponentti';
// import PropsTesti from './PropsTesti';
// import Silmukka from './Silmukka';

ReactDOM.render(
  <React.StrictMode>
    <AsiakkaatTaulukko />

    {/*
    <App />
    <ToDoLista />
    <Silmukka maksimi={20} />
    <PropsTesti nimi="Teppo" />
    <PropsTesti nimi="Kalle" />
    <PropsTesti nimi="Maija" />
    <PieniKomponentti />
    <LuokkaKomponentti />
    */}
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
