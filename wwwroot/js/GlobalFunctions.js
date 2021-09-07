
var GlobalFunc =
{
    GetPage: function (url, div) {
        $.ajax(
            {
                url: url,
                method: "GET",
                success: function (response) {
                    $(div).html(response);
                }
            })
    },

    LogOut: function () {
        $.ajax({
            url: "/Home/Login",
            method: "GET",
            success: function (res) {
                $("#main-body").html(res);
            }
        });

    },

    HideLogout: function () {
        debugger;
        $(document).find("#logout").hide();
    },

    ShowLogout: function () {
        $(document).find("#logout").show();
    },

    ValidateDate: function () {

    },



}