let add x y = x + y

// Anonymouse function
let add2 = (fun x -> (fun y -> x + y))

let rec sum L =
    match L with
    | [] -> 0
    | h :: t -> h + (sum t)

let rec tailSum a L =
    let rec sum a L =
        match L with
        | [] -> a
        | h :: t -> tailSum (h + a) t
    sum 0 L

let rec rdc L =
    match L with
    | h :: [] -> []
    | h :: t -> h :: rdc t

let rec tailRdc a L =
    match L with
    | h :: [] -> a
    | h :: t -> tailRdc (h :: a) t
