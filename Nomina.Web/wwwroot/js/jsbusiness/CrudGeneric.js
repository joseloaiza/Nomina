//Get data list 
function getData(urlapi, entityColumns, numcolumns, nomtabla) {

    var columns = [];
    columns = entityColumns;
    columns[numcolumns] = { "defaultContent": "<button type='button' class='editar btn btn-primary'><i class='fa fa-pencil'></i></button>" };   
    columns[numcolumns + 1] = { "defaultContent": "<button type='button' class='eliminar btn btn-danger'><i class='fa fa-pencil'></i></button>" };   
     $.ajax({
        url: urlapi,
        dataType: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            BindDataTable(data, columns, nomtabla);
        }
    })
}

var BindDataTable = function (data, columns, nomtabla) {

    var table = $(nomtabla).DataTable({
        "responsive": true,
        "aaData": data,
        "aoColumns": columns
    });

    var value = nomtabla.concat(' tbody');
    $(value).on('click', 'button.editar', function () {
        var d = table.row($(this).parents('tr')).data();
        var key = Object.keys(d)[0];
        value = d[key]
        $('#ModalNew').data('id', value).modal('show');
    });


}



