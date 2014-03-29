
let sum1 x =
    let rec sum' x t =
        if x = 0 then t else sum' (x-1) (t+x)
    sum' x 0

let sum2 x =
    let rec sum2' x =
        if x = 0 then 0 else x + sum2' (x-1)
    sum2' x

let sum3 x =
    let mutable total = 0
    for i=x downto 1 do
        total <- i + total
    total

let sum4 x =
    seq { for i in 1..x do yield i }
    |> Seq.sum

let sum5 x =
    [1..x] |> List.sum

let sum6 x =
    [|1..x|] |> Array.sum

type BinTree =
    | Node of int * BinTree * BinTree
    | Empty

let rec get_max_value_of_tree node =
    match node with
    | Node(i,Empty,Empty) -> i
    | Node(i,left,right) ->
        let lv = get_max_value_of_tree left
        let rv = get_max_value_of_tree right
        if lv >= rv then i+lv else i+rv
    | Empty -> 0

type Node' =
    | Node of int * Node' * Node'
    | Empty

//type BinaryTree(r : Node') =
//    
//    let root = r
//
//    member this.AddLeftChild n = this.root.
//    member this.AddRightChild
//
//
//type ReadFile =
//    open
//    readline
//    
//let create_tree =
//    let root = Node(75, 
//// read a line, if first line, create root node
//// read a line if not first line, then read a node
////  and add to parent
//
//// read a line..read 1st node...(if first node then is root)
//// read next line 