/* globals $ */

/* 

 Create a function that takes an id or DOM element and:


 */

function solve() {
    function toggleContentView(selector) {
        var allButtons;

        if (!selector) {
            throw new Error('No parameters passed!');
        }

        if (typeof selector === 'string') {
            selector = document.getElementById(selector);
        }

        allButtons = document.querySelectorAll('.button');

        addContentToButtons(allButtons, 'hide');

        selector.addEventListener('click', function (event) {
            var topmostContentElement,
                target = event.target;

            if (target.className.indexOf('button') >= 0) {
                topmostContentElement = selectContentDiv(target);

                toggleVisibility(topmostContentElement);
                toggleTextOfButton(target);
            }
        });

        function toggleVisibility(element) {
            var indexOfHiddenClassInArray,
                arrayOfClasses,
                indexOfHiddenClass = element.className.indexOf('hidden');

            if (indexOfHiddenClass >= 0) {
                arrayOfClasses = element.className.split(' ');
                indexOfHiddenClassInArray = arrayOfClasses.indexOf('hidden');
                arrayOfClasses.splice(indexOfHiddenClassInArray, 1);

                element.className = arrayOfClasses.join('');

                element.style.display = '';
            } else {
                element.className += ' hidden';

                element.style.display = 'none';
            }
        }

        function toggleTextOfButton(button) {
            if (button.innerHTML === 'hide') {
                button.innerHTML = 'show';
            } else {
                button.innerHTML = 'hide';
            }
        }

        function addContentToButtons(buttons, content) {
            var i,
                len,
                currentButton;

            for (i = 0, len = buttons.length; i < len; i += 1) {
                currentButton = buttons[i];

                currentButton.innerHTML = content;
            }

            return buttons;
        }

        function selectContentDiv(clickedButton) {
            var selectedDiv,
                currentElement;

            currentElement = clickedButton.nextElementSibling;
            do {
                if (currentElement.className.indexOf('content') >= 0) {
                    selectedDiv = currentElement;
                    break;
                }

                currentElement = currentElement.nextElementSibling;
            } while (currentElement);

            return selectedDiv;
        }
    }

    return toggleContentView;
}

module.exports = solve;