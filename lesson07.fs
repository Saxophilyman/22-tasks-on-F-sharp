// 20.3.1
let vat n (x: float) : float = x + (x/float(100)) * float n 

// 20.3.2
let unvat n (x: float) : float =  x / (1.0 + float n / 100.0)

// 20.3.3
let rec min f = 
    let rec search = function
        | n when f n = 0 -> n 
        | n -> search (n + 1)
    search 1
