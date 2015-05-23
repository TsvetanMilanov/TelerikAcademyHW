var button = document.getElementById('confirm');

button.onclick = function () {
    var input = document.getElementById('valueOfN');
    var n = parseInt(input.value);

    for (var i = 1; i <= n; i++) {
        console.log(i);
        document.writeln('<p>' + i + '</p>');
    }
};