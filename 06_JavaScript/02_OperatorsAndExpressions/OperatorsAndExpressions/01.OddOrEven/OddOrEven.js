var n = 3;
var m = 2;

function checkIfOdd(number) {
    if (number % 2 == 0) {
        return false;
    } else {
        return true;
    }
}

console.log(n + ' Odd?: ' + checkIfOdd(n));
console.log(m + ' Odd?: ' + checkIfOdd(m));