// Map Examples

let rec map2 f L1 L2 =
    match (L1, L2) with
    | ([], []) -> []
    | (h1 :: t1, h2 :: t2) -> (f h1 h2) :: map2 f t1 t1

let add x y = x + y
// creates tuples with the two variables
let tup x y = (x, y)

let gt x y =
    if x > y then x else y

let rec filter f L =
    match L with
    | [] -> []
    | h :: t when f h -> h :: filter f t
    | h :: t -> filter f t

let isAdmin x = x = "admin"

filter isAdmin [ "foo"; "bar"; "baz"; "admin" ]

filter
