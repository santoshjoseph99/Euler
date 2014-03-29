module HighlyTriangularDivisibleNumber =

    let rec get_divisors' num divisor x =
        if num = (divisor/2) then 
            //printfn "%d %d" num (x+1)
            (x+1)
        else
            if num % divisor = 0 then 
                get_divisors' num (divisor+1) (x+1)
            else
                get_divisors' num (divisor+1) x

    let get_divisors num =
        get_divisors' num 1 0

    let rec get_triangular_number idx num =
        if idx = 0 then num
        else
            get_triangular_number (idx-1) (num+idx)

    let get_tri_numbers =
        Seq.initInfinite (fun index -> get_triangular_number index 0)

    let get_tri_number_with_at_least_divisors x =
        get_tri_numbers
        |> Seq.find (fun e -> (get_divisors e) > x)
