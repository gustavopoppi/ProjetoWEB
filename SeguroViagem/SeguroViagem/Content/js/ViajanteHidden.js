$(document).ready(function () {
    $("input[name='item.SegId']").click(function () {
        $("#dadosViajante").prop("hidden", false);
        $("#SeguradoraId").val(this.value)
    });
});