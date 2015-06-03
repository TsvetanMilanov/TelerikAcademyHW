var word = 'Function',
    i,
    j,
    separators = [',', '.', '!', '-', ';'],
    input = 'Write a function, that finds all the occurrences of word in a text. The search can be case sensitive or case insensitive. Use function overloading.';

function isSeparator(letter) {
    for (j = 0; j < separators.length; j += 1) {
        if (letter === separators[j]) {
            return true;
        }
    }

    return false;
}

function findOccurrences() {
    var inputText = '',
        replacedSeparators = '',
        inputWords = [],
        wordToFind,
        caseInsesitive = false,
        count = 0;

    switch (arguments.length) {
        case 2:
            inputText = arguments[0];
            wordToFind = arguments[1];
            break;
        case 3:
            inputText = arguments[0];
            wordToFind = arguments[1];
            caseInsesitive = arguments[2];
            break;

    }

    for (i = 0; i < inputText.length; i += 1) {
        if (isSeparator(inputText[i])) {
            replacedSeparators += ' ';
        } else {
            replacedSeparators += inputText[i];
        }
    }

    inputWords = replacedSeparators.split(' ');

    for (i = 0; i < inputWords.length; i += 1) {
        if (caseInsesitive) {
            if (wordToFind.toLowerCase() === inputWords[i].toLowerCase()) {
                count += 1;
            }
        } else {
            if (wordToFind === inputWords[i]) {
                count += 1;
            }
        }
    }

    console.log(count);
}

findOccurrences(input, word);

findOccurrences(input, word, true);