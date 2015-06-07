var example = 'http://telerikacademy.com/Courses/Courses/Details/239';

function parseURL(input) {
    var i = 0,
        protocolAsString = '',
        serverAsString = '',
        resourceAsString = '',
        len = input.length;

    while (input[i].localeCompare(':')) {
        protocolAsString += input[i];
        i += 1;
    }
    i += 3;

    while (input[i].localeCompare('/')) {
        serverAsString += input[i];
        i += 1;
    }

    while (i < len) {
        resourceAsString += input[i];
        i += 1;
    }

    return {protocol: protocolAsString, server: serverAsString, resource: resourceAsString};
}

console.log(parseURL(example));