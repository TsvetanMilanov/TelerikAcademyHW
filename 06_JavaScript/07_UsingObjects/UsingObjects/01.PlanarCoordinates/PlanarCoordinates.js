var firstTestPoint,
    secondTestPoint,
    firstTestLine,
    secondTestLine,
    thirdTestLine;

function Point(inputX, inputY) {
    this.x = inputX;
    this.y = inputY;
}

firstTestPoint = new Point(0, 0),
    secondTestPoint = new Point(1, 1)

function calculateDistance(firstPoint, secondPoint) {
    return Math.sqrt(((secondPoint.x - firstPoint.x) * (secondPoint.x - firstPoint.x)) + ((secondPoint.y - firstPoint.y) * (secondPoint.y - firstPoint.y)));
}

function Line(firstPoint, secondPoint) {
    this.start = firstPoint;
    this.end = secondPoint;
    this.length = calculateDistance(this.start, this.end);
}

console.log(calculateDistance(firstTestPoint, secondTestPoint));

firstTestLine = new Line(new Point(3, 2), new Point(3, 0));
secondTestLine = new Line(new Point(3, 0), new Point(4, 0));
thirdTestLine = new Line(new Point(3, 2), new Point(6, 0));

function checkIfFormTriangle(firstLine, secondLine, thirdLine) {
    if (firstLine.length > secondLine.length && firstLine.length > thirdLine.length) {
        if (firstLine.length > secondLine.length + thirdLine.length) {
            return true;
        } else {
            return false;
        }
    } else if (secondLine.length > firstLine.length && secondLine.length > thirdLine.length) {
        if (secondLine.length > firstLine.length + thirdLine.length) {
            return true;
        } else {
            return false;
        }
    } else if (thirdLine.length > firstLine.length && thirdLine.length > secondLine.length) {
        if (thirdLine.length > firstLine.length + secondLine.length) {
            return true;
        } else {
            return false;
        }
    }

    if (firstLine.length === secondLine.length && firstLine.length === secondLine.length) {
        return true;
    }
}

console.log(checkIfFormTriangle(firstTestLine, secondTestLine, thirdTestLine));