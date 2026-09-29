type TimeOfDay = { hours: int; minutes: int; f: string }

let (.>.) x y =
    if x.f = y.f then
        x.hours > y.hours || (x.hours = y.hours && x.minutes > y.minutes)
    else
        x.f = "PM"
