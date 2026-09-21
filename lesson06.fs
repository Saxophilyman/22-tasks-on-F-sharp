// 17.1
let rec pow  = function
    | (s, 0) ->  ""
    | (s, n) -> s + pow(s, n-1) 

// 17.2
let rec isIthChar (s: string, n, c) = s.[n] = c

// 17.3
let rec occFromIth  ...
