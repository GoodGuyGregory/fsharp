let rec fib n =
    if n <= 1 then n else fib (n - 1) + fib (n - 2)

// List Operations: are all Recursive to avoid side effects- which are changing and reassigning values to variables
let rec summation (x: int list) =
    // Base case
    if (x.IsEmpty) then
        0
    // Recursive Case:
    else
        x.Head + summation (x.Tail)

// Class Example:
let rec summationClass L =
    // Base Case of an empty list
    if L = [] then
        0
    // Count the elements
    else
        L.Head + summation L.Tail

// List Length:
let rec count L =
    // Base Case
    if L = [] then 0 else 1 + count L.Tail

let rec secondToLast (L: 'a list) =
    if L.Tail.Tail = [] then L.Head else secondToLast L.Tail

// nth Element in List
let rec Nth n (L: 'a list) =
    if (n = 1) then L.Head else Nth (n - 1) L.Tail

let rec identity (L: 'a list) =
    if L = [] then [] else L.Head :: identity (L.Tail)

let rec allbuttthelast (L: 'a list) =
    if L = [] then [] else L.Head :: allbuttthelast (L.Tail)

let rec reverse (L: 'a list) =
    if L = [] then [] else (reverse (L.Tail) @ [ L.Head ])

let rec vecmul L x =
    if L = [] then [] else x * L.Head :: (vecmul L.Tail x)

let rec matmul M x =
    if M = []
    then []
    else (vecmul M.Head x) :: 

// Pattern Matching: Exercises

let rec identityPattern L =
    match L with
    | [] -> []
    | h :: t -> h :: identity t

let headPattern L =
    match L with
    | [] -> []
    | h :: t -> h

let rec count L =
    match L with
    | [] -> 0
    | h::t -> if h then 1 + count(t) else count t

let rec last (L:'a list) =
    if (L.Tail = []) then L.Head
    else last L.Tail