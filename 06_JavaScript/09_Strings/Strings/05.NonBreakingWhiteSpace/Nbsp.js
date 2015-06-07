var test = 'Some text with spaces.';

function removeNbsp(text) {
    var i,
        len = text.length,
        result = '';

    for (i = 0; i < len; i += 1) {
        if (!text[i].localeCompare(' ')) {
            result += '&nbsp;';
        } else {
            result += text[i];
        }
    }

    return result;
}

console.log(removeNbsp(test));