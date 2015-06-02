var i,
    number = 5,
    start,
    end,
    mid,
    arr = [1, 2, 3, 4, 5, 6, 7];

start = 0;
end = arr.length;
mid = (end + start) / 2 | 0;

while (start < end) {
    if (arr[mid] === number) {
        console.log(mid);
        break;
    } else if (arr[mid] > number) {
        end = mid;
        mid = (end + start) / 2 | 0;
    } else {
        start = mid;
        mid = (end + start) / 2 | 0;
    }
}