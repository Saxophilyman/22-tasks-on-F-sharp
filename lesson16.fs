let rec allSubsets n = function
    | 0 -> set [Set.empty]
    | k when n = k -> set [set [1 .. n]]
    | k -> Set.union (allSubsets (n - 1) k) (Set.map (Set.add n) (allSubsets (n - 1) (k - 1)))
