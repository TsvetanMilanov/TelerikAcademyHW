var a;
var b;
var c;
var d;
var e;

var aValues = [5, -2, -2, 0, -3];
var bValues = [2, -22, 4, -2.5, -0.5];
var cValues = [2, 1, 3, 0, -1.1];
var dValues = [4, 0, 2, 5, -2];
var eValues = [1, 0, 0, 5, -0.1];


for (var i = 0; i < aValues.length; i++) {
    a = aValues[i];
    b = bValues[i];
    c = cValues[i];
    d = dValues[i];
    e = eValues[i];

    if (a >= b && a >= c && a >= d && a >= e) {
        console.log(a);
        document.write('<p>' + a + '</p>');
    } else if (b >= a && b >= c && b >= d && b >= e) {
        console.log(b);
        document.write('<p>' + b + '</p>');
    } else if (c >= a && c >= b && c >= d && c >= e) {
        console.log(c);
        document.write('<p>' + c + '</p>');
    } else if (d >= a && d >= b && d >= c && d >= e) {
        console.log(d);
        document.write('<p>' + d + '</p>');
    } else if (e >= a && e >= e && e >= d && e >= c) {
        console.log(e);
        document.write('<p>' + e + '</p>');
    }
}