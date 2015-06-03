var output,
    inputAsString,
    input = 123.45;

function reverseNumber (inputNumber) {
    inputAsString = inputNumber.toString();

    output = inputAsString.split('').reverse().join('');

    console.log(parseFloat(output));
}

reverseNumber(input);