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
            data.forEach((currentElement, index) => {
                //Array contains available days for  the selected doctor
                $("#timeSlots").append(`<option value="${currentElement}"> ${currentElement} </option >`)
            });

        }
    });
});