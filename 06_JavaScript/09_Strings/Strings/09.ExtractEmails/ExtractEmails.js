var text = 'asf@abv.bg sf fs sfg sfgsfa wrwfg@gmail.com sdfsf asf  qdasdas@ymail.com';

function extractEmails(input) {
    var i,
        len,
        words = [],
        result = [];

    words = input.split(/ +/g);

    for (i = 0, len = words.length; i < len; i += 1) {
        if (words[i].indexOf('@') > -1) {
            result.push(words[i])
        }
    }

    return result;
}

console.log(extractEmails(text));