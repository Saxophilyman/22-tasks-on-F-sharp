48.4.2. Имеется функция генерации списка


let rec bigList n k =
  if n=0 then k []
  else bigList (n-1) (fun res -> 1::k(res))
Эта функция при вызове


bigList 230000 id
генерирует исключение StackOverflow на тестовом сервере.

Напишите корректную версию bigList.
Вы можете пробовать самые разные варианты, которые у вас будут отрабатывать корректно, но ваша задача -- найти ту реализацию, которая не будет вылетать на тестовом сервере (достаточно аккуратно подправить исходный вариант).

// 48.4.1
let rec fibo1 n n1 n2 =
    match n with
    | 0 -> n2
    | _ -> fibo1 (n - 1) (n1 + n2) n1

// 48.4.2
let rec fibo2 n c =
    match n with
    | 0 -> c 0
    | 1 -> c 1
    | _ ->
        fibo2 (n - 1) (fun x ->
            fibo2 (n - 2) (fun y ->
                c (x + y)))

// 48.4.3
let rec bigList n k =
    if n = 0 then k []
    else bigList (n - 1) (fun res -> k (1 :: res))
