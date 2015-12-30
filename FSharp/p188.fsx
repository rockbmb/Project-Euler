//hyperexponentiation
let p_188 =
   let even n = (n%2L)=0L
   let odd = not << even
   let powMod b e m=
      let rec powMod' (b:int64) (e:int64) (m:int64) (od:int64) = 
         match e with
         | 1L -> (b*od) % m
         | e -> if even e then powMod' ((b*b)%m) (e/2L) m od
                else powMod' b (e-1L) m ((od*b)%m)
      powMod' b e m 1L
   let helper b e m = 
      let rec helper' i acc =
         if i > e then acc
         else helper' (i+1L) (powMod b acc m)
      helper' 1L 1L
   helper 1777L 1855L (pown 10L 8)

