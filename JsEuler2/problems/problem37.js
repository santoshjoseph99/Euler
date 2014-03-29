
var fs = require('fs');
var _ = require('underscore');

function is_prime(num) {
    if (num == 1)
        return false;
    for (var i = 2; i <= Math.sqrt(num); i++) {
        //console.log("-",i);
        if (num % i == 0) {
            return false;
        }
    }
    return true;
}

function is_truncatable_prime(num) {
    var array = num.toString().split('');
    var len = array.length;
    for (var l = 0; l < len; l++) {
        array.shift();
        //console.log("l:",array);
        if (!is_prime(parseInt(array.join("")))) {
            return false;
        }
    }

    array = num.toString().split('');
    for (var r = 0; r < len; r++) {
        array.pop();
        //console.log("r:",array);
        if (!is_prime(parseInt(array.join("")))) {
            return false;
        }
    }
    return true;
}
/*
console.log(is_prime(97));
console.log(is_prime(7));
console.log(is_prime(797));
console.log(is_prime(3797));
console.log(is_prime(379));
console.log(is_prime(37));
console.log(is_prime(3));
*/
//console.log(is_truncatable_prime(3797));
//console.log(is_truncatable_prime(43));
//console.log(is_truncatable_prime(23));
exports.run = function (){
var max_primes = 0;
var total = 0;
for (var x = 8; max_primes < 11; x++) {
    if (is_prime(x)) {
        //console.log("prime:",x);
        if (is_truncatable_prime(x)) {
            total += x;
            console.log("truncatable prime:",x,total);
            max_primes++;
        }
    }
}
console.log("total:", total);
}




