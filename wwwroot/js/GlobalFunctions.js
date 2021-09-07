
var GlobalFunc =
{
    GetPage: function (url, div)
    {
        $.ajax(
            {
                url: url,
                method: "GET",
                success: function (response)
                {
                    $(div).html(response);
                }
            })
    },

    ValidateDate: function ()
    {

    }

}