var homeController = {
    init: function () {
        homeController.registerEvent();
        homeController.loadData();
    },
    registerEvent: function () {
        homeController.loadData();
    },
    loadData: function () {
        $.ajax({
            url: '/Home/LoadData',
            type: 'GET',
            datatype: 'json',
            success: function (response) {
                console.log(response);
                if (response.status) {
                    var data = response.data;
                    var html = '';
                    var template = $('#data-template').html();
                    $.each(data,
                        function (i, item) {
                            html += Mustache.render(template,
                                {
                                    ID: item.ID,
                                    Name: item.Name,
                                    Salary: item.Salary,
                                    Status: item.Status
                                });
                        });
                    $('#tblData').html(html);
                }
            }
        })
    }
}
homeController.init();