$(document).ready(function () {
    //$("#telefone").mask("mask", { "mask": "(99) 9999-99999" });

    $("#cpf").mask("000.000.000-00");

    $("cep").mask("00000-000");

    //$("#nascimento").inputmask("mask", { "mask": "99/99/9999" });

//    var SPMaskBehavior = function (val) {
//        return val.replace(/\D/g, '').length === 11 ? '(00) 00000 - 0000' : '(00) 0000-00009';
//    },
//        spOptions = {
//            onKeyPress: function (val, e, field, options) {
//                field.mask(SPMaskBehavior.apply({}, arguments), options);
//            }
//        };
//    $('#telefone').mask(SPMaskBehavior, spOptions);
//});