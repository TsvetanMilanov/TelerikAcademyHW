/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    function toggleContentView(selector) {
        var allButtons,
            $container;

        if (!selector) {
            throw new Error('No parameters passed!');
        }

        if (typeof selector === 'string') {
            $container = $(selector);
        } else if (typeof selector === 'function') {
            $container = selector;
        }

        if (!$container.get(0)) {
            throw new Error('Selector does not select anything!');
        }

        allButtons = $('.button');

        if (allButtons.length <= 0) {
            return;
        }

        allButtons.text('hide');

        $container.on('click', '.button', function () {
            var $topmostContentElement,
                $this = $(this);

            $topmostContentElement = selectContentDiv($this);

            toggleVisibility($topmostContentElement);
            toggleTextOfButton($this);
        });

        function toggleVisibility($element) {
            if ($element.hasClass('hidden')) {
                $element.removeClass('hidden');
                $element.css('display', '');
            } else {
                $element.addClass('hidden');
                $element.css('display', 'none');
            }
        }

        function toggleTextOfButton($button) {
            if ($button.text() === 'hide') {
                $button.text('show');
            } else {
                $button.text('hide');
            }
        }

        function selectContentDiv($clickedButton) {
            var $selectedDiv,
                $currentElement;

            $currentElement = $clickedButton.next();

            do {
                if ($currentElement.hasClass('content')) {
                    $selectedDiv = $currentElement;
                    break;
                }

                $currentElement = $currentElement.next();
            } while ($currentElement);

            return $selectedDiv;
        }
    }

    return toggleContentView;
}

module.exports = solve;