function is_prime(num) {
    for (var i = 2; i < num / 2; i++) {
        if (num % i == 0) {
            return false;
        }
    }
    return true;
}

//console.log(is_prime(12));

function is_circular_prime(num) {
    var str = num.toString().split('');
    if (str.length == 1) {
        return true;
    }
    //console.log("input:",str);
    var num_circular_primes = 0;
    for (var x = 0; x < str.length - 1; x++) {
        var e = str.shift();
        str = str.concat(e);
        var str2 = str.toString();
        //console.log("rotate:",str2);
        var n = parseInt(str2.replace(/,/g, ''));
        //console.log("num:", n);
        if (is_prime(n)) {
            //console.log("prime:", n);
            num_circular_primes++;
        } else {
            break;
        }
    }
    //console.log("num:",num_circular_primes);
    if (num_circular_primes == str.length - 1) {
        return true;
    }
    return false;
}

//console.log(is_circular_prime(719));
//console.log(is_circular_prime(71));
//console.log(is_circular_prime(73));
//console.log(is_circular_prime(97));
//console.log(is_circular_prime(23));

var total_primes = 0;
var total = 0;
for (var i = 2; i < 1000000; i++) {
    if (is_prime(i)) {
        total_primes++;
        if (is_circular_prime(i)) {
            console.log('circular prime:', i);
            total++;
        }
    }
}
console.log("total primes", total_primes);
console.log("total=", total); //answer is 55...why?