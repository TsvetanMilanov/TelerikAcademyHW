var inputText = 'The text is as follows: We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var subStringWord = 'in';

function countSubString(input, subString) {
    var i,
        j,
        temp = '',
        subLen = subString.length,
        len = input.length,
        count = 0;

    for (i = 0; i < len; i++) {
        for (j = i; j - i < subLen; j += 1) {
            temp += input[j];
        }

        if (0 === temp.localeCompare(subString)) {
            count += 1;
        }

        temp = '';
    }

    return count;
}

console.log(countSubString(inputText, subStringWord));