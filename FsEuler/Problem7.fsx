
module Find10001Prime =

    [<Literal>]
    let PrimeIndex = 10001

    let rec is_prime_helper x n =
        match n with
        | 0 | 1 -> true
        | _ ->
            if x % n = 0 then false else is_prime_helper x (n - 1)

    let is_prime x =
        is_prime_helper x (x/2) 
       
    let rec find_prime_of_helper current_index num =
        match current_index with
        | PrimeIndex -> (num-1)
        | _ -> if is_prime num then 
                    find_prime_of_helper (current_index+1) (num+1)
               else
                    find_prime_of_helper current_index (num+1) 

    let find_prime_of =
        find_prime_of_helper 0 2