var sven = sven || {};

sven.server = sven.server || {};

sven.server.create = function () {

    function executeQuery(query, success, error) {
        var data = JSON.stringify({ query: query });

        $.ajax({
            type: 'POST',
            url: sven.url.create("/api/query"),
            data: data,
            dataType: 'json',
            contentType: 'application/json'
        }).done(success)
        .fail(function(xhr) {
            var exceptionInfo = JSON.parse(xhr.responseText);
            error(exceptionInfo);
        });
    };

    return {
        executeQuery: executeQuery
    };
};