
$(document).ready(function() {

    if (location.href.toLowerCase().indexOf("/products") < 0) { // if user is on a url which contains '/products'
        localStorage.removeItem("activeNav"); // remove the localStorage session
    } else {
        if (getCookie("activeNav") === 'undefined' ||
            getCookie("activeNav") === null) {
            $('.crud-nav').find('.menu-item:first-of-type').addClass('active-nav-item');
            var item = $('.crud-nav').find('.menu-item:first-of-type').find('a').text().trim();
            localStorage.setItem("activeNav", item);
        }

        $('.crud-nav .menu-item a').click(function() {
            var item = $(this).text().trim(); // new item menu value
            var oldItem = getCookie("activeNav"); // old item menu value

            if (oldItem !== item) {
                $('.items-wrapper').find('.menu-item a').each(function() { // iterate over each <a> element
                    $this = $(this); // <a>

                    // if text ($this.text()) within <a> tags ....
                    if ($this.text() === oldItem) {
                        $this.parent().removeClass('active-nav-item');
                    }
                    if ($this.text() === item) {
                        localStorage.setItem("activeNav", $this.text());
                    }
                });
            }
        });

        var itemText = localStorage.getItem("activeNav"); // get the new value assigned in foreach
        $('.items-wrapper').find('.menu-item a').each(function() {
            $this = $(this);

            // compare new value (text) to each <a>text</a> and if it matches add the active class
            // to <a>'s parent <div class=".menu-item">
            if ($this.text() === itemText) {
                $this.parent().addClass('active-nav-item');
            }
        });
    }

});


function setCookie(key, value) {
    localStorage.setItem(key, value);
}

function getCookie(key) {
    return localStorage.getItem(key);
}