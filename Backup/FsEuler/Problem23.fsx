
#r "System.dll"

open System.Diagnostics

let get_divisors_sum n =
    seq { for x in 1..(n/2) do
            if n % x = 0 then yield x }
    |> Seq.sum

let is_abundant_number n =
    if get_divisors_sum(n) > n then 
        //printfn "abundant number=%d" n
        true 
    else false

let get_abundant_numbers n =
    seq { for x in 1..n do
            if is_abundant_number x then yield x }

let get_sums_of_abundant_numbers n =
    let ab = get_abundant_numbers n
    let l = Seq.toArray ab
    Array.Parallel.collect (fun e -> 
                      Array.map (fun e' -> e+e') l) l
    |> Seq.distinct
    |> Seq.toList
    
let get_sum_of_numbers_which_are_not_sums_of_abundant_numbers n =
    let sw = Stopwatch()
    sw.Start()
    let s = get_sums_of_abundant_numbers n
    let s' = Array.Parallel.choose (fun e -> if List.tryFind (fun e' -> e' = e) s = None then Some(e) else None) [|1..n|]
    printfn "%d" (Array.sum s')
//    let a  = seq { for x in 1..n do
//                    if List.tryFind (fun e -> e = x) s = None then yield x }
//    printfn "%d" (Seq.sum a)
    sw.Stop()
    printfn "%A" sw.Elapsed

get_sum_of_numbers_which_are_not_sums_of_abundant_numbers 28123
