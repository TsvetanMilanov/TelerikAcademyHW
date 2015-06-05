function deepCopy(objectToCopy) {
    var newObject = {};

    for (var prop in objectToCopy) {
        if (objectToCopy[prop] instanceof Object) {
            newObject[prop] = deepCopy(objectToCopy[prop]);
        }
        else {
            newObject[prop] = objectToCopy[prop];
        }
    }

    return newObject;
}

var firstObject = {
    id: 0,
    type: {
        name: 'someType',
        description: 'someDescription'
    }
};

var secondObject = deepCopy(firstObject);

firstObject.id = 1;
firstObject.type.name = 'changedType';
firstObject.type.description = 'changedDescription';

console.log(firstObject.id + ' ' + firstObject.type.name + ' ' + firstObject.type.description);
console.log(secondObject.id + ' ' + secondObject.type.name + ' ' + secondObject.type.description);