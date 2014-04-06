var ViewModel = function (category) {
    var self = this;

    self.collection = ko.observableArray();
    $.getJSON(getDataUrl(category), self.collection);
}

function getDataUrl(category) {
    var url = baseUri;

    if (category) {
        url = baseUri + "/" + category;
    }

    return url;
}

var CategoriesViewModel = function () {

    var self = this;
    self.categories = ko.observableArray();

    $.getJSON(categoriesUri, self.categories);
}



