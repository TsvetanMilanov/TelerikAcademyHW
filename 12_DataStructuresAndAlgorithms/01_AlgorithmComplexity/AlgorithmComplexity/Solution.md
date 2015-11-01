## First task:
O -> n*n

### Explanation:
For each element in the array the program will start one while cycle which condition for break is when the start is before the end. For each iteration the start will be increased or the end will be decreased and that's why the operations in the while cycle will be done n times => for each element the operations will be done n times -> n*n.

## Second task:
O -> n*m

### Explanation:
The worst case is O(n * m) because if all the numbers in the matrix are even and positive for each row -> n some operations will be done for each column -> m => n*m

## Third task:
O -> n*n

### Explanation:
The for each row in the matrix the operations in the for cycle will be done and since one of the operations is to call the function recursively the worst case scenario is n times n * m operations => n*n