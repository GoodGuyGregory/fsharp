// Chapter 7:
// Exercise 1:
let f n = n * n

let f a b = a * b

let f L =
    match L with
    | (a, b, _) -> b

let f L =
    match L with
    | x :: xs -> xs

// Exercise 2:

// // let f x y =
//     if y = 0 then x
//     else if x = 0 then y
//     else x / y
// //

let f x y =
    match x y with
    | x, y when y = 0 -> x
    | x, y when x = 0 -> y
    | x, y -> x / y

let f (L : int list) = 
    match L with
    | [] -> []
    | h::t when h::[] 