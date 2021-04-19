function PropsTesti(props) {

    const summa = 100 + 220;

    return <>
        <h1>Tämä on PropsTesti-komponentti. {summa}</h1>
        <p>Moi {props.nimi}!</p>
    </>;
}

export default PropsTesti;
