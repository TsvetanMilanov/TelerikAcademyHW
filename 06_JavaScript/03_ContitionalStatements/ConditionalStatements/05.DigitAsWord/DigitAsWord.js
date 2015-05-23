var digit;
var testDigits = [2, 1, 0, 5, -0.1, 'hi', 9, 10];

for (var i = 0; i < testDigits.length; i++) {
    digit = testDigits[i];

    switch (digit) {
        case 0:
            console.log('zero');
            document.write('<p>zero</p>')
            break;
        case 1:
            console.log('one');
            document.write('<p>one</p>')
            break;
        case 2:
            console.log('two');
            document.write('<p>two</p>')
            break;
        case 3:
            console.log('three');
            document.write('<p>three</p>')
            break;
        case 4:
            console.log('four');
            document.write('<p>four</p>')
            break;
        case 5:
            console.log('five');
            document.write('<p>five</p>')
            break;
        case 6:
            console.log('six');
            document.write('<p>six</p>')
            break;
        case 7:
            console.log('seven');
            document.write('<p>seven</p>')
            break;
        case 8:
            console.log('eight');
            document.write('<p>eight</p>')
            break;
        case 9:
            console.log('nine');
            document.write('<p>nine</p>')
            break;
        default:
            console.log('not a digit');
            document.write('<p>not a digit</p>')
            break;
    }
}