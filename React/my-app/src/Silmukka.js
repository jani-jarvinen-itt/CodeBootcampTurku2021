function Silmukka(props) {

    const rivit = [];
    for (let indeksi = 0; indeksi < props.maksimi; indeksi++) {
        rivit.push(<p>Luku: {indeksi + 1}</p>)
    }

    return <>
        <h1>Silmukka: {props.maksimi}</h1>
        {rivit}
    </>;
}

export default Silmukka;
