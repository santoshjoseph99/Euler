
//Integer right triangles

var _ = require('underscore');

function isRightTriangle(a, b, c) {
    return Math.pow(a, 2) + Math.pow(b, 2) === Math.pow(c, 2);
}

exports.run = function () {
    var largest = 0;
    var currentP = 0;
    for (var p = 3; p <= 1000; p++) {
        var currentSolutions = 0;
        var foundSolutions = [];
        for (var a = 1; a < p; a++) {
            for (var b = 1; b < p; b++) {
                for (var c = 1; c < p; c++) {
                    if (a + b + c != p) {
                        continue;
                    }
                    if (isRightTriangle(a, b, c)) {
                        var found = _.find(foundSolutions, function (e) { return _.isEqual(e, [a, b, c].sort()); });
                        if (found === undefined) {
                            foundSolutions.push([a, b, c].sort());
                            //console.log("found RT: a b c p:", a, b, c, p);
                            currentSolutions++;
                        }
                    }
                }
            }
        }
        if (currentSolutions > largest) {
            console.log("current max:", currentSolutions, p);
            largest = currentSolutions;
            currentP = p;
        }
    }
    console.log('max solutions:', largest, currentP);
};