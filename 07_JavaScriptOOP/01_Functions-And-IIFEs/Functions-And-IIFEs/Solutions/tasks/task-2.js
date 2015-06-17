/* Task description */
/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(start, end) {
    start = +start;
    end = +end;

    if (isNaN(start) || isNaN(end)) {
        throw new Error();
    }

    if ((!start && start !== 0) || !end) {
        throw new Error();
    }

    function isPrime(num) {
        if (num === 0) {
            return false;
        }

        if (num === 1) {
            return false;
        }

        if (num === 2) {
            return true;
        }
        var i,
            top = Math.sqrt(num);

        for (i = 2; i <= top; i += 1) {
            if (num % i === 0) {
                return false;
            }
        }

        return true;
    }

    var i,
        primes = [];

    for (i = start; i <= end; i += 1) {
        if (isPrime(i)) {
            primes.push(i);
        }
    }

    return primes;
}

console.log(findPrimes(0, 5));

module.exports = findPrimes;