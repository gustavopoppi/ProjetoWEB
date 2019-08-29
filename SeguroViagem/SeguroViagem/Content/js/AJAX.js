$("#btnPagamento").on("click", function () {
    $.ajax({
        method: "POST",
        url: "Prosseguir",
        async: false,
        data: $('#formViajante').serialize()
    })
        .done(function (data) {
            if (data.formValido != undefined && data.formValido) {
                $("#ViajanteId").val(data.viajanteId)
                $('#modalPagamento').modal("show")
            }
            else {
                $("#dadosViajante").html(data);
            }
        });
});

$("#btnPagar").on("click", function () {
    var radioChecked = $("input[name='SegId']:checked")
    $("#SeguradoraId").val(radioChecked.val()) // Alterando o valor da SeguradoraId, pegando pelo value do radio button selecionado
    var tr = radioChecked.closest('tr')
    var cotacaoId = tr.find("input[name='item.CotdId']").val()
    $("#CotId").val(cotacaoId)
    $.ajax({
        method: "POST",
        url: "../Pagamento/Index",
        datatype: "json",
        data: $("#formPagamento").serialize()
    })
        .done(function (data) {
            if (data.formValido != undefined && data.formValido) {
                $('#formPagamento').submit() 
            }
            else {
                $("#modalBody").html(data);
            }
        });
});   