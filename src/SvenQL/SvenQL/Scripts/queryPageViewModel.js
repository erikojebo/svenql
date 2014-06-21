var sven = sven || {};

sven.queryPageViewModel = sven.queryPageViewModel || {};

sven.queryPageViewModel.create = function (server) {

    var query = ko.observable();

    function executeQuery() {
        server.executeQuery(query(), function(result) {
            console.log("result" + result);
        }, function (error) {
            alert(error.exceptionMessage);
        });
    };

    return {
        executeQuery: executeQuery,
        query: query
    };
};