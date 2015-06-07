function getHTMLText() {
    var i,
        len,
        result = '',
        content = document.getElementsByTagName('html')[0]['textContent'].toString();

    for (i = 0, len = content.length; i < len; i += 1) {
        if (i === 0) {
            if (content[i].match(/[A-z.]/)) {
                result += content[i];
            }
        } else {
            if (content[i].match(/[A-z.]/)) {
                result += content[i];
            } else if (!content[i].localeCompare(' ')) {
                if (content[i - 1].match(/[A-z.]/) && content[i + 1].match(/[A-z.]/)) {
                    result += content[i];
                }
            }
        }
    }

    return result;
}

console.log(getHTMLText());