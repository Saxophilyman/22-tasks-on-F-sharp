40.3.3. Напишите функцию сортировки с использованием предыдущих функций, которая сортирует входной список так, что на выходе получается слабо восходящий список.

40.4. Напишите функцию revrev, которая получает на вход список списков, и перевёртывает как порядок вложенных списков, так и порядок элементов внутри каждого вложенного списка.

revrev [[1;2];[3;4;5]] = [[5;4;3];[2;1]]

// 40.1
let rec sum (p, xs) =
    match xs with
    | [] -> 0
    | head :: tail when p head -> head + sum (p, tail)
    | _ :: tail -> sum (p, tail)

// 40.2.1
let rec count = function
    | [], _ -> 0
    | head :: tail, n when head < n -> count (tail, n)
    | head :: tail, n when head = n -> 1 + count (tail, n)
    | head :: tail, n when head > n -> 0

// 40.2.2
let rec insert = function
    | [], n -> [n]
    | head :: tail, n when head < n -> head :: insert (tail, n)
    | head :: tail, n -> n :: head :: tail

// 40.2.3
let rec intersect = function
    | [], _ | _, [] -> []
    | head1 :: tail1, head2 :: tail2 ->
        if head1 = head2 then
            head1 :: intersect (tail1, tail2)
        elif head1 < head2 then
            intersect (tail1, head2 :: tail2)
        else
            intersect (head1 :: tail1, tail2)

// 40.2.4
let rec plus = function
    | [], xs2 -> xs2
	| xs1, [] -> xs1
    | head1 :: tail1, head2 :: tail2 ->
        if head1 = head2 then
            head1 :: head2 :: plus (tail1, tail2)
        elif head1 < head2 then
            head1 :: plus (tail1, head2 :: tail2)
        else
            head2 :: plus (head1 :: tail1, tail2)

// 40.2.5
let rec minus = function
    | [], _ -> []
    | xs1, [] -> xs1
    | head1 :: tail1, head2 :: tail2 ->
        if head1 = head2 then
            minus (tail1, tail2)
        elif head1 < head2 then
            head1 :: minus (tail1, head2 :: tail2)
        else
            minus (head1 :: tail1, tail2)


// 40.3.1
let rec smallest = function
    | [] -> None
    | [x] -> Some x
    | x :: y :: tail ->
        if x < y then
            smallest (x :: tail)
        else
            smallest (y :: tail)

// 40.3.2
let rec delete = function
    | _, [] -> []
    | n, head :: tail when n = head -> tail
    | n, head :: tail -> head :: delete (n, tail)

// 40.3.3
let rec sort = ...

// 40.4
let rec revrev = ...
