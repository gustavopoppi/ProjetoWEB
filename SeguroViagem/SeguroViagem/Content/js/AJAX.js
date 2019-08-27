$("#btnPagamento").on("click", function () {
    $.ajax({
        method: "POST",
        url: "Prosseguir",
        async: false,
        data: $('#formViajante').serialize()
    })
        .done(function (data) {
            if (data.formValido != undefined && data.formValido) {
                $('#modalPagamento').modal("show")
            }
            else {
                $("#dadosViajante").html(data);
            }
        });
});

$("#btnPagar").on("click", function () {
    $.ajax({
        method: "POST",
        url: "../Pagamento/Index",
        datatype: "json",
        data: JSON.stringify($("#formViajante").serialize())
    })
        .done(function (data) {
            if (data.formValido != undefined && data.formValido) {
                $('#modalPagamento').modal("show")
            }
            else {
                $("#modalPagamento").html(data);
            }
        });
});   