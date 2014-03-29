

function ReadData2(filename) {
    var lines = fs.readFileSync(filename).toString().split(/r?\n/);
    var lines2 = [];
    for (var x = 0; x < lines.length; x++) {
        var lines3 = lines[x].split(' ');
        lines2.push(_.map(lines3, function (e) {
            return parseInt(e);
        }));
    }
    console.log(lines2);
    return lines2;
}

function EvalData(data) {
    for (var x = data.length - 2; x > 0; x--) {
        var current = data[x];
        var next = data[x + 1];
        //console.log(current,next);
        for (var y = 0; y < current.length; y++) {
            var lv = next[y];
            var rv = next[y + 1];
            current[y] = current[y] + (lv > rv ? lv : rv);
        }
    }
    return data[0][0] + (data[1][0] > data[1][1] ? data[1][0] : data[1][1]);
}

var d = ReadData2("triangle.txt");
var t = EvalData(d);
console.log(t);
