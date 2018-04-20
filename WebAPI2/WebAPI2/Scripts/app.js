var ViewModel = function () {
    var self = this;
    self.products = ko.observableArray();
    self.error = ko.observable();
    self.detail = ko.observable();
    self.categories = ko.observableArray();
    self.editdata = ko.observable();

    self.newProduct = {
        Name: ko.observable(),
        Price: ko.observable(),
        Category: ko.observable()

    }

    self.editProduct = {
        Name: ko.observable(),
        Price: ko.observable(),
        Category: ko.observable()
    }

    var productsUri = '/api/products/';
    var categoriesUri = '/api/categories/';

    function ajaxHelper(uri, method, data) {
        self.error('');
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) { self.error(errorThrown); });
    }

    function getAllProducts() {
        ajaxHelper(productsUri, 'GET').done(function (data) {
            for (var i = 0; i < data.length; i++) {
                self.format = ko.computed(function () {
                    var price = data[i].Price;
                    price = price > 0 ? "$" + price.toFixed(2) : price;
                    data[i].Price = price;
                });
            }
            self.products(data);
        });
    }



    function getAllCategories() {
        ajaxHelper(categoriesUri, 'GET').done(function (data) {
            self.categories(data);
        });
    }


    self.getProductsDetail = function (item) {
        ajaxHelper(productsUri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }


    self.addProducts = function (fromElement) {
        var products = {
            CategoryID: self.newProduct.Category().Id,
            Name: self.newProduct.Name(),
            Price: self.newProduct.Price()
        };
        console.log(products);
        ajaxHelper(productsUri, 'POST', products).done(function (item) {
            self.products.push(item);
        });
    }

    self.editProducts = function (item, fromElement) {
        var product = {
            CategoryID: self.editProduct.Category().Id,
            Name: self.editProduct.Name(),
            Price: self.editProduct.Price()
        };
        console.log(product);
        ajaxHelper(productsUri + item.Id, 'PUT', product).done(function (item) {
            self.editdata.put(item);
        });
    }

    getAllProducts();
    getAllCategories();
}

ko.applyBindings(new ViewModel());