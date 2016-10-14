$(document).ready(function () {

    $('#btnAddEmployee').on('click', function () {
        $('#txtfirstName').val(" ");
        $('#txtmiddleName').val(" ");
        $('#txtlastName').val(" ");
        $('#txtbirthdate').val(" ");
        $('#txtemail').val(" ");
    });

    $('#btnSaveEmployee').on('click', function () {

        var data = {
            FirstName: $('#txtfirstName').val(),
            MiddleName: $('#txtmiddleName').val(),
            LastName: $('#txtlastName').val(),
            BirthDate: $('#txtbirthdate').val(),
            Email: $('#txtemail').val()
        }
        $.ajax({
            url: saveEmployeeUrl,
            data: data,
            type: 'GET',
            success: function (data) {
                clearField(data);
            },
            error: function () {
                alert('Something went wrong')
            }
        })

        function clearField(data) {
            $('#txtfirstName').val(" ");
            $('#txtmiddleName').val(" ");
            $('#txtlastName').val(" ");
            $('#txtbirthdate').val(" ");
            $('#txtemail').val(" ");
        }

    });

    $('.table').on('click', 'tr', function () {
        var currentRow = $(this).closest("tr");
        var data = {
            EmployeeID: currentRow.find("td:eq(0)").text()
        }

        $.ajax({
            url: selectEmployeeUrl,
            data: data,
            type: 'GET',
            success: function (data) {
                clearField(data);
            },
            error: function () {
                alert('Something went wrong')
            }
        })

        function clearField(data) {
            
            $('#txtfirstName').val(data.Status.FirstName);
            $('#txtmiddleName').val(data.Status.MiddleName);
            $('#txtlastName').val(data.Status.LastName);

            $('#txtemail').val(data.Status.Email);
            //$('#txtbirthdate').datepicker(data.Status.BirthDate);
            $('#txtbirthdate').val(data.Status.BirthDate.Date);
            //$("#txtbirthdate").value = data.Status.BirthDate;
        }
    });

    $('.glyphicon').on('click', function () {
        var currentRow = $(this).closest("tr");
        var data = {
            EmployeeID: currentRow.find("td:eq(0)").text()
        }
        
        $.ajax({
            url: deleteEmployeeUrl,
            data: data,
            type: 'GET',
            success: function (data) {
                clearField(data);
            },
            error: function () {
                alert('Something went wrong')
            }
        })

        function clearField(data) {
            $('#txtfirstName').val(data.Status.FirstName);
            $('#txtmiddleName').val(data.Status.MiddleName);
            $('#txtlastName').val(data.Status.LastName);
            $('#txtbirthdate').append(data.Status.BirthDate.Date);
            $('#txtemail').val(data.Status.Email);
        }
    });


})