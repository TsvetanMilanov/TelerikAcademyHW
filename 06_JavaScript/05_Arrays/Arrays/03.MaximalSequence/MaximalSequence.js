var i,
    currentElement,
    lastElement,
    maxSequenceElement,
    arrSequence = [],
    currentSequence = 0,
    maxSequence = 0,
    arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

for (i = 0; i < arr.length; i += 1) {
    if (i === 0) {
        currentElement = arr[i];
        currentSequence += 1;
        maxSequence = currentSequence;
        maxSequenceElement = currentElement;
        continue;
    }

    currentElement = arr[i];
    lastElement = arr[i - 1];

    if (currentElement === lastElement) {
        currentSequence += 1;
    } else {
        if (maxSequence < currentSequence) {
            maxSequence = currentSequence;
            maxSequenceElement = lastElement;
        }
        currentSequence = 1;
    }
}

if (maxSequence < currentSequence) {
    maxSequence = currentSequence;
    maxSequenceElement = lastElement;
}

for (i = 0; i < maxSequence; i += 1) {
    arrSequence.push(maxSequenceElement);
}

console.log(arrSequence);