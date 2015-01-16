

var fs = require('fs');
var _ = require('underscore');

exports.run = function () {

   var notTri = 0;
    var triangleCounts = [];
    function isTriangleWord(num) {
        if (triangleCounts.length > 0 && num < triangleCounts[triangleCounts.length-1]) {
            var found = _.find(triangleCounts, function (x) { return x === num; });
            if (found) {
               console.log("found in cache", num);
            } else {
               notTri++;
               //console.log('not in cache', num, triangleCounts.length, triangleCounts[triangleCounts.length-1]);
            }
            return found ? true : false;
        }
        var currentTriangleNum = triangleCounts.length === 0 ? 0 : triangleCounts[triangleCounts.length-1];
        while (true) {
            var n = triangleCounts.length + 1;
            currentTriangleNum = .5 * n * (n + 1);
            triangleCounts.push(currentTriangleNum);
            if (currentTriangleNum === num) {
               //console.log('found', num);
                return true;
            }
            if (currentTriangleNum > num) {
                break;
            }
        }
       notTri++;
       console.log('is not tri', num);
        return false;
    }
    
    function generateTriangleNumbers() {
       for (var t = 1; t < 100; t++) {
          triangleCounts.push(.5 * t * (t + 1));
       }
    }
    
    function isTriangleWord2(num2) {
       return _.find(triangleCounts, function(x) { return x === num2; }) ? true : false;
    }
    
    function getWordCount(w) {
        var chars = w.split('');
        var count = 0;
        for (var c = 0; c < chars.length; c++) {
            count += alphabet[chars[c]];
        }
       console.log(w, count);
        return count;
    }
    
    var alphabet = {
        'A': 1, 'B': 2, 'C': 3, 'D': 4, 'E': 5, 'F': 6, 'G': 7, 'H': 8, 'I': 9, 'J': 10, 'K': 11, 'L': 12, 'M': 13, 'N': 14, 'O': 15, 
        'P': 16, 'Q': 17, 'R': 18, 'S': 19, 'T': 20, 'U': 21, 'V': 22, 'W': 23, 'X': 24, 'Y': 25, 'Z': 26
    };
   //generateTriangleNumbers();
    var triangleWords = 0;
    var file = fs.readFileSync('problems/problem42.txt').toString();
    var words = file.split(',');
    for (var i = 0; i < words.length; i++) {
        var word = words[i].replace(/\"/g, "");
       //console.log('checking', word);
        if (isTriangleWord(getWordCount(word))) {
            triangleWords++;
        }
    }
   console.log(triangleCounts);
    console.log('triangle words:', triangleWords, notTri);
}