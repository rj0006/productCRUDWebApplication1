$('#txtSearch').keyup(function () {
    var typeValue = $(this).val();
    $('#tblData tbody tr').each(function () {
        if ($(this).text().search(new RegExp(typeValue, "i")) < 0) {
            $(this).fadeOut();
        }
        else {
            $(this).show();
        }
    })
});

$(document).ready(function () {
    $('#tblData').DataTable();
});