/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */
module.exports = function solve() {
    function appendItemsToElement(element, contents) {
        var i,
            len,
            selectedElement,
            currentContentElement,
            clonedDivToAdd,
            fragmentToAdd = document.createDocumentFragment(),
            divWithContentToAdd = document.createElement('div'),
            validator = {
                checkIfSelectedElementIsValid: function (element) {
                    if (!element) {
                        throw new Error('There is no selected element!');
                    }
                },
                checkIfContentItemsArValid: function (content) {
                    var i,
                        len,
                        currentContentElement;

                    for (i = 0, len = content.length; i < len; i += 1) {
                        currentContentElement = content[i];

                        if (typeof currentContentElement === 'string' || typeof currentContentElement === 'number') {
                            continue;
                        } else {
                            throw new Error('Incorrect content!');
                        }

                    }
                }
            };

        if (typeof element === 'string') {
            selectedElement = document.getElementById(element);
        } else {
            selectedElement = element;
        }

        validator.checkIfSelectedElementIsValid(selectedElement);

        validator.checkIfContentItemsArValid(contents);

        selectedElement.innerHTML = '';

        for (i = 0, len = contents.length; i < len; i += 1) {
            currentContentElement = contents[i];

            clonedDivToAdd = divWithContentToAdd.cloneNode(true);

            clonedDivToAdd.innerHTML = currentContentElement;

            fragmentToAdd.appendChild(clonedDivToAdd);
        }

        selectedElement.appendChild(fragmentToAdd);
    }

    return appendItemsToElement;
};