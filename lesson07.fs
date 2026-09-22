// 20.3.1
let vat n (x: float) : float = x + (x/float(100)) * float n 

// 20.3.2
let unvat n (x: float) : float =  x / (1.0 + float n / 100.0)

printfn "%f" (vat 100 50)
printfn "%f" (unvat 100 50)
printfn "%f" (unvat 100 (vat 100 50))

// 20.3.3
let rec min f = 
