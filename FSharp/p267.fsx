let p_267=
 let h = 1e-6
 let d f x = (f (x+h) - f x) / h
 let func x =
    let ln = Operators.log
    (9.0*ln(10.0) - 1000.0*ln(1.0-x)) / (ln (1.0+2.0*x) - ln (1.0-x))
 let rec gradDescent f alpha phi =
    if abs (f - phi) > alpha then let deriv = d func f
                                  gradDescent (f - alpha*deriv) alpha f
                             else f
 let minH = gradDescent 0.5 1e-4 0.0 |> 
            func |> 
            System.Math.Ceiling |>
            int
 let lim = bigint.Pow ((bigint 2),1000)
 let comb n p =
    let fact m =
       let rec fact' m acc =
          match m with
          | 0 -> acc
          | m -> fact' (m-1) (acc*(bigint m))
       fact' m (bigint 1)
    (fact n) / ((fact p)*(fact (n-p)))
 let rec final m i = 
   if i <= 1000 then final (m+(comb 1000 i)) (i+1)
   else m
 double (final (bigint 0) minH) / double lim |> decimal // for some reason, without converting it to decimal only 10 decimal points are shown. looking into it.
