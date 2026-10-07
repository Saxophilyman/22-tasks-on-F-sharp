

41.4.3. Напишите функцию revrev, которая получает на вход список списков, и перевёртывает как порядок вложенных списков, так и порядок элементов внутри каждого вложенного списка.

revrev [[1;2];[3;4;5]] = [[5;4;3];[2;1]]
Реализуйте revrev с помощью List.fold или List.foldBack.

// 41.4.1
let list_filter f xs =
    List.foldBack (fun x acc -> if f x then x :: acc else acc) xs []

// 41.4.2
let sum (p, xs) =
    List.fold (fun acc x -> if p x then acc + x else acc) 0 xs
    
// 41.4.3
let revrev xs =
    List.fold (fun acc x -> (List.rev x) :: acc) [] xs
