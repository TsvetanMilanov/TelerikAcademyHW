/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(numbers) {
	if (typeof numbers === 'undefined') {
		throw new Error();
	}
	
	if (Array.isArray(numbers) && (numbers.length === 0)) {
		return null;
	}
	
	return numbers.reduce(function(s, k) {
		if (isNaN(k)) {
			throw new Error();
		}
		
		return s += +k;
	}, 0);
}

console.log(sum([1,2]));

module.exports = sum;