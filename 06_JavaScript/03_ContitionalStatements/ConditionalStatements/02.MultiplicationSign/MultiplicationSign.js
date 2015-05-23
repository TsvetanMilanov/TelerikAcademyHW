var a;
var b;
var c;

var aValues = [5, -2, -2, 0, -1];
var bValues = [2, -2, 4, -2.5, -0.5];
var cValues = [2, 1, 3, 4, -5.1];

for (var i = 0; i < aValues.length; i++) {
    a = aValues[i];
    b = bValues[i];
    c = cValues[i];

    if (a * b * c > 0) {
        console.log('+');
        document.write('<p>+</p>');
    } else if (a * b * c < 0) {
        console.log('-');
        document.write('<p>-</p>');
    } else {
        console.log('0');
        document.write('<p>0</p>');
    }
}