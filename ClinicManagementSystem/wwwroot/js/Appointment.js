$('#doctorsDropdown').change(function () {

    var selectedDoctorId = $(this).val();

    $.ajax({
        url: "/Schedule/GetSchedulesByDoctorId?doctorId=" + selectedDoctorId, 
        type: "GET",  
        dataType: "json",        
        success: function (response) {
            var allowedDays = [];
            var data = response.data;
            data.forEach((currentElement, index) => {
                //Array contains available days for  the selected doctor
                allowedDays.push(currentElement.day); 
            });

            $("#appointmentDate").datepicker({
                dateFormat: "yy-mm-dd", 
                minDate: 0,
                beforeShowDay: function (date) {
                    var day = date.getDay();
                    // Check if the current day index is in the allowedDays array
                    if ($.inArray(day, allowedDays) !== -1) {
                        // Return true to enable the date
                        return [true, '', ''];
                    } else {
                        // Return false to disable the date
                        return [false, '', ''];
                    }
                }
            });
             
        }
         
    });
});

$("#appointmentDate").change(function () {
    var selectedDoctorId = $("#doctorsDropdown").val();
    var date = $("#appointmentDate").val();
    $.ajax({
        url: "/Appointment/GetAvailableTimeSlots?doctorId=" + selectedDoctorId+"&date="+date,
        type: "GET",
        dataType: "json",
        success: function (response) {
            var data = response.data;
            $("#timeSlots").empty().append(`<option value="">-- Select Time --</option>`);
            data.forEach((currentElement, index) => {
                //Array contains available days for  the selected doctor
                $("#timeSlots").append(`<option value="${currentElement}"> ${currentElement} </option >`)
            });

        }
    });
});


$("#appointmentForm").submit(function (e) {

    e.preventDefault();  
    var doctorId = $("#doctorsDropdown").val();  
    var appointmentDate = $("#appointmentDate").val(); 
    var appointmentTime = $("#timeSlots").val();  

     
    if (!doctorId) {
        toastr.error("Please select a doctor.");
        return;  
    }

    if (!appointmentDate) {
        toastr.error("Please select an appointment date.");
        return;
    }

    if (!appointmentTime) {
        toastr.error("Please select an appointment time.");
        return;
    }

    $.ajax({
        url: $(this).attr("action"),
        type: "POST",
        data: $(this).serialize(),
        success: function (response) {

            if (response.status == 'Success') {

                toastr.success(response.message);

                window.location.href = "/Appointment/Index"
            }
            else {
                toastr.error(response.message);
            }
        },
        error: function () {
            toastr.error("Something went wrong.");
        }
    });
});