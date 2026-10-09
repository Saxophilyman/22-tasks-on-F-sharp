// 49.5.1
let even_seq =
    Seq.initInfinite (fun i -> 2 * (i + 1))

// 49.5.2
let fac_seq =
    let rec fac = function
        | 0 -> 1
        | n -> n * fac (n - 1)

    Seq.initInfinite fac

// 49.5.3
let seq_seq =
    Seq.initInfinite (fun i ->
        if i % 2 = 0 then i / 2
        else -((i + 1) / 2))
