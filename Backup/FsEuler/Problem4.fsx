
//Largest palindrome product of 2 3-digit numbers
let rec reverse_helper list rlist =
    match list with
    | [] -> rlist
    | h::tail -> reverse_helper tail [h] @ rlist

let rec reverse list =
    reverse_helper list []

let rec palindrome_helper (list1:'a list) (list2:'a list) = 
   match list1 with
   | [] -> true
   | _ ->
    if list1.Head = list2.Head then
        palindrome_helper list1.Tail list2.Tail
    else
        false
    
let palindrome list =
    let rlist = reverse list
    palindrome_helper list rlist

//[<Literal>]
//let max = 99
//
//let rec largest_palindrome_product1 a b max num =
//    match a with
//    | 999 -> num
//    | _ ->  
//        let str = (a*b).ToString() |> List.ofSeq
//        if palindrome str then 
//            largest_palindrome_product1 (a+1) b max (a*b)
//        else
//            largest_palindrome_product1 (a+1) b max num
//
//let largest_palindrome_product a b max =
//    let rec largest_palindrome_product_ a b max num =
//        //printfn "%d %d %d %d" a b max num
//        let current = largest_palindrome_product1 a b max num
//        //printfn "%d %d" current num
//        match b with
//        | 999 -> if current > num then current else num
//        | _ ->
//            if current > num then
//                largest_palindrome_product_ a (b+1) max current
//            else
//                largest_palindrome_product_ a (b+1) max num
//    largest_palindrome_product_ a b max 0
//
//let result = largest_palindrome_product 99 99 999
//printfn "%d" result

let largest_palindrome_product_seq =
    seq {
            for x in 100..999 do
                for y in 100..999 do
                    let str = (x*y).ToString() |> List.ofSeq
                    if palindrome str then yield (x*y)
        }
    |> Seq.max

printfn "%d" largest_palindrome_product_seq