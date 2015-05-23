var a = 4.5;
var b = 5.5;

if (a > b) {
    a = a * b;
    b = a / b;
    a = a / b;
}

console.log(a + ' ' + b);
document.write(a + ' ' + b);