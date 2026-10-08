let try_find key m =
    let rec find = function
        | [] -> None
        | (k, v) :: _ when k = key -> Some v
        | _ :: tail -> find tail
    find (Map.toList m)
