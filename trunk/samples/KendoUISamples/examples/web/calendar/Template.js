/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    var today = new Date();
    var birthdays =  [new Date(today.getFullYear(), today.getMonth(), 8).valueOf(), new Date(today.getFullYear(), today.getMonth(), 12).valueOf(), new Date(today.getFullYear(), today.getMonth(), 24).valueOf(), new Date(today.getFullYear(), today.getMonth() + 1, 6).valueOf(), new Date(today.getFullYear(), today.getMonth() + 1, 7).valueOf(), new Date(today.getFullYear(), today.getMonth() + 1, 25).valueOf(), new Date(today.getFullYear(), today.getMonth() + 1, 27).valueOf(), new Date(today.getFullYear(), today.getMonth() - 1, 3).valueOf(), new Date(today.getFullYear(), today.getMonth() - 1, 5).valueOf(), new Date(today.getFullYear(), today.getMonth() - 2, 22).valueOf(), new Date(today.getFullYear(), today.getMonth() - 2, 27).valueOf()];
    $("#calendar").kendoCalendar(
    {
        value: today,
        dates: birthdays,
        month: {content: "# if ($.inArray(+data.date, data.dates) != -1) { #<div class=\'# if (data.value < 10) { #exhibition# } else if ( data.value < 20 ) { #party# } else { #cocktail# } #\'></div># } ##= data.value #"},
        footer: "Today - #=kendo.toString(data, \'d\') #"
    });
};