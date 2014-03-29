var numbers = [1, 59, 12, 43, 4, 58, 5, 13, 46, 3, 6];

var results = [];
var old = numbers[0];
var index = 0;
results.push([old]);
numbers = numbers.slice(1);
for (var i = 0; i < numbers.length; i++) {
    var num = numbers[i];
    var pushed = false;
    for (var x = 0; x < results.length; x++) {
        var result = results[x];
        if (consecutive_run(num, result)) {
            result.push(num);
            result.sort();
            pushed = true;
            break;
        }
    }
    if (pushed == false) {
        results.push([num]);
    }
}



for (var result in results) {
    console.log(result.join());
}

function consecutive_run(num, array) {
    var newArray = array.slice();
    newArray.push(num);
    newArray.sort();
    var current = newArray[0];
    for (var i = 1; i < newArray.length; i++) {
        if ((current + 1) != newArray[i]) {
            return false;
        }
        current = newArray[i];
    }
    return true;
}