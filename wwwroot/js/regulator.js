$(document).ready(function () {
    $("input").change(function () {

        $("#submitGroupButton").prop("disabled", false);

        for (let i = 0; i < 4; i++) {
            if ($("input")[i].value === "") {
                $("input")[i].style.backgroundColor = "rgba(255, 0, 0, 0.3)";

                $("#submitGroupButton").prop("disabled", true);
            } else {
                $("input")[i].style.backgroundColor = "rgba(0, 255, 0, 0.3)";
            }
        }
    });
});