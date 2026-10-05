// 34.1
let upto n =
    let rec loop k acc =
        match k with
        | 0 -> acc
        | _ -> loop (k - 1) (k :: acc)

    loop n []

// 34.2
let rec dnto n =
    match n with
    | 0 -> []
    | _ -> n :: dnto (n - 1)

// 34.3
let evenn n =
    let rec loop k acc =
        match k with
        | k when k <= 0 -> acc
        | _ -> loop (k - 1) ((k * 2 - 2) :: acc)

    loop n []
