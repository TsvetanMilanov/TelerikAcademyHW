var i,
    currentElement,
    lastElement,
    arrSequence = [],
    maxArrSequence = [],
    currentSequence = 0,
    maxSequence = 0,
    arr = [3, 2, 3, 4, 2, 2, 4];

for (i = 0; i < arr.length; i += 1) {
    if (i === 0) {
        currentElement = arr[i];
        currentSequence += 1;
        maxSequence = currentSequence;
        maxSequenceElement = currentElement;
        arrSequence.push(currentElement);
        continue;
    }

    currentElement = arr[i];
    lastElement = arr[i - 1];

    if (currentElement - lastElement === 1) {
        currentSequence += 1;
        arrSequence.push(currentElement);
    } else {
        if (maxSequence < currentSequence) {
            maxSequence = currentSequence;
            maxArrSequence = arrSequence;
        }
        currentSequence = 1;
        arrSequence = [];
        arrSequence.push(currentElement);
    }
}

if (maxSequence < currentSequence) {
    maxSequence = currentSequence;
    maxArrSequence = arrSequence;
}

console.log(maxArrSequence);