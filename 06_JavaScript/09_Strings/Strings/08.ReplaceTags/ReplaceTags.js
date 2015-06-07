var example = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTags(text) {
    var i,
        len,
        regexStartTagStart = new RegExp('<a href=\"', 'g'),
        regexStartTagEnd = new RegExp('\">', 'g'),
        regexEndTag = new RegExp('</a>', 'g');

    for (i = 0, len = text.length; i < len; i += 1) {
        text = text.replace(regexStartTagStart, '[URL=');
        text = text.replace(regexStartTagEnd, ']');
        text = text.replace(regexEndTag, '[/URL]');
    }

    return text;
}

console.log(replaceTags(example));