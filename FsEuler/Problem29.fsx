
//Distinct powers: seq distinct exponent bigint

let rec exp_helper (a: bigint) (b: bigint) (total: bigint) =
    if b = 0I then
        total
    else
        exp_helper a (b-1I) total * a

let exp (a: bigint) (b: bigint) =
    exp_helper a b 1I

let distinct_powers (aMax: bigint) (bMax: bigint) =
            seq {
                 for a in 2I..aMax do
                    for b in 2I..bMax do
                        yield exp a b
                }
            |> Seq.distinct
            |> Seq.length