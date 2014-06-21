var sven = sven || {};

$(function () {
    var server = sven.server.create();
    var pageViewModel = sven.queryPageViewModel.create(server);

    ko.applyBindings(pageViewModel);
});