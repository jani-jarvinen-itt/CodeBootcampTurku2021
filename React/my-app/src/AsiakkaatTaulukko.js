import React from 'react';

class AsiakkaatTaulukko extends React.Component {

    constructor(props) {
        super(props);
        this.state = { asiakkaat: null };

        console.log("AsiakkaatTaulukko.constructor");
    }

    componentDidMount() {

        console.log("AsiakkaatTaulukko.componentDidMount");

        fetch("https://localhost:44317/api/asiakkaat/kaikki")
            .then(response => response.json())
            .then(json => {
                console.log("Ladattu " + json.length + " asiakasta.");

                // päivitetään ruutu
                console.log("Aloitetaan setState-kutsu.");
                this.setState({ asiakkaat: json });
                console.log("SetState-kutsu tehty.");
            });
    }

    render() {

        console.log("AsiakkaatTaulukko.render");

        const taulukko = [];
        if (this.state.asiakkaat) {

            const asiakkaat = this.state.asiakkaat;
            console.log("AsiakkaatTaulukko.render --> tila alustettu: " + asiakkaat.length);

            for (let indeksi = 0; indeksi < asiakkaat.length; indeksi++) {
                const asiakas = asiakkaat[indeksi];
                taulukko.push(<tr key={indeksi}>
                    <td>{asiakas.customerId}</td>
                    <td>{asiakas.companyName}</td>
                    <td>{asiakas.contactName}</td>
                    <td>{asiakas.country}</td>
                </tr>)
            }
        }

        return <>
            <h1>AsiakkaatTaulukko</h1>
            <table>
                <thead>
                    <tr>
                        <th>Asiakas-id</th>
                        <th>Nimi</th>
                        <th>Kontakti</th>
                        <th>Maa</th>
                    </tr>
                </thead>
                <tbody>
                    {taulukko}
                </tbody>
            </table>
        </>;
    }
}

export default AsiakkaatTaulukko;
