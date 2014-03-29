
//sum of even fib numbers below x number
let next_fib a b =
   a + b 

let rec fib_list a b limit list =
    if (a + b) <= limit then
        let f = next_fib a b
        if f % 2 = 0 then fib_list b f limit (f::list) 
        else fib_list b f limit list
    else
        list
             
let sum_even_fib limit =
    fib_list 0 1 limit [] 
    |> List.sum