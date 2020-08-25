
$.ajax({
    type: "POST",
    url: "Consultas/Datos",
    success: function (resultado) {
        console.log(resultado);
        var plantilla = '';

        resultado.forEach(valor => {

            plantilla += ` 
                <tr>
                    <td>${valor.DescripcionCasa}</td>
                    <td>${valor.PrecioCasa}</td>
                    <td>${valor.Vendedor}</td>
                    <td>${valor.FechaVenta}</td>
                </tr>
                `
        });

        $("#cuerpo-tabla").html(plantilla);

    },
    error: function (xhr) {

        console.log(xhr.responseText);
        alert("Error has occurred..");
    }
});

/*$(document).ready(function () {
    $("#consultar").click(function () {
        buscar();
    });
});*/

function Buscar() {

    var vendedor = $("#vendedor").val();

    $.ajax({
        type: "POST",
        data: { seller: vendedor },
        url: "Consultas/Buscar",
        success: function (resultado) {
            console.log(resultado);
            var plantilla = '';

            resultado.forEach(valor => {

                plantilla += ` 
                <tr>
                    <td>${valor.DescripcionCasa}</td>
                    <td>${valor.PrecioCasa}</td>
                    <td>${valor.Vendedor}</td>
                    <td>${valor.FechaVenta}</td>
                </tr>
                `
            });

            $("#cuerpo-tabla").html(plantilla);

        },
        error: function (xhr) {

            console.log(xhr.responseText);
            alert("Error has occurred..");
        }
    });

}

