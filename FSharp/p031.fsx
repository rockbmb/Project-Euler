let p_031 =
   let rec solution res coins =
      match coins with
    //| [] -> 0 // this case is not necessary for our problem as the coin list is not empty, but in other cases, it might be
      | [1] -> 1
      | c :: cs -> [for i in 0 .. (res/c) do yield solution (res-c*i) cs] |> List.sum
   solution 200 [200;100;50;20;10;5;2;1]
