$(document).ready(function () {
    $("input[name='SegId']").click(function () {
        $("#dadosViajante").prop("hidden", false);
        $("#SeguradoraId").val(this.value)
        var tr = $("input[name='SegId']:checked").closest('tr')
        var cotacaoId = tr.find("input[name='item.CotdId']").val()
        $("#CotId").val(cotacaoId)
    });
});