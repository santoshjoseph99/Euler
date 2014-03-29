
module SmallestMultiple =
   
    let rec smallest_multiple_helper divisors x =
        let d = divisors |> List.fold (fun acc e -> acc + (x % e)) 0
        if d = 0 then x else smallest_multiple_helper divisors (x+1)

    let smallest_multiple list =
        smallest_multiple_helper list list.Length

    let result = smallest_multiple [1..20]
    printfn "%d" result

    let smallest_multiple2 divisors =
        seq {
                for x in 20..System.Int32.MaxValue do
                    let d = divisors |> List.fold (fun acc e -> acc + (x%e)) 0
                    if d = 0 then yield d
            }
        |> Seq.head

    let result2 = smallest_multiple2 [1..20]
    printfn "%d" result2