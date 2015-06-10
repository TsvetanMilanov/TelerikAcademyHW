var options = {name: 'John'};

String.prototype.format = function (options) {
    var result = this;

    function getNameOfPlaceholder(startIndex, text) {
        var name = '';

        for (var i = startIndex + 1; text[i] != '}'; i++) {
            name += text[i];
        }

        return name;
    }

    for (var i = 0; i < this.length; i++) {
        if (this[i] == '#' && this[i+1] == '{') {
            var currentProperty = getNameOfPlaceholder(i + 1, this);

            var regexPlaceholder = new RegExp('#{' + currentProperty + '}', 'g');

            result = result.replace(regexPlaceholder, options[currentProperty]);
        }
    }

    return result;
};

console.log('Hello, there! Are you #{name}?'.format(options));

var options2 = {name: 'John', age: 13};
console.log('My name is #{name} and I am #{age}-years-old'.format(options2));