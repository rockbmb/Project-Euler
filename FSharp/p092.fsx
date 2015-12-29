let p_092 =
   let rec helper n =
      let rec digitSum num acc = 
         if num = 0 then acc 
         else digitSum (num/10) (acc+(pown (num%10) 2))
      let newN = digitSum n 0 
      if newN = 1 then false
      elif newN = 89 then true
      else helper newN
   seq { for i in 1 .. (pown 10 7)-1 do if helper i then yield i else ()} |> Seq.length
