let p_206 =
  let helper (n: int64) =
    let sn = n*n |> string
    [0 .. 8] |> List.forall (fun x -> (sn.[x*2]) = (string (x+1)).[0])
  let rec cycle m = 
    if helper m then m*10L 
    elif m % 3L = 0L then cycle (m - 6L)
    else cycle (m - 4L)
  cycle 138902663L
