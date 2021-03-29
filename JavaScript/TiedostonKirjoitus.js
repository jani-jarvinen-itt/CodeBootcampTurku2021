// import * as fs from 'fs';
const fs = require('fs');

let data = "Moi Bootcamp!";
fs.writeFileSync("Testi.txt", data);
