// Node.js entry point

var readline = require('readline');
var fs = require('fs');
var _ = require('underscore');

var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function is_prime(num) {
    console.log(num);
    if (num == 1)
        return false;
    for (var i = 2; i < num / 2; i++) {
        console.log("-",i);
        if (num % i == 0) {
            return false;
        }
    }
    return true;
}

function is_truncatable_prime(num) {
    var array = num.toString().split('');
    for (var l = 0; l < array.length; l++) {
        array.shift();
        console.log("l:",array);
        if (!is_prime(parseInt(array.join("")))) {
            return false;
        }
    }

    array = num.toString().split('');
    for (var r = 0; r < array.length; r++) {
        array.pop();
        console.log("r:",array);
        if (!is_prime(parseInt(array.join("")))) {
            return false;
        }
    }
    return true;
}

console.log(is_truncatable_prime(43));
//console.log(is_truncatable_prime(3797));
//console.log(is_truncatable_prime(23));
/*
var max_primes = 0;
var total = 0;
for (var x = 8; max_primes < 50; x++) {
    if (is_prime(x)) {
        if (is_truncatable_prime(x)) {
            console.log(x);
            total += x;
            max_primes++;
        }
    }
}
console.log("total:", total);
*/
rl.close();
//rl.question("Press return to end", function (answer) {
//    rl.close();
//});