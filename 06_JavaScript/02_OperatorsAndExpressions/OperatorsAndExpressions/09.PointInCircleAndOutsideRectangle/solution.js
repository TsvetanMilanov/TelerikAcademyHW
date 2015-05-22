var valuesX = [1, 2.5, 0, 2.5, 2, 4, 2.5, 2, 1, -100];
var valuesY = [2, 2, 1, 1, 0, 0, 1.5, 1.5, 2.5, -100];

var kX = 1;
var kY = 1;
var kRadius = 3;

var rTop = 1;
var rLeft = -1;
var rWidth = 6;
var rHeight = 2;

//console.log(check(valuesX, valuesY) ? 'yes' : 'false');

function check(x, y) {
    //inside rectangle
    if (((x >= rLeft) && (x <= (rLeft + rWidth))) && ((y <= rTop) && (y >= (rTop - rHeight)))) {
        return false;
    }

    //inside circle:
    if (Math.sqrt(((x - kX) * (x - kX)) + ((y - kY) * (y - kY))) <= kRadius) {
        console.log(Math.sqrt(((x - kX) * (x - kX)) + ((y - kY) * (y - kY))));
        return true;
    }

    return false;
}

for (var i = 0; i < valuesX.length; i++) {
    console.log(check(valuesX[i], valuesY[i]) ? 'yes' : 'no');
}