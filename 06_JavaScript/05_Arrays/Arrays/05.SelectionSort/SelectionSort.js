var i,
    j,
    iMin,
    temp,
    a = [3, 2, 3, 4, 2, 2, 4];

for (j = 0; j < a.length; j++) {
    iMin = j;
    for (i = j + 1; i < a.length; i++) {
        if (a[i] < a[iMin]) {
            iMin = i;
        }
    }

    if (iMin != j) {
        temp = a[j];
        a[j] = a[iMin];
        a[iMin] = temp;
    }
}

console.log(a);