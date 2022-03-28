(function () {
    abp.modals.TestModal = function() {
        this.init = function(modalManager) {
            const $modal = modalManager.getModal();

            $modal.find('#IdSelect2').select2();

            var testId = "val1";
            var testText = "text1";
            var optionSelectTest = new Option(testText, testId, true, true);

            $modal.find("#IdSelect2").append(optionSelectTest).trigger('change');
            //alert(123);
        };
    };
}) ();