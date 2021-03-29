// otetaan käyttöön FS-mooduli
console.log("Suoritus alkaa.");
const fs = require("fs");

// luetaan tiedoston sisältö
const data = fs.readFileSync("Numerot.txt");
console.log("Tiedoston sisältö luettu.");

let summa = 0;

// käsitellään rivit ja laskentaan summa
const teksti = data.toString().split("\r\n");
for (rivi in teksti) {
    if (teksti[rivi] != "") {
        const luku = parseInt(teksti[rivi]);
        summa = summa + luku; // summa += luku;
    }
}

// tulostus
console.log("Tiedostossa olevien lukujen summa on: " + summa);
console.log("Suoritus päättyy.");
