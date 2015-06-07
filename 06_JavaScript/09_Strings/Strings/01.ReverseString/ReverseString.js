var inputString = 'sample';

function reverseString(input) {
    var tempString = '',
        i,
        j,
        len = input.length;

    for (i = 0, j = len - 1; i < len; i += 1, j -= 1) {
        tempString += input[j];
    }

    return tempString;
}

console.log(reverseString(inputString));