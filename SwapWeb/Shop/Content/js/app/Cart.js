var cart = (function ($, document) {
    var replaceCart = function (newCartMarkup) {
            $('#cart').replaceWith(newCartMarkup)
        },
        add = function (item) {

            return $.ajax({
                    url: '/cart/add',
                    type: 'POST',
                    contentType: 'application/json',
                    data: JSON.stringify(item)
                })
                .done(function (response) {
                    replaceCart(response);
                })
        },
        decrease = function (id) {
            $.ajax({
                url: '/cart/decreasequantity',
                type: 'POST',
                contentType: 'application/json',
                data: JSON.stringify({ id: id})
            })
            .done(function (response) {
                replaceCart(response)
            })
        },
        clear = function () {
            $.ajax({
                url: '/cart/clear',
                type: 'POST',
                contentType: 'application/json'
            })
            .done(function (response) {
                replaceCart(response)
            })
        };

    $(document)
        .on('click', '.simpleCart_empty', function (e) {
            e.preventDefault();
            clear();
        })
        .on('click', '.increase-btn', function (e) {
            e.preventDefault();
            var id = $(this).closest('li').data('id');

            add({ id: id});
        })
        .on('click', '.decrease-btn', function (e) {
            e.preventDefault();
            decrease($(this).closest('li').data('id'));
        });

    return {
        add: add
    }

})(jQuery, document)