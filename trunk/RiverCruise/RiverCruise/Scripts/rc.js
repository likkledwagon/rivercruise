$(function() {

   // $(".faderContent").hide();
    // $(".faderContent").fadeIn();

    var createAutoComplete = function() {
        var $input = $(this);

        var options = {
            source: $input.attr("data-otf-autocomplete"),
            select: submitAutoCompleteForm
        };

        $input.autocomplete(options);
    };

    var submitAutoCompleteForm = function(event, ui) {
        var $input = $(this);
        $input.val(ui.item.label);

        var $form = $input.parents("form:first");
        $form.submit();
    };

    var getPage = function() {
        var $a = $(this);
        var options = {
            url: $a.attr("href"),
            type: "get"
        };

        $.ajax(options).done(function(data) {
            var target = "div.pagerTarget";
            $(target).replaceWith(data);
        });
    };

    $("input[data-otf-autocomplete]").each(createAutoComplete);

    $(".pageContent").on("click", ".pagination a", getPage);

    $("form.triggerModal").submit(function (e) {
        e.preventDefault();
        var form = $(this);

        var options = {
            url: '/' + form.attr("data-rc-modalcontroller") + '/' + form.attr("data-rc-modalaction"),
            type: "get",
            data: form.serialize(),
        };

        $.ajax(options).done(function (data) {
            $("#modalPlaceHolder").html(data);
            $("#partialModal").modal('show');
        });
        return false;
    });
})