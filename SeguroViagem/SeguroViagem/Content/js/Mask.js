$(document).ready(function () {
    $("#telefone").inputmask("mask", { "mask": "(99) 9999-99999" });
    $("#cpf").inputmask("mask", { "mask": "999.999.999-99" }, { reverse: true });
    $("#cep").inputmask("mask", { "mask": "99999-999" });
    $("#nascimento").inputmask("mask", { "mask": "99/99/9999" });
});