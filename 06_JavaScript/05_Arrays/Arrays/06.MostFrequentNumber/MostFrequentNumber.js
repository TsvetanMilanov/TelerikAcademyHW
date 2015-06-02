var i,
    j,
    currentNumber,
    currentCount = 0,
    maxCount = 0,
    maxNumber = 0,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

for (i = 0; i < arr.length; i += 1) {
    currentNumber = arr[i];
    for (j = 0; j < arr.length; j += 1) {
        if (currentNumber == arr[j]) {
            currentCount++;
        }
    }

    if (currentCount > maxCount) {
        maxCount = currentCount;
        maxNumber = currentNumber;
    }
    currentCount = 0;
}

console.log(maxNumber + ' (' + maxCount + ' times)')