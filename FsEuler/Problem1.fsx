
//sum of Multiples of 2 numbers below x number
let is_multiple_of num mul =
    if num % mul = 0 then true else false

//let rec multiples2 x mul1 mul2 list =
//    match x with
//    | 0 -> list
//    | _ ->
//        let b1 = is_multiple_of x mul1
//        let b2 = is_multiple_of x mul2
//        if b1 && b2 then
//            multiples2 (x-1) mul1 mul2 (x::list)
//        else if b1 then
//            multiples2 (x-1) mul1 mul2 (x::list)
//        else if b2 then
//            multiples2 (x-1) mul1 mul2 (x::list)
//        else
//            multiples2 (x-1) mul1 mul2 list
//
//let sum_multiples2 x mul1 mul2 =
//    multiples2 x mul1 mul2 [] 
//    |> List.sum

let sum_multiples_below mul1 mul2 max =
    seq {
         for x in 1..max do
            if is_multiple_of x mul1 && is_multiple_of x mul2 then yield x
            else if is_multiple_of x mul1 then yield x
            else if is_multiple_of x mul2 then yield x
        }
    |> Seq.sum

let result = sum_multiples_below 3 5 1000
printfn "%d" result