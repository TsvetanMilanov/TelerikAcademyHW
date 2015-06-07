var example = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

function getTagName(text, startIndex) {
    var j,
        len = text.length,
        result = '';

    for (j = startIndex + 1; j < len; j += 1) {
        if (0 != text[j].localeCompare('>')) {
            result += text[j];
        } else {
            return result;
        }
    }

    return result;
}

function textFromTag(substring, text, start) {
    var j,
        len = text.length,
        tag = '',
        result = '';

    if (0 === substring[0].localeCompare('/')) {
        return result;
    }

    switch (substring) {
        case 'upcase':
            for (j = start + substring.length + 2; j < len; j += 1) {
                if (0 === text[j].localeCompare('>')) {
                    break;
                } else if (0 === text[j].localeCompare('<')) {
                    if (0 === text[j + 1].localeCompare('/')) {
                        return result
                    } else {
                        tag = getTagName(text, j);
                        result += textFromTag(tag, text, j);
                    }
                } else {
                    result += text[j].toUpperCase();
                }
            }
            break;
        case 'lowcase':
            for (j = start + substring.length + 2; j < len; j += 1) {
                if (0 === text[j].localeCompare('>')) {
                    break;
                } else if (0 === text[j].localeCompare('<')) {
                    if (0 === text[j + 1].localeCompare('/')) {
                        return result
                    } else {
                        tag = getTagName(text, j);
                        result += textFromTag(tag, text, j);
                    }
                } else {
                    result += text[j].toLowerCase();
                }
            }
            break;
        case 'mixcase':
            for (j = start + substring.length + 2; j < len; j += 1) {
                if (0 === text[j].localeCompare('>')) {
                    break;
                } else if (0 === text[j].localeCompare('<')) {
                    if (0 === text[j + 1].localeCompare('/')) {
                        return result
                    } else {
                        tag = getTagName(text, j);
                        result += textFromTag(tag, text, j);
                    }
                } else {
                    var random = Math.random() * 10;

                    if (random > 5) {
                        result += text[j].toUpperCase();
                    } else {
                        result += text[j].toLowerCase();
                    }
                }
            }
            break;
    }

    return result;
}

function parseTags(input) {
    var i,
        len = input.length,
        substring = '',
        result = '';

    for (i = 0; i < len; i += 1) {
        if (0 === input[i].localeCompare('<')) {
            substring = getTagName(input, i);

            var subResult = textFromTag(substring, input, i)

            i += (substring.length * 2) + 4;
            i += subResult.length;

            result += subResult;
        } else {
            result += input[i];
        }
    }
    return result;
}

console.log(parseTags(example));