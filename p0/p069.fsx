//totient maximum
let p_069 = 
    let primes = allPrimes |> Seq.take 200 |> Array.ofSeq
    let rec helper n i = if primes.[i] * n > 1000000 then n else helper (primes.[i] * n) (i+1)
    helper 1 0
