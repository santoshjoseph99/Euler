
let sum_spiral_diagonals2 max =
   let mutable loop = 3
   let mutable total = 1+3+5+7+9 //25
   let mutable n = 9
   printfn "%d %d %d"  loop total n
   while loop < max do
        n <- n + 1 //start
        n <- n + loop
        total <- total + n //bottom right
        printfn "%d" n
        n <- n + loop + 1
        total <- total + n //bottom left
        printfn "%d" n
        n <- n + loop + 1
        total <- total + n //top left
        printfn "%d" n
        n <- n + loop + 1
        total <- total + n //top right
        printfn "%d" n

        loop <- loop + 2
   total

let answer = sum_spiral_diagonals2 1001

printfn "answer=%d" answer

