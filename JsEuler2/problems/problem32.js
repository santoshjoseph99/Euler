var products = {};
var total = 0;
for (var x = 1; x < 10000; x++) {
    for (var y = 1; y < 10000; y++) {
        var product = x * y;
        if (is_pandigital(x, y, product)) {
            if (products[product] == undefined) {
                total += product;
                products[product] = 1;
                console.log(x * y);
            }
        }
    }
}

console.log(total);

function is_pandigital(multiplicand, multipler, product) {
    var str = multiplicand.toString() + multipler.toString() + product.toString();
    if (str.length != 9)
        return false;
    var numbers_str = str.split('');
    var numbers = [];
    for (var i = 0; i < numbers_str.length; i++) {
        numbers.push(Number(numbers_str[i]));
    }
    numbers.sort();
    if (numbers[0] != 1)
        return false;
    var current = numbers[0];
    for (var i = 1; i < numbers.length; i++) {
        if ((current + 1) != numbers[i])
            return false;
        current = numbers[i];
    }
    return true;
}
