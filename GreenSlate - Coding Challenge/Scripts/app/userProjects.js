if (userProject === undefined) {
    var userProject = {
        selector: 'select#slcUsers',
        loadUrl: '/api/user/',
        loadGridUrl: '/UserProject/Get/',
        selectorGrid: '#divUserProjectsGrid',
        load: function () {
            $.get(this.loadUrl, this.populateUsersDropDown);
            $(this.selector).change(this.selectUserDropDown);
        },
        populateUsersDropDown: function (data) {
            var html = '<option value="">--</option>';
            var len = data.length;
            for (var i = 0; i < len; i++) {
                html += '<option value="' + data[i].Id + '">' + data[i].FirstName + ' ' + data[i].LastName + '</option>';
            }
            $(userProject.selector).html(html);
        },
        selectUserDropDown: function () {
            var id = $(userProject.selector + " option:selected").val();
            if (id === "") {
                $(userProject.selectorGrid + ' tbody').html("");
            } else {
                $.get(userProject.loadGridUrl + id, userProject.populateUserProjectsList);
            }
        },
        populateUserProjectsList(html) {
            $(userProject.selectorGrid + ' tbody').html(html);
        }
    };
}
if (userProject !== undefined) {
    if ($(userProject.selector).length) {
        userProject.load();
    }
}
