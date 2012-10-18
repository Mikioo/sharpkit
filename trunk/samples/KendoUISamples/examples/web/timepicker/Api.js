/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    $("#timepicker").kendoTimePicker().closest(".k-widget").attr("id", "timepicker_wrapper");
    var timepicker = $("#timepicker").data("kendoTimePicker");
    var setValue = function ()
    {
        timepicker.value($("#value").val());
    };
    $("#enable").click(function ()
    {
        timepicker.enable();
    });
    $("#disable").click(function ()
    {
        timepicker.enable(false);
    });
    $("#open").click(function ()
    {
        timepicker.open();
    });
    $("#close").click(function ()
    {
        timepicker.close();
    });
    $("#value").kendoTimePicker( {change: setValue});
    $("#set").click(setValue);
    $("#get").click(function ()
    {
        window.alert(timepicker.value());
    });
};
