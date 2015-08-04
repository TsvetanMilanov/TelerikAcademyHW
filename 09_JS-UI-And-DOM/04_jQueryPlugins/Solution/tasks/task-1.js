function solve() {
    return function (selector) {
        var $this = $(selector);
        var $current = $('<div/>');
        $current.addClass('current');

        var $allOptions = $this.children();
        var $currentOption = $($allOptions[0]);

        $current.attr('data-value', $currentOption.attr('value'));
        $current.text($currentOption.text());

        var $optionsContainer = $('<div/>');
        $optionsContainer.addClass('options-container');
        $optionsContainer.css('position', 'absolute');
        $optionsContainer.css('display', 'none');

        $allOptions.each(function (index, element) {
            var $element = $(element);

            var $currentOptionDiv = $('<div/>');
            $currentOptionDiv.addClass('dropdown-item');

            $currentOptionDiv.attr('data-value', $element.val());
            $currentOptionDiv.attr('data-index', index);
            $currentOptionDiv.text($element.text());

            $optionsContainer.append($currentOptionDiv);
        });

        $this.css('display', 'none');
        $this.wrap('<div/>');

        var $container = $this.parent();
        $container.addClass('dropdown-list');
        $container.append($current);
        $container.append($optionsContainer);

        $current.on('click', function () {
            $optionsContainer.css('display', '');
        });

        $optionsContainer.on('click', '.dropdown-item', function () {
            var $currentOption = $(this);

            $current.attr('data-value', $currentOption.attr('data-value'));
            $current.text($currentOption.text());

            $this.val($currentOption.attr('data-value'));

            $optionsContainer.css('display', 'none');
        })
    };
}

module.exports = solve;