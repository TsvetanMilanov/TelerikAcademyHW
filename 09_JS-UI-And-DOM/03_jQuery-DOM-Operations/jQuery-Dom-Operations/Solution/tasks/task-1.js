/* globals $ */

/* 

 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

function solve() {
    function createUl(selector, count) {
        var i,
            $currentLi,
            $container = $(selector),
            $ul = $('<ul></ul>'),
            $li = $('<li></li>');

        $li.addClass('list-item');
        $ul.addClass('items-list');

        if (typeof selector !== 'string') {
            throw new Error('Invalid type of selector provided!');
        }

        if (!$container) {
            return;
        }

        if (!count) {
            throw new Error('invalid count provided!');
        }

        if (isNaN(+count)) {
            throw new Error('Invalid type of count');
        }

        if (count <= 0) {
            throw new Error('Invalid count provided!');
        }

        for (i = 0; i < count; i += 1) {
            $currentLi = $li.clone(true);
            $currentLi.text('List item #' + i);
            $currentLi.appendTo($ul);
        }

        $ul.appendTo($container);
    }

    return createUl;
}

module.exports = solve;