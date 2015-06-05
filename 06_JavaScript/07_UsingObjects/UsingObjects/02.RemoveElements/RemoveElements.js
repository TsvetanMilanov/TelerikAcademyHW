Array.prototype.remove = function (itemToRemove) {
    var i,
        len = this.length;

    for (i = 0; i < len; i += 1) {
        if (this[i] === itemToRemove) {
            this.splice(i, 1);
        }
    }
};

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

arr.remove(1);

console.log(arr);