$(function() {
    $('ul#users>li').click(function() {
        $(this).find('ul#dogs').toggle();
    });
})