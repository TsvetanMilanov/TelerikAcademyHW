var i,
    areEqual = true,
    firstArray = ['a', 'b', 'c', 'd', 'e'],
    secondArray = ['f', 'g', 'h', 'i', 'j'];

for (i = 0; i < firstArray.length; i += 1) {
    if (firstArray[i] != secondArray[i]) {
        areEqual = false;
        break;
    }
}

if (areEqual) {
    console.log("The two arrays are equal.");
} else {
    console.log("The two arrays are not equal.");
}