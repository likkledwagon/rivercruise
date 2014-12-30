$(function() {

   // $(".faderContent").hide();
    // $(".faderContent").fadeIn();
    $('.datepicker').datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: 'mm/dd/yy'
    });

    $('datepicker-defaultDate').datepicker("setDate", new Date());


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

    var getPage = function(href) {
        var options = {
            url: href,
            type: "get"
        };

        $.ajax(options).done(function(data) {
            var target = "div#pagerTarget";
            $(target).replaceWith(data);
        });
    };

    $("input[data-otf-autocomplete]").each(createAutoComplete);

    $(".pageContent").on("click", ".pagination a", function (event) {
        var senderhref = $(this).attr("href");
        event.preventDefault();
        getPage(senderhref);
    });

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

    $(".pageContent").on("click", "a.triggerModal", function(event) {
        event.preventDefault();


        var id = $(this).attr("data-rc-id");
        var name = $(this).attr("data-rc-name");
        var options = {
            url: '/' + $(this).attr("data-rc-modalcontroller") + '/' + $(this).attr("data-rc-modalaction"),
            type: "get",
            data: { id: id, name: name }
        };

        $.ajax(options).done(function(data) {
            $("#modalPlaceHolder").html(data);
            $("#partialModal").modal('show');
        });
        return false;
    });

    $(".bs-callout").delay(2000).slideUp(400);
})