function sendMessage(e) {
    $("#send_massage").addClass("disabled");
    if(typeof e.type !== 'string' || (e.type == 'keyup' && e.keyCode != 13)) {
        return $('#status').html('no call');
    }
    $('#status').html('made call');
    var variabila = $("#text-massage").val();
    var mesaj = "massage=" + variabila;

    $.ajax({
        type: "POST",
        url: "/ajax/chat.php",
        cache: false,
        data: mesaj,
        success: function (test) {
            $("#text-massage").val('');
            //$("#success").show("fast").delay(900).hide("fast");
            $("#success").html(test);
            $("#send_massage").removeClass("disabled");

        }
    });

}
$(document).ready(function () {
    $(document).focus();
    $("#send_massage").click(sendMessage);
    $(document).keyup(sendMessage);

    $("input").keypress(function(event) {
        if (event.which == 13) {
            event.preventDefault();
            sendMessage();
        }
    });
});