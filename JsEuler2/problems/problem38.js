
// Pandigital multiples

var _ = require('underscore');

function isPandigital(num) {
    var str = num.toString();
    var nums = str.split('');
    var elements = _.uniq(nums);
    if (elements.length === 9) {
        var intElements = _.map(elements, function (e) { return parseInt(e); });
        var sorted = _.sortBy(intElements, function (e) { return e; });
        for (var i = 1; i <= 9; i++) {
            if (sorted[i-1] != i) {
                return false;
            }
        }
        return true;
    }
    return false;
}

function hasNineDigits(num) {
    return num.toString().length == 9;
}

function moreThenNineDigits(num) {
    return num.toString().length > 9;
}

function concatNums(a) {
    var num = '';
    for (var i = 0; i < a.length; i++) {
        num += a[i];
    }
    return parseInt(num);
}

exports.run = function () {
   var largest = 0;
    for (var n = 192; n < 99999; n++) {
        var products = [n * 1];
        for (var x = 2; x < 20; x++) {
            products.push(x * n);
            var num = concatNums(products);
            if (moreThenNineDigits(num)) {
                break;
            }
            if (hasNineDigits(num)) {
                if (isPandigital(num)) {
                    console.log('pandigital number:', num, n, x);
                    if (num > largest) {
                       largest = num;
                    }
                    break;
                }
            }
        }
    }
   console.log('largest', largest);
};
