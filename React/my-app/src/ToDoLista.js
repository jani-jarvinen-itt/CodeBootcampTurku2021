import React from 'react';

class ToDoLista extends React.Component {

    constructor(props) {
        super(props);
        this.state = { merkinnät: null };

        console.log("ToDoLista.constructor");
    }

    componentDidMount() {

        console.log("ToDoLista.componentDidMount");

        fetch('https://jsonplaceholder.typicode.com/todos/')
            .then(response => response.json())
            .then(json => {
                console.log("Ladattu " + json.length + " riviä.");

                // etsitään tuloksista vain tietyn käyttäjän todo-merkinnät
                const käyttäjäId = 2;
                let tulokset = [];
                for (let indeksi = 0; indeksi < json.length; indeksi++) {
                    const userId = json[indeksi].userId;
                    if (userId === käyttäjäId) {
                        tulokset.push(json[indeksi]);
                    }
                }
                console.log("Löydetty " + tulokset.length + " merkintää.");

                // päivitetään ruutu
                console.log("Aloitetaan setState-kutsu.");
                this.setState({ merkinnät: tulokset });
                console.log("SetState-kutsu tehty.");
            });
    }

    render() {

        console.log("ToDoLista.render");

        const otsikot = [];
        if (this.state.merkinnät) {

            const merkinnät = this.state.merkinnät;
            console.log("ToDoLista.render --> tila alustettu: " + merkinnät.length);

            for (let indeksi = 0; indeksi < merkinnät.length; indeksi++) {
                const otsikko = merkinnät[indeksi].title;
                otsikot.push(<p key={indeksi}>Tehtävä: {otsikko}</p>)
            }
        }

        return <>
            <h1>ToDoLista</h1>
            {otsikot}
        </>;
    }
}

export default ToDoLista;
