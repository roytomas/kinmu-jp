$(function () {
    $('#kogamenModal').modal();
});

function selectCompany() {
    $.ajax({
        url: '/Kogamen/fxxx_Company/Company',
        success: function (data) {
            $('#modalWrapper').html(data);
            $('#kogamenModal').modal('toggle');
        }
    });
}