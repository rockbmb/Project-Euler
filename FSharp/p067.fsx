//pyramid sum of path
let p_067 =
  let helper (s1: seq<int16>) (s2: seq<int16>) = 
    let newS2 = s2 |> Seq.pairwise |> Seq.map System.Math.Max
    Seq.map2 (+) s1 newS2 
  System.IO.File.ReadAllLines("p067.txt") |> (*this should be the filepath where the problem's file is*)
  Seq.map (fun x -> x.Split [|' '|] |>
  Seq.map int16) |>
  Seq.reduceBack helper |> 
  Seq.head
