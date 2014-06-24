var sven = sven || {};

$(function () {
    var server = sven.server.create();
    var pageViewModel = sven.viewModels.queryPage.create(server);

    pageViewModel.query("select * from [User]");

    ko.applyBindings(pageViewModel);

    sven.eventAggregator.subscribe("query-executed", function() {
        $("table").floatThead({
            useAbsolutePositioning: false
        });
    });
});