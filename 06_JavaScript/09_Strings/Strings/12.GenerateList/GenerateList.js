var people = [{name: 'Peter', age: 14}, {name: 'Gosho', age: 18}];
var template = document.getElementById('list-item').innerHTML;
var regexCheckForPlaceholder = new RegExp('-{[A-z]}-');

function createPlaceholderRegEx(input) {
    var regexPlaceHolderFormat = new RegExp('-{' + input + '}-');

    return regexPlaceHolderFormat;
}

function createArrayOfPlaceholders(person) {
    var array = [];

    for (var prop in person) {
        var placeholder = createPlaceholderRegEx(prop);

        array.push(placeholder);
    }

    return array;
}

function createListItem(person, template, placeholderArray) {
    var i,
        len,
        result = '';

    template = template.replace(placeholderArray[0], person.name);
    template = template.replace(placeholderArray[1], person.age);


    return result += '<li>' + template + '</li>';
}

function generateList(people, template) {
    var i,
        len,
        result = '',
        lis = '',
        placeholderArray = createArrayOfPlaceholders(people[0]);

    for (i = 0, len = people.length; i < len; i += 1) {
        var li = createListItem(people[i], template, placeholderArray);
        lis += li;
    }

    return result += '<ul>\n' + lis + '\n</ul>';
}

var peopleList = generateList(people, template);

document.write(peopleList);