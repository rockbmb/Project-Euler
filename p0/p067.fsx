//pyramid sum of path
let p_067 =
  let helper (s1: seq<int16>) (s2: seq<int16>) = 
    let newS2 = s2 |> Seq.pairwise |> Seq.map System.Math.Max
    Seq.map2 (+) s1 newS2 
  System.IO.File.ReadAllLines("C:\\Users\\Asus\\Desktop\\Euler\\p067.txt") |>
  Seq.map (fun x -> x.Split [|' '|] |>
  Seq.map int16) |>
  Seq.reduceBack helper |> 
  Seq.head
