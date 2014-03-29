

module SummationOfPrimes = 

    let sum_primes_below limit =
        let s = seq { for n in 2 .. limit do
                        if is_prime (int64 n) then
                            yield (int64 n)
                    }
        Seq.sum s
