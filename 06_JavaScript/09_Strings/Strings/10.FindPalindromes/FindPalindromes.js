var example = 'lamal';

function isPalindrome(input) {
    var reversedInput = input.split('').reverse().join('');

    if (!input.localeCompare(reversedInput)) {
        return true;
    }

    return false;
}

console.log(isPalindrome(example));