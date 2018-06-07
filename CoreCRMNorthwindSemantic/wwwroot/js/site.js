// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function (event) {
    document.getElementById('sidemenutoggle').addEventListener('click', (e) => {
        $('.ui.sidebar').toggleClass('visible'); /*.sidebar('toggle', { closable: false });*/
    });


    // cssmenumaker.com ** DO NOT USE IN PRODUCTION **
    $('#cssmenu > ul > li ul').each(function (index, e) {
        var count = $(e).find('li').length;
        var content = '<span class="cnt">' + count + '</span>';
        $(e).closest('li').children('a').append(content);
    });
    $('#cssmenu ul ul li:odd').addClass('odd');
    $('#cssmenu ul ul li:even').addClass('even');
    $('#cssmenu > ul > li > a').click(function () {
        $('#cssmenu li').removeClass('active');
        $(this).closest('li').addClass('active');
        var checkElement = $(this).next();
        checkElement.slideToggle('fast');
        checkElement.toggleClass('active');
        if ($(this).closest('li').find('ul').children().length == 0) {
            return true;
        } else {
            return false;
        }
    });
});
