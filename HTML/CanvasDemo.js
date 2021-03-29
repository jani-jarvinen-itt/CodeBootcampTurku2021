console.log("Moi maailma!");

// suorakaide
var c = document.getElementById("omaCanvas");
var ctx = c.getContext("2d");
ctx.fillStyle = "#DBE83E";
ctx.fillRect(20, 20, 100, 80);

// ympyrä
ctx.beginPath();
ctx.arc(200, 75, 50, 0, 2 * Math.PI);
ctx.stroke();
