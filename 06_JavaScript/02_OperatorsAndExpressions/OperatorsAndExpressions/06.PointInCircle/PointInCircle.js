var kX = 0;
var kY = 5;

var radius = kX + kY;

var valuesX = [0, -5, -4, 1.5, -4, 100, 0, 0.2, 0.9, 2];

var valuesY = [1, 0, 5, -3, -3.5, -30, 0, -0.8, -4.93, 2.655];

for (var i = 0; i < valuesX.length; i++) {
    if ((Math.sqrt(valuesX[i]*valuesX[i] + valuesY[i]*valuesY[i])) <= radius) {
        console.log(true);
        document.writeln(true+'\n');
    } else {
        console.log(false);
        document.writeln(false+'\n');
    }
}