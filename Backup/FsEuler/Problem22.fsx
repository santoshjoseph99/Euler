
#r "System.dll"

open System.Diagnostics

module Problem22 =

    let names_scores () =
        let sw = Stopwatch()
        sw.Start()
        let add a b = a + b
        let alpha_idx_map = 
            let s = Seq.toList ['A'..'Z']
            let n = Seq.toList [1..26]
            let ns = Seq.zip n s
            Seq.fold (fun (acc: Map<char,int>) elem -> acc.Add(snd(elem),fst(elem))) Map.empty ns
        let input = System.IO.File.ReadAllText("names.txt")
        let input_array = input.Split(',')
        let input_idx = [|1..input_array.Length|]
        let mul a b = a * b
        input_array
        |> Array.map (fun e -> e.Replace("\"",""))
        |> Array.sort
        |> Array.Parallel.mapi (fun i e -> 
                                            e 
                                            |> Seq.toList 
                                            |> Seq.fold (fun acc e -> acc+alpha_idx_map.[e]) 0
                                            |> mul (i+1) )
        |> Array.sum
//        |> Array.map (fun elem ->
//                                elem
//                                |> Seq.toList
//                                |> Seq.fold (fun acc2 elem2 -> acc2+alpha_idx_map.[elem2]) 0 )
//        |> Array.fold2 (fun acc (elem1: int) (elem2: int) -> acc + (elem1*elem2)) 0 input_idx
        |> printfn "%d"
        sw.Stop()
        printfn "%A" sw.Elapsed

    names_scores ()