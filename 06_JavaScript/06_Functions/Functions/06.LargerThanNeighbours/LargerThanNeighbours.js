var index = 7,
    arr = [1, 2, 3, 4, 5, 6, 7, 8, 7];

function checkIfLarger(inputArr, indexOfElement) {
    var maxIndex = inputArr.length - 1;
    if (indexOfElement >= maxIndex) {
        console.log('There is no neighbor on the right.');
    } else if (indexOfElement <= 0) {
        console.log('There is no neighbor on the left.');
    } else {
        if (inputArr[indexOfElement - 1] < inputArr[indexOfElement] && inputArr[indexOfElement + 1] < inputArr[indexOfElement]) {
            console.log('The element is larger than it\'s neighbors.');
        } else {
            console.log('The element is NOT larger than it\'s neighbors.');
        }
    }
}

checkIfLarger(arr, index);