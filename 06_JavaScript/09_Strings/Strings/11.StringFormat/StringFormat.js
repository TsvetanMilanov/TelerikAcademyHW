var formatterRegex = new RegExp('{([0-9]|[0-9][0-9])}', "g");

function makeArrayOfArgument(arguments) {
    var i,
        result = [],
        len = arguments.length;

    for (i = 1; i < len; i += 1) {
        result.push(arguments[i]);
    }

    return result;
}

function stringFormat(input) {
    var i,
        currentReplacer,
        tempArray = [],
        result = '',
        text = input,
        len,
        arrayOfArguments = makeArrayOfArgument(arguments);

    tempArray = text.split(formatterRegex);

    for (i = 0, currentReplacer = 0, len = tempArray.length; i < len; i += 1) {
        if (tempArray[i].match(/[0-9][0-9]|[0-9]/g)) {
            tempArray[i] = arrayOfArguments[tempArray[i]];
            currentReplacer += 1;
        }
    }

    return tempArray.join('');
}

var frmt = '{0}, {1}, {0} text {2}';
var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');

console.log(str);