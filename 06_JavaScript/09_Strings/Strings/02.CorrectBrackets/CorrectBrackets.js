var inputString = '((a+b)/5-d)';
var secondInputString = ')(a+b))';

function checkBrackets(input) {
    var i,
        temp = '' + input,
        len = input.length,
        openBracketsCounter = 0,
        closeBracketsCounter = 0;

    for (i = 0; i < len; i += 1) {
        if (0 === temp[i].localeCompare('(')) {
            openBracketsCounter += 1;
        } else if (0 === temp[i].localeCompare(')')) {
            closeBracketsCounter += 1;
        }
    }

    if (openBracketsCounter === closeBracketsCounter) {
        return true;
    }

    return false;
}

console.log(checkBrackets(inputString));
console.log(checkBrackets(secondInputString));