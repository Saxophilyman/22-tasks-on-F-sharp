// 51.3
let rec nth (s : 'a cell) (n : int) : 'a =
    if n = 0 then hd s
    else
        let t = tl s
        nth (t.Force()) (n - 1)
