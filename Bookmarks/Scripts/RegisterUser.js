$(function() {
    var onRegisterUserButton = $('.register-user-panel button').click(onRegisterUserClick);

    function onRegisterUserClick() {
        var url = '/Account/RegisterUserAsync';
        var antiforgery = $('[name="__RequestVerificationToken"]').val();
        var name = $('.register-user-panel .first-name').val();
        var email = $('.register-user-panel .email').val();
        var pwd = $('.register-user-panel .password').val();

        $.post(url,
            {
                __RequestVerificationToken: antiforgery,
                email: email,
                name: name,
                password: pwd
            },
            function(data) {
                var parsed = $.parseHTML(data);
                var hasErrors = $(parsed).find('[data-valmsg-summary]').text().replace(/\n|\r/g, "").length > 0;

                if (hasErrors == true) {
                    $('.register-user-panel').html(data);
                    onRegisterUserButton = $('.register-user-panel button').click(onRegisterUserClick);
                } else {
                    location.href = '/Home/Index';
                }


            }).fail(function(xhr, status, error) { alert('Post unsuccessful'); });
    }
})