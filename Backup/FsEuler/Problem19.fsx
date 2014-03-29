
open System

//Counting Sundays
module Problem19 =
//    type Months =
//        | Jan of int
//        | Feb of int
//
//
//    let months = [ Jan(31);Feb(28) ]
//
//    let count_sundays =
//        seq {
//                for year in 1..100 do
//                    for month in 0..11 do
//                        let days_in_month = get_days_in_month month
//                        for day in 0..days_in_month do
//                            if is_sunday  
//            }
//        |> Seq.length

    let count_sundays2 =
        let start = DateTime(1901,1,1)
        seq {
            for x in 0..(365*100) do
                let d = start.AddDays((float)x)
                if d.DayOfWeek = DayOfWeek.Sunday && d.Day = 1 then
                    yield 1
            }
        |> Seq.sum