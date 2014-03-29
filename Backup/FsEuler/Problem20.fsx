
module Problem20 =
    open System
    let rec factorial (n: bigint) (total: bigint) =
        if n = 0I then total
        else
            //printfn "%A" (total*n)
            factorial (n-1I) (total*n)
            
    let factorial_digit_sum start =
        let result = factorial start 1I
        //printfn "%A" result
        result.ToString() 
        |> Seq.toList 
        |> Seq.map (fun e -> Int32.Parse(e.ToString())) 
        |> Seq.sum

    let result = factorial_digit_sum 100I
    printfn "%d" result
