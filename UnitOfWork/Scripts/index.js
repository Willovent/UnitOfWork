$(function () {
    $('ul#users>li').click(function () {
        if (!$(this).find('ul.dogs').is(':visible'))
            $('ul.dogs').slideUp();
        $(this).find('ul.dogs').slideToggle();
    });
})