var firstNumber = 3;
var secondNumber = 0;
var thirdNumber = 35;

function checkNumber(number) {
    if (number % 7 == 0 && number % 5 == 0) {
        console.log(number + ' is divisible by 7 and 5: ' + true);
    } else {
        console.log(number + ' is divisible by 7 and 5: ' + false);
    }
}

checkNumber(firstNumber);
checkNumber(secondNumber);
checkNumber(thirdNumber);