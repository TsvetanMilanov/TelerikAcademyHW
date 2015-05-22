var numbers = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];

function isPrime(number) {
    if (number <= 1) {
        return false;
    }

    if ((number == 2) || (number == 3) || (number == 5) || (number == 7)) {
        return true;
    }

    if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0)) {
        return true;
    } else {
        return false;
    }
}

for (var i = 0; i < numbers.length; i++) {
    console.log(numbers[i] + 'is prime?: ' + isPrime(numbers[i]));
}