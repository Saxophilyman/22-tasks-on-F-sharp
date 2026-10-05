
34.2. Напишите функцию dnto: int -> int list, которая работает так:

downto n = [n; n-1; n-2; ...; 1].
34.3. Напишите функцию evenn: int -> int list, которая генерирует список из первых n неотрицательных чётных чисел.


// 34.1
let upto n =
    let rec loop k acc =
        match k with
        | 0 -> acc
        | _ -> loop (k - 1) (k :: acc)

    loop n []

// 34.2
let rec dnto = ...

// 34.3
let rec evenn = ...
