var sven = sven || {};

sven.viewModels = sven.viewModels || {};
sven.viewModels.row = sven.viewModels.row || {};

sven.viewModels.row.create = function (row) {
    return {
        values: ko.observableArray(row.values)
    };
};