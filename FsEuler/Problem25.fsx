
#r "MsCorLib.dll"

open System.Collections.Generic

let memoize(f) =
    let cache = new Dictionary<_, _>()
    (fun x ->
            match cache.TryGetValue(x) with
            | true, v -> v
            | _ -> let v = f(x)
                   cache.Add(x, v)
                   v)

let rec fib2 = memoize(fun x -> 
                        if x <= 2 then 1I else fib2 (x-1) + fib2 (x-2))

//let rec fib (n: bigint) =
//    if n = 1I || n = 2I then 1I
//    else fib (n-1I) + fib (n-2I)
//
//let rec fib_t n = 
//    let rec fib_t' n x =
//        if n = 1 || n = 2 then x+1
//        else fib_t' (n-1) (x+1) + fib_t' (n-2) (x+1)
//    fib_t' n 0

let fib_get_1000_digit =
    let rec fib_get x l =
        if l >= 1000 then x
        else
            let n = fib2 x
            //printfn "%A %A %d" n x l
            let l' = n.ToString().Length
            fib_get (x+1) l'
    fib_get 1 0

printfn "%A" (fib2 8)

