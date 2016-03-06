(function ($, document, cart) {
    
    $(document).on('click', '.btn_add', function (e) {
        e.preventDefault();
        var $addBtn = $(this);
        $addBtn.prop('disable', true);
        cart.add({
            id: $addBtn.data('id')
        })
        .always(function () {
            $addBtn.prop('disable', false);
        })
    })

})(jQuery, document, cart);