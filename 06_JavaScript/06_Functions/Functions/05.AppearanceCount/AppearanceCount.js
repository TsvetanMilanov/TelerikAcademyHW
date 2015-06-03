var i;

function countAppearance(inputNumber, array) {
    var count = 0;

    for (i = 0; i < array.length; i += 1) {
        if (array[i] === inputNumber) {
            count += 1;
        }
    }

    return count;
}

function testFunction() {
    var testArray = [1, 2, 3, 7, 7];
    var expectedResult = 2;
    var numberToSearch = 7;
    var result = countAppearance(numberToSearch, testArray);

    if (result === expectedResult) {
        console.log('The function is working properly.');
    } else {
        console.log('The function is NOT working properly.');
    }
}

testFunction();