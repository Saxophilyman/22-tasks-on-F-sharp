// 39.1
let rec rmodd = function
    | [] | [_] -> []
    | _ :: x :: tail -> x :: rmodd tail

// 39.2
let rec del_even = function
    | head :: tail when head % 2 = 0 -> del_even tail
    | head :: tail -> head :: del_even tail
    | [] -> []

// 39.3
let rec multiplicity x = function
    | [] -> 0
    | head :: tail when head = x -> 1 + multiplicity x tail
    | head :: tail -> multiplicity x tail
    
// 39.4
let rec split = function
    | [] -> ([], [])
    | [head] -> ([head], [])
    | head1 :: head2 :: tail ->
        let (xs1, xs2) = split tail
        (head1 :: xs1, head2 :: xs2)

// 39.5
exception DifferentLengths

let rec zip (xs1, xs2) =
    match (xs1, xs2) with
    | [], [] -> []
    | head1 :: tail1, head2 :: tail2 ->
        (head1, head2) :: zip (tail1, tail2)
    | [], _ | _, [] -> raise DifferentLengths
