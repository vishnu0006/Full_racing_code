$(document).ready(function () {
    $('#calendar').fullCalendar({
        
        header:
        {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        buttonText: {
            today: 'today',
            month: 'month',
            week: 'week',
            day: 'day'
        },

        events: function (start, end, timezone, callback) {
            console.log("inside events");
            $.ajax({
                url: '/Event/AllEvents',
                type: "GET",
                dataType: "JSON",
                
                success: function (result) {
                    var events = [];
                    //console.log("result",result);
                    $.each(result, function (i, data) {
                        events.push(
                            {
                                id: data.id,
                                title: data.name,
                                description: data.Desc,
                                date: data.date,
                                location: data.location,
                                startTime: data.timeStart,
                                endTime: data.timeEnd,
                                start: moment(data.date).format('YYYY-MM-DD hh:mm'),
                                allDay: false,
                                backgroundColor: "#01FCD9"
                            });
                    });

                    callback(events);
                }
            });
        },
        eventClick: function (calEvent, jsEvent, view) {
            //alert(calEvent.start);
            //alert('Event: ' + moment('29/02/2020T09:10:00.000').format('YYYY-MM-DD hh:mm'));
            console.log(calEvent.id);
            //UpdateEvent(calEvent.id);
            sessionStorage.setItem("e_id", calEvent.id);

            $('#modalTitle').html(calEvent.title);
            $('#eventLoc').html(calEvent.location);
            $('#eventDate').html(calEvent.date);
            $('#eventSTime').html(calEvent.startTime);
            $('#eventETime').html(calEvent.endTime);
            $('#eventDesc').html(calEvent.description);
            $('#calendarModal').modal();
        },

        editable: false
    });
});  



//function UpdateEvent(EventID) {
//    function RegisterEvent(EventID) {
//        //var dataRow = {
//        //    'id': EventID,
//        //    'NewEventStart': EventStart,
//        //    'NewEventEnd': EventEnd
//        //}
//        console.log(EventID);
//        $.ajax({
//            type: 'POST',
//            //url: "@Url.Action("ViewEvent","Event")",
//            dataType: "json",
//            contentType: "application/json",
//            data: JSON.stringify({ id: EventID }),
//            success: function (data) {
//                console.log(data)

//            }

//        });
//    }
//}