$(function () {
    abp.log.debug('Index.js initialized!');


    var testModal = new abp.ModalManager({
        viewUrl: abp.appPath + '_TestModal',
        scriptUrl: abp.appPath + 'Pages/_TestModal.cshtml.js',
        modalClass: 'TestModal'
    });


    $("#test").on("click",
        function () {
            testModal.open();
        });
});
