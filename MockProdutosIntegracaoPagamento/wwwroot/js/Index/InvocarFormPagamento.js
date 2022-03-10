
$(document).ready(function () {

    CarregarViewComprador = function () {

        $.ajax({
            url: "/Home/CarregarFormularioCompra",
            type: 'GET',
            dataType: 'HTML',
            success: function (result) {
                setTimeout(function () {
                    $('#modal-comprar').html(result);
                },
                    0);
            },
            error: function (error) {
            }
        });

    };

    CarregarViewCompradorCartaoDeCredito = function () {

        $.ajax({
            url: "/Home/CarregarFormularioCompraCartaoDeCredito",
            type: 'GET',
            dataType: 'HTML',
            success: function (result) {

                setTimeout(function () {
                    $('#modal-comprar').html(result);
                },
                    0);
            },
            error: function (error) {
            }
        });

    };
});