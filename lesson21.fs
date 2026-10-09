// 50.2.1
let fac_seq =
    let rec loop n acc =
        seq {
            yield acc
            yield! loop (n + 1) (acc * (n + 1))
        }

    loop 0 1

// 50.2.2
let seq_seq =
    let rec loop n =
        seq {
            yield -n
            if n <> 0 then yield n
            yield! loop (n + 1)
        }
    loop 0
