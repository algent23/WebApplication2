var dataTable;
$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/book",
            "type": "GET",
            "datatype":"json"
        },
        "colums": [
            { "data": "name", "width": "20%" },
            { "data": "author", "width": "20%" },
            { "data": "isbn", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class='text-center'>
                <a href="/BookList/Edit?id=${data}" class'btn btn-success text-white' style='cursor:pointer;width:100px;'>
                        Edit
                      </a>  
                       &nbsp;
                       <a  class='btn btn-danger text-white' style='cursor:pointer;width:100px;'
onclick=Delete('/api/book?id='+${data})>
                        Delete
                      </a>  
                     </div>;`
                }, "width":"20%"
            }
        ],
        "language": {
            "emptyTab":"no data found"
        },
        "width": "100%"
    })
}
function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once deleted,you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                    url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(message);
                        dataTable.ajax.reload();


                    }
                    else {
                        toastr.error(message);
                    }
                }
            })

        }
    })
}