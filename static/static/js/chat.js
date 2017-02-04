$(document).ready(function() {
    $('#send_massage').click(function() {
        $('#send_massage').addClass('disabled');
        var val = $("#text-massage").val();
        var b = 'massage=' + val;
        $.ajax({
            type: 'POST',
            url: "../../ajax/chat.php",
            cache: false,
            data: b,
            success: function(az) {
                $("#text-massage").val("");
                load_messes();
            }
        });
    });
    $('#smile').click(function() {
        alert("Smiles had been offed!");
    });
});