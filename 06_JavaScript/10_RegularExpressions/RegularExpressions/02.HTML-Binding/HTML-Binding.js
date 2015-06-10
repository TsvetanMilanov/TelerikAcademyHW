var str = '<div data-bind-content="name"></div>';
var str2 = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';

String.prototype.bind = function (str, object) {
    var specialTagName = 'data-bind';
    var result = '';
    var indexOfTagEnd = str.indexOf('>');
    var itemsToAdd = [];

    function checkIfSpecialTag(text, startPosition) {
        var substring = text.substr(startPosition, specialTagName.length);

        if (substring == specialTagName) {
            return true;
        }

        return false;
    }

    function getTagType(text, startPosition) {
        var tag = '';

        for (var i = startPosition + 2; text[i] != '='; i++) {
            tag += text[i];
        }

        return tag;
    }

    function getTagProperty(text, startPosition) {
        var result = '';

        for (var i = startPosition + 4; text[i] != '"'; i += 1) {
            result += text[i];
        }

        return result;
    }

    var content = '';

    for (var i = 0; i < str.length; i++) {
        var currentSymbol = str[i];

        if (i === indexOfTagEnd) {
            for (var j = 0; j < itemsToAdd.length; j++) {
                result += itemsToAdd[j];
            }
            result += currentSymbol;
            continue;
        }

        if (checkIfSpecialTag(str, i)) {
            result += specialTagName;
            i += specialTagName.length - 1;

            var tagType = getTagType(str, i);
            switch (tagType) {
                case 'href':
                    var item = getTagProperty(str, i + tagType.length);
                    itemsToAdd.push(' href="' + object[item] + '"');
                    break;
                case 'class':
                    var item = getTagProperty(str, i + tagType.length);
                    itemsToAdd.push(' class="' + object[item] + '"');
                    break;
                case'content':
                    var item = getTagProperty(str, i + tagType.length);
                    content += object[item];
                    break;
            }
        } else {
            result += currentSymbol;
        }
    }

    if (!!content) {
        var indexOfTagEndOfResult = result.indexOf('<', 1);

        result = [result.slice(0, indexOfTagEndOfResult), content, result.slice(indexOfTagEndOfResult)].join('');
    }

    return result;
};

console.log(str.bind(str, {name: 'Steven'}));
console.log('<div data-bind-content="name">Steven</div>');

console.log(str2.bind(str2, {name: 'Elena', link: 'http://telerikacademy.com'}));
console.log('<a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</a>');