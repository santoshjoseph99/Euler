
module Problem21 = 

    let is_divisor num div =
        if num % div = 0 then true else false

    let get_amicable_number_sum a =
        let s1 = seq {
                        for x in 1..(a/2) do
                            if is_divisor a x then yield x
                     }
        let da = Seq.sum s1
        let s2 = seq {
                        for x in 1..(da/2) do
                            if is_divisor da x then yield x
                     }
        let db = Seq.sum s2
        if db = a && a <> da then
            //printfn "amicable a=%d da=(%d) db=%d sum=%d" a da db (a+da)
            a + da
        else
            0

    let get_amicable_numbers_under num =
        seq {
                for x in 1..num do
                    yield get_amicable_number_sum(x) 
            }
        |> Seq.sum

    let result = get_amicable_numbers_under 9999
    printfn "%d" (result/2)
