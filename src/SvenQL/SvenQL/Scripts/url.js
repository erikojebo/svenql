var sven = sven || {};

sven.url = sven.url || {};

sven.url.create = function (url) {

    if (url.indexOf("/") === 0) {
        url = url.slice(1);
    }

    return sven.url.rootUrl + url;
};