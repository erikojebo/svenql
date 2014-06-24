var sven = sven || {};

sven.viewModels = sven.viewModels || {};
sven.viewModels.resultSet = sven.viewModels.resultSet || {};

sven.viewModels.resultSet.create = function (resultSet) {

    var columnViewModels = resultSet.columns.map(function (column) {
        return sven.viewModels.column.create(column);
    });

    var rowViewModels = resultSet.rows.map(function(row) {
        return sven.viewModels.row.create(row);
    });

    return {
        columns: ko.observableArray(columnViewModels),
        rows: ko.observableArray(rowViewModels)
    };
};