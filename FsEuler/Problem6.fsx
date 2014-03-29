module SumSquareDifference =

    let sum_of_squares list =
        list |> List.map (fun e -> e * e) |> List.sum

    let square_of_sum list =
        list |> List.sum |> (fun e -> e * e)

    let difference_sum_square list =
       sum_of_squares list - square_of_sum list
       

