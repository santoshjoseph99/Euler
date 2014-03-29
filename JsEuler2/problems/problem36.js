function is_palindrome(str) {
    var array = str.split('');
    if (array.length === 1) {
        return true;
    }
    for (var s = 0, e = array.length - 1; s < array.length / 2; s++, e--) {
        //console.log(array[s], array[e]);
        if (array[s] !== array[e]) {
            return false;
        }
    }
    return true;
}
/*
var test = 16;
console.log(is_palindrome(test.toString()));
console.log(is_palindrome(test.toString(2)));
*/
var total = 0;
for (var d = 1; d < 1000000; d++) {
    if (is_palindrome(d.toString()) == true &&
        is_palindrome(d.toString(2)) == true) {
        console.log("match:", d);
        total += d;
    }
}
console.log("total:", total);