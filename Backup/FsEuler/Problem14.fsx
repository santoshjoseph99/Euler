module Problem14 =
    let even (n: int64) = n/2L

    let odd (n: int64) = 3L*n + 1L

    let is_even (n: int64) =
        if n % 2L = 0L then true else false

//    let rec get_chain_length' n (length: int) =
//        printfn "--%d %d" n length
//        if n = 1 then length+1
//        else if is_even n then
//            get_chain_length' (even n) length+1
//        else
//            get_chain_length' (odd n) length+1 
//
//    let get_chain_length num =
//        get_chain_length' num 0

    let get_chain_length2 (num: int64) =
        let s = Seq.unfold (fun (i: int64) -> 
                        if i = 1L then None 
                        else 
                            if is_even i then
                                Some(i,even i)
                            else
                                Some(i,odd i) ) num
        let n = Seq.length s
        n + 1

    let get_chain_length3 (num: int64) =
        let mutable n = num
        let mutable i = 1
        while n <> 1L do
           //printfn "%d" n
           if is_even n then
                n <- even n
           else
                n <- odd n
           i <- i + 1
        i

    let rec collatz num length (longest_num: int) =
        let chain_length = get_chain_length2 num
        //printfn "%d %d %d" chain_length num longest_num
        if num = 1L then 
            longest_num
        else if chain_length > length then
            collatz (num-1L) chain_length (int num)
        else
            collatz (num-1L) length longest_num

    let find_longest_collatz_sequence start = 
        collatz start 0 0


