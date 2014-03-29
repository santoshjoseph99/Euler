
module Problem17 =
    open System.Collections.Generic
    open System

    let get_word_count_map =
        let map = new Dictionary<int,string>()
        map.Add(1,"one")
        map.Add(2,"two")
        map.Add(3,"three")
        map.Add(4,"four")
        map.Add(5,"five")
        map.Add(6,"six")
        map.Add(7,"seven")
        map.Add(8,"eight")
        map.Add(9,"nine")
        map.Add(10,"ten")
        map.Add(11,"eleven")
        map.Add(12,"twelve")
        map.Add(13,"thirteen")
        map.Add(14,"fourteen")
        map.Add(15,"fifteen")
        map.Add(16,"sixteen")
        map.Add(17,"seventeen")
        map.Add(18,"eighteen")
        map.Add(19,"nineteen")
        map.Add(20,"twenty")
        map.Add(30,"thirty")
        map.Add(40,"forty")
        map.Add(50,"fifty")
        map.Add(60,"sixty")
        map.Add(70,"seventy")
        map.Add(80,"eighty")
        map.Add(90,"ninety")
        map.Add(100,"one hundred")
        map.Add(200,"two hundred")
        map.Add(300,"three hundred")
        map.Add(400,"four hundred")
        map.Add(500,"five hundred")
        map.Add(600,"six hundred")
        map.Add(700,"seven hundred")
        map.Add(800,"eight hundred")
        map.Add(900,"nine hundred")
        map


    let count_only_letters s =
        let count = 0
        Seq.toList s 
        |> Seq.map (fun e -> if e = ' ' || e = '-' then 0 else 1) 
        |> Seq.sum
        
    let get_letter_count num (map: Dictionary<int,string>) =
        let l = num.ToString()
        if l.Length = 4 then
            printfn "one thousand"
            "one thousand".Length - 1
        else if l.Length = 3 then
            if num % 100 = 0 then
                printfn "%s" map.[num]
                count_only_letters map.[num]
            else
                let s1 = map.[Int32.Parse(l.[0].ToString())] + " hundred and "
                let d2 = Int32.Parse(l.Substring(1))
                if d2 < 21 || d2 % 10 = 0 then
                    let s2 = map.[d2]
                    printfn "%s" (s1+s2)
                    count_only_letters (s1+s2)
                else
                    let s2 = map.[Int32.Parse(l.[1].ToString())*10] + "-"
                    let s3 = map.[Int32.Parse(l.[2].ToString())]
                    printfn "%s" (s1+s2+s3)
                    count_only_letters (s1+s2+s3)
        else if l.Length = 2 then
            if num = 10 then
                printfn "ten"
                "ten".Length
            else
                if Int32.Parse(l) < 21 || l.[1] = '0' then
                    let s2 = map.[Int32.Parse(l)]
                    printfn "%s" s2
                    s2.Length
                else
                    let s2 = map.[Int32.Parse(l.[0].ToString())*10] + "-"
                    let s3 = map.[Int32.Parse(l.[1].ToString())]
                    printfn "%s" (s2+s3)
                    count_only_letters (s2+s3)
        else
            let s3 = map.[Int32.Parse(l.[0].ToString())]
            printfn "%s" s3
            s3.Length

    let rec count_letters' s e count map =
        let c = get_letter_count s map
        printfn "%d %d" c count
        if s = e then 
            count+c
        else
            count_letters' (s+1) e (count+c) map
            
    let count_letters s e =
        count_letters' s e 0 get_word_count_map

