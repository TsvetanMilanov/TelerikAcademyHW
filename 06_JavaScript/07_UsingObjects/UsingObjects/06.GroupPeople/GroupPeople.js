var people = [
    {firstname: 'Gosho', lastname: 'Petrov', age: 32},
    {firstname: 'Bay', lastname: 'Ivan', age: 81}];

function deepCopy(objectToCopy) {
    var newObject = [];

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

function group(inputArray, criteria) {
    var copyOfArray = deepCopy(inputArray);
    var resultArray = [];

    switch (criteria) {
        case 'firstname':
            resultArray['firstname'] = copyOfArray.sort(function (firstItem, secondItem) {
                return (firstItem.firstname).localeCompare((secondItem.firstname));
            });
            break;
        case 'lastname':
            resultArray['lastname'] = copyOfArray.sort(function (firstItem, secondItem) {
                return firstItem.lastname.localeCompare(secondItem.lastname);
            });
            break;
        case 'age':
            resultArray['age'] = copyOfArray.sort(function (firstItem, secondItem) {
                return firstItem.age - secondItem.age;
            });
            break;
    }

    return resultArray;
}

var groupedByFname = group(people, 'firstname');
var groupedByLname = group(people, 'lastname');
var groupedByAge = group(people, 'age');

console.log(groupedByFname);
console.log(groupedByLname);
console.log(groupedByAge);