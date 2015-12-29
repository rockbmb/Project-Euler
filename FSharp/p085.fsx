//counting rectangles
let p_085 =
   let helper x y = 
      (x+1)*(y+1)*x*y - 8000000 |> abs
   seq {for i in 1 .. 100 do
           for j in i .. 100 do
               yield (helper i j),i*j} |> Seq.min |> snd
