define(function (require) {
    return {
        getPeople: function (url) {
            
            var options =
            {
                url: url,
                type: 'GET',
                datatype: 'json'
            };

            return $.ajax(options);
        }
    };
});