
var readline = require('readline');
var problem = require('./problems/problem42');

var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

problem.run();

rl.question("Press return to end", function (answer) {
    rl.close();
});