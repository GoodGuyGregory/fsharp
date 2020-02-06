// Enumerations:
// Creates a day Type:

type day =
    | Mon
    | Tues
    | Wed
    | Thur
    | Fri
    | Sat
    | Sun

// Using Patterns with the day type:
let isWeekday d =
    match d with
    | Sat
    | Sun -> false
    | _ -> true

//    Example 4 Form the Notes:
type IR =
    | I of int
    | R of float

let x = I 5
let y = R 3.6

let plus x y =
    match (x, y) with
    | (I a, I b) -> I(a + b)
    | (R a, R b) -> R(a + b)
    | (I a, R b) -> R((float a) + b)
    | (R a, I b) -> R(a + (float b))

plus x y

type 'a option =
    | NONE
    | SOME of 'a

type 'a bunch =
    | One of 'a
    | Group of 'a list

type intlist =
    | INTNIL
    | INTCONS of int * intlist


let rec intlistlen L =
    match L with
    | INTNIL -> 0
    | INTCONS(h, t) -> 1 + intlistlen t
