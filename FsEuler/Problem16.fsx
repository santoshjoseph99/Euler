module Problem16 =
    open System

    let rec exp (num: bigint) times (result: bigint) =
        if times = 0 then result
        else exp num (times-1) (result*num)

    let get_sum_of_digits num exponent =
        let result = exp num exponent 1I
        result.ToString()
        |> Seq.toList 
        |> Seq.map (fun e -> Int32.Parse(e.ToString())) 
        |> Seq.sum
