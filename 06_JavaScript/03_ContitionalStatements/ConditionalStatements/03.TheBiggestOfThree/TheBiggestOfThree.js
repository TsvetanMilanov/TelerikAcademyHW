var a;
var b;
var c;

var aValues = [5, -2, -2, 0, -0.1];
var bValues = [2, -2, 4, -2.5, -0.5];
var cValues = [2, 1, 3, 5, -1.1];

for (var i = 0; i < aValues.length; i++) {
    a = aValues[i];
    b = bValues[i];
    c = cValues[i];

    if (a > b && a > c) {
        console.log(a);
        document.write('<p>' + a + '</p>');
    } else if(b > a && b > c) {
        console.log(b);
        document.write('<p>' + b + '</p>');
    } else if(c > a && c > b) {
        console.log(c);
        document.write('<p>' + c + '</p>');
    }
}