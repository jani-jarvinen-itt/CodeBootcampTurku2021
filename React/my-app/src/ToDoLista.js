import React from 'react';

class ToDoLista extends React.Component {

    constructor(props) {
        super(props);
        this.state = null;

        console.log("ToDoLista.constructor");
    }

    componentDidMount() {

        console.log("ToDoLista.componentDidMount");

        fetch('https://jsonplaceholder.typicode.com/todos/1')
            .then(response => response.json())
            .then(json => console.log(json));
    }

    render() {

        console.log("ToDoLista.render");

        return <h1>ToDoLista</h1>;
    }
}

export default ToDoLista;
