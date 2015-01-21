﻿

var _ = require('underscore');

//Pentagonal numbers are generated by the formula, Pn=n(3n−1)/2

var p = [];

function getPentagonalNum(n) {
    return (n * (3 * n - 1)) / 2;
};

function isPentagonal(n) {
    if (n > p[p.length - 1]) {
        var i = p.length;
        while (true) {
            var num = getPentagonalNum(i);
            p.push(num);
            if (num > n) {
                break;
            }
            i++;
        }
    } 
    return _.contains(p, n);
}

exports.run = function () {
    
    for (var i = 1; i < 10000; i++) {
        p.push(getPentagonalNum(i));
    }
    var d = Number.MAX_VALUE;
    var x1 = 0;
    var x2 = 0;
   var max = p.length;
    for (var x = 0; x < max; x++) {
        for (var y = 0; y < max; y++) {
            if (x === y) {
               continue;
            }
           //console.log('checking', p[x], p[y]);
            var diff = Math.abs(p[x] - p[y]);
            if (isPentagonal(p[x] + p[y]) === true && isPentagonal(diff) === true) {
                if (diff < d) {
                    d = diff;
                    x1 = x;
                    x2 = y;
                   console.log('found low', d, x1, x2);
                }
            }
        }
    }
    
    console.log("smallest D=", d, x1, x2);
};