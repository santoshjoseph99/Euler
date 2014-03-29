function factorial_helper(num, sum) {
    if (num == 0) {
        return sum;
    }
    return factorial_helper(num - 1, sum * num);
}

function factorial(num) {
    return factorial_helper(num, 1);
}
//console.log(factorial(20));
//console.log(Number.MAX_VALUE);

function sum_factorial(num) {
    var str = num.toString().split('');
    var sum = 0;
    for (var x = 0; x < str.length; x++) {
        sum += factorial(parseInt(str[x]));
    }
    return sum;
}

//console.log(sum_factorial(145));

var total = 0;
for (var i = 3; i < 10000000; i++) {
    if (sum_factorial(i) == i) {
        console.log(i);
        total += i;
    }
}
console.log("total=", total);
