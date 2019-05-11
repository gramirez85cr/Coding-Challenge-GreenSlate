$(function () {
    var routingApp = $.sammy("#MainContent", function () {
        this.get("#/UserProject/", function (context) {
            $.get("/UserProject/", function (data) {
                context.$element().html(data);
            });
        });
    });
    routingApp.run("#/UserProject/");
});