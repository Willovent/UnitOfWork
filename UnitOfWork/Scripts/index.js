$(function () {
    $('ul#users>li').click(function () {
        if (!$(this).find('ul.dogs').is(':visible'))
            $('ul.dogs').stop().slideUp();
        $(this).find('ul.dogs').stop().slideToggle();
    });
})