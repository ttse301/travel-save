$(document).ready(function()
    {
        $("#dtBox").DateTimePicker({
        dateFormat: "yyyy-MM-dd",
        timeFormat: "hh:mm AA",
    });
});

function goBack()
{
  window.history.back()
}