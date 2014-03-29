

//gcf function
function euclid_helper(a, b) {
    var q = a / b;
    var r = a % b;
    //console.log(q, b, r);
    if (r == 0) {
        return b;
    }
    return euclid_helper(b, r);
}

function euclid(a, b) {
    if (b == 0) {
        return 1;
    }
    return euclid_helper(a, b);
}

//console.log(euclid(48, 18));
//console.log(euclid(100, 50));
//console.log(euclid(144, 12));
//console.log(euclid(12, 144));
//console.log(euclid(50,100));
//console.log(euclid(18,48));
//console.log(euclid(49, 98));
//console.log(euclid(12, 20));

function reduce_fraction(n, d) {
    var divisor = euclid(n, d);
    return {
        num: n / divisor,
        den: d / divisor
    };
}

function cancel_fraction(n, d) {
    //console.log("fraction:",n, d);
    var n1 = n.toString()[0];
    var n2 = n.toString()[1];
    var d1 = d.toString()[0];
    var d2 = d.toString()[1];
    var r = reduce_fraction(n, d);
    //console.log("reduced:", r.num, r.den, n1, n2, d1, d2);

    if (n1 === d1) {
        var r2 = reduce_fraction(n2, d2);
        if (r.den == parseInt(d2) && r.num === parseFloat(n2) ||
            r2.den == r.den && r2.num == r.num) {
            console.log(n, d, r);
            return r;
        }
    } else if (n1 === d2) {
        var r2 = reduce_fraction(n2, d1);
        if (r.den == parseInt(d1) && r.num === parseFloat(n2) ||
            r2.den == r.den && r2.num == r.num) {
            console.log(n, d, r);
            return r;
        }
    } else if (n2 === d1) {
        var r2 = reduce_fraction(n1, d2);
        //console.log("r2:", r2);
        if (r.den == parseInt(d2) && r.num === parseFloat(n1) ||
            r2.den == r.den && r2.num == r.num) {
            console.log(n, d, r);
            return r;
        }
    } else if (n2 === d2) {
        var r2 = reduce_fraction(n1, d1);
        if (r.den == parseInt(d1) && r.num === parseFloat(n1) ||
            r2.den == r.den && r2.num == r.num) {
            console.log(n, d, r);
            return r;
        }
    }

    return {
        num: 0,
        den: 0
    };
}
//cancel_fraction(12,20);

var results = [];
for (var n = 10; n < 100; n++) {
    for (var d = 10; d < 100; d++) {
        //console.log(n, d);
        if (n % 10 === 0 && d % 10 === 0) {
            continue;
        }
        if (n < d) {
            var result = cancel_fraction(n, d);
            if (result.num !== 0 && result.den !== 0) {
                results.push(result);
            }
        }
    }
}

var final_num = 1;
var final_den = 1;
for (var i = 0; i < results.length; i++) {
    final_num *= results[i].num;
    final_den *= results[i].den;
}

var final_fraction = reduce_fraction(final_num, final_den);

console.log("den: ", final_fraction.den);
