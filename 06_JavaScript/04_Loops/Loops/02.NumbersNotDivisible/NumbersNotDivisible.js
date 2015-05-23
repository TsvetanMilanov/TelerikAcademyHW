var button = document.getElementById('confirm');

button.onclick = function () {
    var input = document.getElementById('valueOfN');
    var n = parseInt(input.value);

    for (var i = 1; i <= n; i++) {
        var dividedByThree = i % 3;
        var dividedBySeven = i % 7;

        if (dividedByThree == 0 && dividedBySeven == 0) {
            continue;
        }

        console.log(i);
        document.writeln('<p>' + i + '</p>');
    }
};