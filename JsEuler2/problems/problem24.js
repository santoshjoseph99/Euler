function next(a) {
    var k = 0;
    for (var i = 0; i < a.length - 1; i++) {
        if (a[k] < a[k + 1]) {
            k++;
        }
    }
    k = k - 1;
    console.log("k=%d", k);

    if (k == 0) {
        return a;
    }
    var l = 0;
    for (l = 0; a[k] > a[l]; l++) { }
    l = l + 1;
    console.log("l=%d", l);

    swap(a, k, l);
    console.log(a);

    reverse(a, k + 1);
    console.log(a);
    return a;
}

function reverse(a, i) {
    console.log("reverse: from i=%d", i);
    var t = a.slice(0, i);
    var x = a.slice(i);
    var r = x.reverse();
    return t.concat(r);
}

function swap(a, k, l) {
    console.log("swap: k=%d, l=%d", k, l);
    var temp = a[k];
    a[k] = a[l];
    a[l] = temp;
}


var a1 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

var a2 = [1, 2, 3, 4];

//console.log(reverse(a1, 9));

for (var x = 0; x < 24; x++) {
    a2 = next(a2);
    console.log("i=", a2);
}



/*
swap(a1, 5, 6);
console.log(a1);
swap(a1, 0, 9);
console.log(a1);
swap(a1, 3, 3);
console.log(a1);
swap(a1, 0, 9);
swap(a1, 5, 6);
console.log(a1);

console.log(reverse(a1, 3));
console.log(reverse(a1, 7));
console.log(reverse(a1, 0));

var tree = {};

var tree = new function(){};
*/