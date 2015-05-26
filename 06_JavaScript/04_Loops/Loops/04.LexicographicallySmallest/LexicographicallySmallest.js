function findSmallestAndLargest(objectToCheck) {
    var smallest = '';
    var largest = '';
    var isFirstProperty = true;

    for (var property in objectToCheck) {
        property = property.toLowerCase();
        if (isFirstProperty) {
            smallest = property;
            largest = property;
            isFirstProperty = false;
            continue;
        }

        if (smallest > property) {
            smallest = property;
        }

        if (largest < property) {
            largest = property;
        }
    }

    console.log('Smallest in ' + objectToCheck + ' is: ' + smallest);
    document.writeln('<p>' + 'Smallest in ' + objectToCheck + ' is: ' + smallest + '</p>');

    console.log('Largest in ' + objectToCheck + ' is: ' + largest);
    document.writeln('<p>' + 'Largest in ' + objectToCheck + ' is: ' + largest + '</p>');
}

findSmallestAndLargest(document);

findSmallestAndLargest(window);

findSmallestAndLargest(navigator);