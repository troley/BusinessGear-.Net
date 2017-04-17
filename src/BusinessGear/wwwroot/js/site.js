
$(document).ready(function () {

    var bigImg = $('.big-img');
    var appendable = [
        bigImg.find('.img-panel p.first'),
        bigImg.find('.img-panel p.second'),
        bigImg.find('.img-panel p.third'),
        bigImg.find('.img-panel p.fourth')
    ];

    // detach every panel text except [0]
    for (var i = 1; i < appendable.length; i++) {
        appendable[i].detach();
    }

    var activeItem = makeActive('#first');
    var oldActiveItem = '#first';

    $('#howItWorks').find('li').find('span').click(function () {
        undoActive(activeItem);
        activeItem = makeActive('#' + $(this).closest('li').prop('id'));
        if (activeItem != oldActiveItem) {
            howItWorksItems(activeItem, appendable);
        }
        oldActiveItem = activeItem;
    });
});

function howItWorksItems(litem, appendable) {
    var src = $('.big-img').find('img');
    var textPanel = $('.appointment-steps .img-panel');
    appendable.forEach(function (item) { item.detach(); });

    switch (litem) {
        case '#first':
            src.fadeOut(140, function () {
                $(this).attr('src', 'http://www.enudge.com.au/images/dynamic_element_email_bg.jpg').fadeIn(140);
            });
            textPanel.css('height', '190px');
            appendable[0].fadeOut(140, function () {
                $(this).appendTo('.big-img .img-panel').fadeIn(250);
            });
            break;

        case '#second':
            src.fadeOut(140, function () {
                $(this).attr('src',
                    'https://www.gstatic.com/images/branding/googlelogo/2x/googlelogo_color_284x96dp.png').fadeIn(140);
            });
            textPanel.css('height', '160px');
            appendable[1].fadeOut(140, function () {
                $(this).appendTo('.big-img .img-panel').fadeIn(250);
            });
            break;

        case '#third':
            src.fadeOut(140, function () {
                //$(this).attr('src', '../static/img/tesla.jpg').fadeIn(140) // developer mode
                $(this).attr('src', '/img/how_it_works/tesla.jpg').fadeIn(140); // production mode
            });
            textPanel.css('height', '160px');
            appendable[2].fadeOut(140, function () {
                $(this).appendTo('.big-img .img-panel').fadeIn(250);
            });
            break;

        case '#fourth':
            src.fadeOut(140, function () {
                //$(this).attr('src', '../static/img/hackerman.jpg').fadeIn(140) // developer mode
                $(this).attr('src', '/img/how_it_works/hackerman.jpg').fadeIn(140) // production mode
            });
            textPanel.css('height', '230px');
            appendable[3].fadeOut(140, function () {
                $(this).appendTo('.big-img .img-panel').fadeIn(250);
            });
            break;
    }
}

function makeActive(litem) {
    $(litem).addClass('active-item');
    $(litem + ' .big-round-num').addClass('active-item');
    return litem;
}

function undoActive(litem) {
    $(litem).removeClass('active-item');
    $(litem + ' .big-round-num').removeClass('active-item');
}