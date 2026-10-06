39.3. Напишите функцию multiplicity x xs, которая находит, сколько раз значение x встречается в списке xs.

39.4. Напишите функцию split, которая разделяет входной список на два следующим образом:


split [x1; x2; ...; xn-1; xn] = ([x1; x3; ...], [x2; x4; ...])
39.5. Напишите функцию zip, которая преобразует два входных списка в результирующий список следующим образом:

zip ([x1; x2; ...], [y1; y2; ...]) = [(x1,y1); (x2,y2); ...]
Если длины входных списков неодинаковы, генерируйте исключение.


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
let rec zip (xs1,xs2) = ...
