var number;
var digits = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
var twoDigitNumbers = ['empty', 'ten', ' twent', ' thirt', ' fort', ' fift', ' sixt', ' sevent', ' eight', ' ninet'];

var testNumbers = [0, 9, 10, 12, 19, 25, 98, 98, 273, 400, 501, 617, 711, 999];

for (var i = 0; i < testNumbers.length; i++) {
    number = testNumbers[i];
    var tempNumber = number;
    var countOfDigits = 1;

    while (((tempNumber / 10) | 0) != 0) {
        countOfDigits += 1;
        tempNumber /= 10 | 0;
    }

    switch (countOfDigits) {
        case 1:
            console.log(digits[number]);
            document.write('<p style="text-transform: capitalize;">' + digits[number] + '</p>');
            break;
        case 2:
            var decs = (number / 10) | 0;
            var ones = number % 10;

            switch (decs) {
                case 1:
                    switch (ones) {
                        case 0:
                            console.log(twoDigitNumbers[ones + 1]);
                            document.write('<p style="text-transform: capitalize;">' + twoDigitNumbers[ones + 1] + '</p>');
                            break;
                        case 1:
                            console.log('Eleven');
                            document.write('<p style="text-transform: capitalize;"> Eleven </p>');
                            break;
                        case 2:
                            console.log('Twelve');
                            document.write('<p style="text-transform: capitalize;"> Twelve </p>');
                            break;
                        default:
                            console.log(twoDigitNumbers[ones]+ 'een');
                            document.write('<p style="text-transform: capitalize;">' + twoDigitNumbers[ones] + 'een' + '</p>');
                            break;
                    }
                    break;
                default:
                    console.log(twoDigitNumbers[decs]+ 'y ');
                    document.write('<p style="text-transform: capitalize;">' + twoDigitNumbers[decs] + 'y ' + digits[ones] + '</p>')
                    break;
            }
            break;
        case 3:
            var hundreds = (number / 100) | 0;
            var decsForHundreds = ((number / 10) | 0) % 10;
            var onesForHundreds = number % 10;

            var hundredsAsWord = digits[hundreds] + ' hundred and ';

            switch (decsForHundreds) {
                case 0:
                    if (onesForHundreds == 0) {
                        console.log(digits[hundreds] + ' hundred');
                        document.write('<p style="text-transform: capitalize;">' + digits[hundreds] + ' hundred' + '</p>');
                    }
                    else {
                        console.log(hundredsAsWord + digits[onesForHundreds]);
                        document.write('<p style="text-transform: capitalize;">' + hundredsAsWord + digits[onesForHundreds] + '</p>');
                    }
                    break;
                case 1:
                    switch (onesForHundreds) {
                        case 0:
                            console.log(hundredsAsWord + twoDigitNumbers[onesForHundreds]);
                            document.write('<p style="text-transform: capitalize;">' + hundredsAsWord + twoDigitNumbers[onesForHundreds] + '</p>');
                            break;
                        case 1:
                            console.log(hundredsAsWord + 'Eleven');
                            document.write('<p style="text-transform: capitalize;">' + hundredsAsWord + 'Eleven' + '</p>');
                            break;
                        case 2:
                            console.log(hundredsAsWord + 'Twelve');
                            document.write('<p style="text-transform: capitalize;">' + hundredsAsWord + 'Twelve' + '</p>');
                            break;
                        default:
                            if (onesForHundreds)
                                console.log(hundredsAsWord + twoDigitNumbers[onesForHundreds]);
                            document.write('<p style="text-transform: capitalize;">' + hundredsAsWord + twoDigitNumbers[onesForHundreds] + 'een' + '</p>');
                            break;
                    }
                    break;
                default:
                    console.log(hundredsAsWord + twoDigitNumbers[decsForHundreds] + 'y ' + digits[onesForHundreds]);
                    document.write('<p style="text-transform: capitalize;">' + hundredsAsWord + twoDigitNumbers[decsForHundreds] + 'y ' + digits[onesForHundreds] + '</p>');
                    break;

                    break;
            }
    }
}