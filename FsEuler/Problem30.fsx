
//Digit fifth powers: exponent seq fold

let exp a b =
    seq { for x in 1..b do yield a }
        |> Seq.fold (fun acc e -> acc * e) 1

let get_sum n =
    let s = n.ToString().ToCharArray();
    seq { for x in s do yield exp (System.Int32.Parse(x.ToString())) 5 } 
        |> Seq.sum 
         
let digit_fifth_powers =
    seq { for x in 2..System.Int32.MaxValue do
                if x = get_sum x then yield x
        } |> Seq.sum
