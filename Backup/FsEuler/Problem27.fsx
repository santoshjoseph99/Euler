
#load "Util.fsx"

let quadratic a b n =
    (n*n) + a*n + b

let calc_consec_primes a b =
    let mutable n = 0
    let mutable loop = true
    while loop do
        let v = quadratic a b n
        if v > 0 then
            if Util.is_prime v then n <- n + 1
            else loop <- false
        else
            loop <- false
    n 

//let example = calc_consec_primes 1 41
//printfn "example %d=" example

let mutable max_consec_primes = 0
let mutable max = 0
let mutable a' = 0
let mutable b' = 0
for a in -999..1..999 do
    for b in -999..1..999 do
            let consec_primes = calc_consec_primes a b
            //printfn "%d %d %d" a b consec_primes
            if consec_primes > max_consec_primes then
               max_consec_primes <- consec_primes
               max <- a * b 
               a' <- a
               b' <- b
printfn "answer = %d %d %d %d" max max_consec_primes a' b'

//let z = seq {
//    for a in -999..1..999 do
//        for b in -999..1..999 do
//            let consec_primes = calc_consec_primes a b
//            printfn "%d %d %d" a b consec_primes
//            if consec_primes > max_consec_primes then
//                yield (consec_primes, a * b)
//} 
//let answer = z |> Seq.sortBy (fun e -> fst e) |> Seq.head
//printfn "answer = %A" answer

