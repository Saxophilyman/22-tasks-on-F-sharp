// 16.1
let notDivisible  (n, m) = m % n = 0

// 16.2
let  prime  = function
| n when n < 2 -> false
| n ->
    let rec checkPrime = function
    | d when d = n -> true
    | d when n % d = 0 -> false
    | d -> checkPrime (d + 1)

    checkPrime 2
