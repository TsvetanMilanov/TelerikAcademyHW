var people = [];

function Person(inputFirstName, inputLastName, inputAge, inputGender) {
    this.firstname = inputFirstName;
    this.lastname = inputLastName;
    this.age = inputAge;
    this.gender = inputGender;
}

//01. Create array of persons
function createArrayOfPeople() {
    var result = [];

    result.push(new Person('Pesho', 'Peshov', 15, false));
    result.push(new Person('Pesho', 'Goshov', 20, false));
    result.push(new Person('Gosho', 'Peshov', 10, false));
    result.push(new Person('Gosho', 'Goshov', 25, false));
    result.push(new Person('Petranka', 'Petrova', 22, true));
    result.push(new Person('Kristina', 'Ivanova', 18, true));
    result.push(new Person('Anna', 'Ivanova', 19, true));
    result.push(new Person('Aleksandra', 'Petrova', 20, true));
    result.push(new Person('Aleksandra', 'Aleksandrova', 22, true));
    result.push(new Person('Ina', 'Hristova', 23, true));

    return result;
}

people = createArrayOfPeople();
//console.log(people);

//02. People of age
function onlyPeopleOfAge(input) {
    return input.every(function (item) {
        return item.age >= 18;
    });
}

//console.log(onlyPeopleOfAge(people));

//03. Underage people
function printUnderagePeople(input) {
    var result = input.filter(function (item) {
        return item.age < 18;
    });

    result.forEach(function (item) {
        console.log(item);
    });
}

//printUnderagePeople(people);

//04. Average age of Females
function averageAgeOfFemales(input) {
    var result = input.filter(function (item) {
        return item.gender;
    });

    var average = result.reduce(function (sum, item) {
            return sum += item.age;
        }, 0) / result.length;

    return average;
}

//console.log(averageAgeOfFemales(people));

//05. Youngest person
if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i,
            len = this.length;

        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }

        return undefined;
    }
}
function findYoungestPerson(input) {
    var minAge = Number.MAX_VALUE;

    var result = input.sort(function (x, y) {
        return x.age - y.age;
    });

    return result.find(function (item) {
        return !item.gender;
    })
}

//console.log(findYoungestPerson(people));

//06. Group people
function groupPeople(input) {
    var sortedArray = input.sort(function (x, y) {
        return x.firstname.localeCompare(y.firstname);
    });

    var allLetters = [];
    var result = {};

    input.forEach(function (item) {
        if (allLetters.indexOf(item.firstname[0]) < 0) {
            allLetters.push(item.firstname[0]);
        }
    });

    allLetters.forEach(function (item) {
        result[item] = sortedArray.reduce(function (r, itemInReduce) {
            if (itemInReduce.firstname[0] == item) {
                r.push(itemInReduce);
            }
            return r;
        }, []);
    });


    console.log(result);
}

groupPeople(people);