var a;
var b;
var c;

var aValues = [5, -2, -2, 0, -0.1, 10, 1];
var bValues = [1, -2, 4, -2.5, -0.5, 20, 1];
var cValues = [2, 1, 3, 5, -1.1, 30, 1];

for (var i = 0; i < aValues.length; i++) {
    a = aValues[i];
    b = bValues[i];
    c = cValues[i];

    if (a >= b && a >= c) {
        if (b >= c) {
            console.log(a + ' ' + ' ' + b + ' ' + c);
            document.write('<p>' + a + ' ' + ' ' + b + ' ' + c + '</p>');
        } else {
            console.log(a + ' ' + ' ' + c + ' ' + b);
            document.write('<p>' + a + ' ' + c + ' ' + b + '</p>');
        }
    } else if (b >= a && b >= c) {
        if (a >= c) {
            console.log(b + ' ' + ' ' + a + ' ' + c);
            document.write('<p>' + b + ' ' + a + ' ' + c + '</p>');
        } else {
            console.log(b + ' ' + c + ' ' + a);
            document.write('<p>' + b + ' ' + c + ' ' + a + '</p>');
        }
    } else if (c >= a && c >= b) {
        if (a >= b) {
            console.log(c + ' ' + a + ' ' + b);
            document.write('<p>' + c + ' ' + a + ' ' + b + '</p>');
        } else {
            console.log(c + ' ' + + b + ' ' + a);
            document.write('<p>' + c + ' ' + b + ' ' + a + '</p>');
        }
    }
}