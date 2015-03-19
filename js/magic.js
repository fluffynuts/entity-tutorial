(function() {
            function convertCodeBlocks() {
                var idx = 0;
                $('pre').each(function() {
                    if ($(this).hasClass('not-code')) {
                        return;
                    }
                    $(this).addClass('prettyprint');
                    $(this).addClass('linenums');
                });
            }
            function addStyle() {
                var link = $("<link></link>");
                link.attr("type", "text/css");
                link.attr("rel", "stylesheet");
                link.attr("href", "css/site.css");
                $("head").append(link);
            }
            $(document).ready(function() {
                addStyle();
                convertCodeBlocks();
                prettyPrint();
                $(document).trigger('magic-complete');
            });
})();
