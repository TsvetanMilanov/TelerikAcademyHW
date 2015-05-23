var a;
var b;
var c;

var aValues = [2, -1, -0.5, 5];
var bValues = [5, 3, 4, 2];
var cValues = [-3, 0, -8, 8];

for (var i = 0; i < aValues.length; i++) {
    a = aValues[i];
    b = bValues[i];
    c = cValues[i];

    var discriminant = 0;
    discriminant = b * b - (4 * a * c);

    if (discriminant < 0) {
        console.log('no real roots');
        document.write('<p>no real roots</p>');
        break;
    }

    var sqrtDiscriminant = 0;
    sqrtDiscriminant = Math.sqrt(discriminant);
    var x1 = (-b - sqrtDiscriminant) / (2 * a);
    var x2 = (-b + sqrtDiscriminant) / (2 * a);

    console.log('x1 = ' + x1 + '; x2 = ' + x2);
    document.write('<p>' + 'x1 = ' + x1 + '; x2 = ' + x2 + '</p>');
}