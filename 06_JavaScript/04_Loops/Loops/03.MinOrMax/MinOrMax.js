var button = document.getElementById('confirm');

button.onclick = function () {
    var input = document.getElementById('sequence');
    var sequence = input.value.split(" ");
    var max = Number.MIN_VALUE;
    var min = Number.MAX_VALUE;

    for (var i = 0; i <= sequence.length; i++) {
        var currentNumber = parseInt(sequence[i]);

        if (currentNumber > max) {
            max = currentNumber;
        }

        if (currentNumber < min) {
            min = currentNumber;
        }
    }

    console.log('Min: ' + min + ' Max: ' + max);
    document.write('<p>' + 'Min: ' + min + ' Max: ' + max + '</p>');
};