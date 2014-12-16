
//Champernowne's constant

exports.run = function () {

    var result = 1;
    var resultStr = result.toString();
    while (resultStr.length < 1000000) {
        result++;
       resultStr += result;
    }
    console.log(parseInt(resultStr[0]) * 
                parseInt(resultStr[9]) * 
                parseInt(resultStr[99]) * 
                parseInt(resultStr[999]) * 
                parseInt(resultStr[9999]) * 
                parseInt(resultStr[99999]) * 
                parseInt(resultStr[999999]));
};