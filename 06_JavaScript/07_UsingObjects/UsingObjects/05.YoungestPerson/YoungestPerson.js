var people = [
    {firstname: 'Gosho', lastname: 'Petrov', age: 32},
    {firstname: 'Bay', lastname: 'Ivan', age: 81}];

function findYoungestPerson(arrayOfPeople) {
    var i,
        currentAge,
        minAge = Number.MAX_VALUE,
        minAgeIndex,
        len = arrayOfPeople.length;

    for (i = 0; i < len; i += 1) {
        currentAge = arrayOfPeople[i].age;

        if (currentAge < minAge) {
            minAge = currentAge;
            minAgeIndex = i;
        }
    }

    console.log(arrayOfPeople[minAgeIndex].firstname + ' ' + arrayOfPeople[minAgeIndex].lastname);
}

findYoungestPerson(people);