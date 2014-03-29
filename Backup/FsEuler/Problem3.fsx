//largest prime factor
let rec is_prime_helper (x: int64) (n: int64) =
    match n with
    | 0L | 1L -> true
    | _ ->
        if x % n = 0L then
            false
        else
            is_prime_helper x (n - 1L)

let is_prime (x: int64) =
   let l = System.Math.Sqrt (float x)
   is_prime_helper x (int64 l) //(x/2L) 

//let rec largest_prime_factor_helper (x: int64) (factor: int64) (largest: int64) =
//    if System.Math.Sqrt( (float)x ) < (float)factor then
//        largest
//    else
//        if x % factor = 0L && is_prime factor then 
//            largest_prime_factor_helper x (factor+1L) factor
//        else
//            largest_prime_factor_helper x (factor+1L) largest
//
//let largest_prime_factor (x: int64) =
//    largest_prime_factor_helper x 1L 1L

let largest_prime_factor2 (num: int64) =
    let n = int64 (System.Math.Sqrt( (float)num ))
    seq {
         for x in 1L..n do
            if num % x = 0L && is_prime x then yield x
        }
    |> Seq.max

let result = largest_prime_factor2 600851475143L
printfn "%d" result
