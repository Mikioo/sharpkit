/*Generated by SharpKit 5 v4.29.7000*/
function btn_onclick()
{
    var prmValue=$("#textbox1").val();
    $.getJSON("MyHandler.ashx",{prm:prmValue},function(data,status,req)
    {
        alert("Server returned: " + data.NewValue);
    });
};
