function ViewModel() {
    var self = this;
    self.collection = ko.observableArray();

    self.create = function (formElement) {
        $(formElement).validate();
        if ($(formElement).valid()) {
            $.post(baseUri, $(formElement).serialize(), null, "json")
                .done(function (object) {
                    self.collection.push(object);
                });
        }
    }

    self.update = function (object) {
        $.ajax({ type: "PUT", url: baseUri + '/' + object.Id, data: object });
    }

    self.remove = function (blogPost) {
        $.ajax({ type: "DELETE", url: baseUri + '/' + object.Id })
            .done(function () {
                self.collection.remove(object);
            });
    }

    $.getJSON(getUri, self.collection);
}