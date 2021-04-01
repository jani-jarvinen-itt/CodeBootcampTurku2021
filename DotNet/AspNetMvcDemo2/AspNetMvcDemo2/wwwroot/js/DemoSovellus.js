console.log("Skriptin suoritus alkaa.");
$("#laskeNappi").click(function () {

    console.log("Nappia klikattu.");

    const luku1 = $("#luku1").val();
    const luku2 = $("#luku2").val();

    const summa = parseInt(luku1) + parseInt(luku2);
    alert("Summa on: " + summa);
});
