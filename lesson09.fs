// 23.4.1
let normalizeMoney (gold, silver, copper) =
    let total = gold * 240 + silver * 12 + copper
    let rest = ((total % 240) + 240) % 240
    let gold' = (total - rest) / 240
    let silver' = rest / 12
    let copper' = rest % 12
    (gold', silver', copper')

let (.+.) (g1, s1, c1) (g2, s2, c2) = normalizeMoney (g1 + g2, s1 + s2, c1 + c2)
let (.-.) (g1, s1, c1) (g2, s2, c2) = normalizeMoney (g1 - g2, s1 - s2, c1 - c2)


// 23.4.2
let complexNeg ((a, b) : float * float) = (-a, -b)
let complexInv ((a, b) : float * float) = let d = a * a + b * b in (a / d, -b / d)

let (.+) ((a, b) : float * float) ((c, d) : float * float) = (a + c, b + d)
let (.*) ((a, b) : float * float) ((c, d) : float * float) = (a * c - b * d, b * c + a * d)
let (.-) (x : float * float) (y : float * float) = x .+ complexNeg y
let (./) (x : float * float) (y : float * float) = x .* complexInv y
