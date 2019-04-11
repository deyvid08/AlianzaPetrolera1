$(document).ready(function (){
    $("#number").on({
        "focus": function (event) {
            $(event.target).select();
        },
        "keyup": function (event) {
            $(event.target).val(function (index, value) {
                return value.replace(/\D/g, "")
                    .replace(/([0-9])([0-9]{2})$/, '$1.$2')
                    .replace(/\B(?=(\d{3})+(?!\d)\.?)/g, ",");
            });
        }
    });

    $("#calc").click(function () {
        $(this).fadeOut(3000);
        $("#calc").fadeIn(2000);
    });
})
$(window).ready(function () {
    $('h4').click(function () {
        if ($(this).next().hasClass('desplegado')) {
            $(this).next().removeClass('desplegado');
        } else {
            $(this).next().addClass('desplegado');
        }
    })
})