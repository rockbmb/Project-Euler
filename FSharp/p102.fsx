let p_102 =
   let barycenter (ax : float,ay : float) (bx,by) (cx,cy) =
      let v0 = (cx-ax,cy-ay)
      let v1 = (bx-ax,by-ay)
      let v2 = (-ax,-ay)
      let (!.) (x,y) (w,z) = x*w + y*z
      let u = ((!. v1 v1)*(!. v2 v0)-(!. v1 v0)*(!. v2 v1)) / ((!. v0 v0)*(!. v1 v1) - (!. v0 v1)*(!. v1 v0))
      let v = ((!. v0 v0)*(!. v2 v1)-(!. v0 v1)*(!. v2 v0)) / ((!. v0 v0)*(!. v1 v1) - (!. v0 v1)*(!. v1 v0))
      u>=0.0 && v >=0.0 && u+v<=1.0
   let s = "C:\\Users\\Asus\\Desktop\\Euler\\p102.txt"
   System.IO.File.ReadAllLines(s) |> 
   Array.map (fun x -> 
                x.Split [|','|] |> 
                Array.map float |> 
                (fun a -> barycenter (a.[0],a.[1]) (a.[2],a.[3]) (a.[4],a.[5]))) |>
  Array.filter id |>
  Array.length
