var sven = sven || {};
sven.viewModels = sven.viewModels || {};
sven.viewModels.column = sven.viewModels.column || {};

sven.viewModels.column.create = function (column) {
    return {
        name: column.name
    };
};