var firstTestObject = {
    id: 0,
    name: 'testName'
};

var secondTestObject = {
    id: 1,
    length: 100
};

function hasPropery(object) {
    var propertyToCheck = 'length';

    for (var prop in object) {
        if (prop === propertyToCheck) {
            return true;
        }
    }

    return false;
}

console.log(hasPropery(firstTestObject));
console.log(hasPropery(secondTestObject));