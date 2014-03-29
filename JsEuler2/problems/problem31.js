var count = 0;

for (var a = 0; a < 2; a++) {
    for (var b = 0; b < 3; b++) {
        for (var c = 0; c < 5; c++) {
            for (var d = 0; d < 11; d++) {
                for (var e = 0; e < 21; e++) {
                    for (var f = 0; f < 41; f++) {
                        for (var g = 0; g < 101; g++) {
                            for (var h = 0; h < 201; h++) {
                                if ((200 * a) + (100 * b) + (50 * c) + (20 * d) + (10 * e) +
                                     (5 * f) + (2 * g) + (1 * h) == 200) {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

console.log(count);
