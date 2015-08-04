function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = this;
            var template = $('#' + $this.attr('data-template')).html();

            var compiledTemplate = handlebars.compile(template);

            data.forEach(function (element) {
                var $elementToAppend = $(compiledTemplate(element));
                $this.append($elementToAppend);
            });
        };
    };
}

module.exports = solve;