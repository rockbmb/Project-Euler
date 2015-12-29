//nim
let p_301 =
   let fibSeq = Seq.unfold (fun (a,b) -> Some( a+b, (b, a+b) ) ) (0,1)
   let fib n = fibSeq |> Seq.item (n-1)
   (*
   let l = 1 <<< 30
   let rec cycle acc n =
      if n = l then acc
      elif (n^^^(2*n)^^^(3*n)) = 0 then cycle (acc+1) (n+1)
      else cycle acc (n+1)
   cycle 0 0

   n ^^^ 2n ^^^ 3n = 0
   <==> ^^^ is self-inverse, and 0 is its identity
   n ^^^ 2n = 3n
   <==> (Z,+) forms a group
   n ^^^ (n <<< 1) = 3n
   <==> 
   n ^^^ (n <<< 1) = n + (n <<< 1)
   <==> Both sides are equal only when there is no carry operation during addition of the right hand side. This is only possible if there are no successive 1s in the binary representation of n.
   n mustn't have any consecutive 1s in its binary representation

   Each different string of 1s of 0s encodes a different number - to find out how many there are, let's establish a recurrence relation g
   Let's assume no empty strings. The second element of the tuple represents the current bit, and the first, the string's length.
   g (1,0) = 1
   g (1,1) = 1
   g (b,0) = g (b-1,0) + g(b-1,1)
   g (b,1) = g (b-1,0)
   from the last two equations, we can further reduce this to
   g (1,0) = 1
   g (2,0) = 2  (this equation becomes necessary)
   g (b,0) = g (b-1,0) + g (b-2,0)
   If we posit that g (0,_) = 1, then it is clear that g (n,0) = fib n
   To represent 2^m, m+1 bits are needed. Therefore, since we want the solution for all numbers lesser or equal to 2^30, the asnwer is*)
   fib 31
