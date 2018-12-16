Array.prototype.clearAll = function () {
    this.length = 0
}

var numbers = [1, 2, 3, 4, 5]
console.log('numbers', numbers)

numbers.clearAll();
console.log('numbers', numbers)