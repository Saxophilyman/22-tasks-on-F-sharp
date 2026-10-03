type F =
    | AM
    | PM

type TimeOfDay =
    {
        hours : int
        minutes : int
        f : F
    }

let transform =
    function
    | { hours = h; minutes = m; f = AM } ->
        h * 60 + m
    | { hours = h; minutes = m; f = PM } ->
        (h + 12) * 60 + m

let (.>.) x y =
    transform x > transform y
