
    let rec is_prime_helper x n =
        match n with
        | 0 | 1 -> true
        | _ ->
            if x % n = 0 then
                false
            else
                is_prime_helper x (n - 1)

    let is_prime x =
        let l = System.Math.Sqrt (float x)
        is_prime_helper x (int l)