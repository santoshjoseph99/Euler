module Problem15 =

//    type Data ={
//        X: int
//        Y: int
//    }
//
//    type BinTree =
//        | Node of Data * BinTree * BinTree
//        | Empty
//
    let rec find_num_paths x y max =
        if x = max && y = max then
            1L
        else if x = max then
            find_num_paths x (y+1) max
        else if y = max then
            find_num_paths (x+1) y max
        else
            let l = find_num_paths (x+1) y max
            let r = find_num_paths x (y+1) max
            l + r
//
//    let rec create_binary_tree x y max =
//        if x = max && y = max then
//            Empty
//        else if x = max then
//            let b = create_binary_tree x (y+1) max
//            Node({X=x;Y=(y+1)},Empty,b)
//        else if y = max then
//            let b = create_binary_tree (x+1) y max
//            Node({X=(x+1);Y=y},b,Empty)
//        else
//            let l = create_binary_tree (x+1) y max
//            let r = create_binary_tree x (y+1) max
//            Node({X=x;Y=y},l,r)
//
//    let rec count_empty_nodes2 node =
//        match node with
//        | Node(d,Empty,Empty) -> 
//            1
//        | Node(d,l,r) -> 
//            let c1 = count_empty_nodes2 l
//            let c2 = count_empty_nodes2 r
//            c1+c2
//        | Empty ->
//            0
