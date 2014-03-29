 
module SpecialPythagoreanTriplet =
    //a + b + c = 1000
    open System

    let square x = x * x

    let check_pyth_triple a b c =
        if a < b && b < c then
            if (square a + square b) = square c then true else false
        else
            false

    let check_params_equal_1000 a b c =
        if a + b + c = 1000 then true else false

    let generate_triple_from a b c limit =
        let s = seq { for a' in a .. limit do
                        for b' in b .. limit do
                            for c' in c .. limit do
                                if check_pyth_triple a' b' c' then
                                    //printfn "%d %d %d" a' b' c'
                                    if check_params_equal_1000 a' b' c' then
                                        //printfn "--%d %d %d" a' b' c'
                                        yield (a',b',c')
            }
        let triple = Seq.exactlyOne s
        match triple with
        | (x, y, z) -> x * y * z

