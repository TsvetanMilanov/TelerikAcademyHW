var index = 7,
    arr = [1, 2, 3, 7, 5, 6, 7, 8, 7];

function checkIfLarger(inputArr, indexOfElement) {
    var i,
        maxIndex = inputArr.length - 1;

    for (i = 1; i < maxIndex; i += 1) {
        if (inputArr[i] > inputArr[i - 1] && inputArr[i] > inputArr[i + 1]) {
            return i;
        }
    }

    return -1;
}

console.log(checkIfLarger(arr, index));