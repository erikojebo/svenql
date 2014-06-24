var sven = sven || {};

sven.viewModels = sven.viewModels || {};
sven.viewModels.queryPage = sven.viewModels.queryPage || {};

sven.viewModels.queryPage.create = function (server) {

    var query = ko.observable();
    var resultSets = ko.observableArray();

    function executeQuery() {
        server.executeQuery(query(), function (result) {
            var resultSetViewModel = sven.viewModels.resultSet.create(result);
            //  resultSets.removeAll();
            resultSets.push(resultSetViewModel);

            sven.eventAggregator.publish("query-executed");

        }, function (error) {
            alert(error.exceptionMessage);
        });
    };

    return {
        executeQuery: executeQuery,
        query: query,
        resultSets: resultSets
    };
};