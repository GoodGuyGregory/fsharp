//  Ex 5.5
let fb (x: a) (y: b) = x
let fe (x: int list) = x.Head + 1

// Ex 6:
// d.)
let rec rac (s: 'a list) =
    if (s.Tail.IsEmpty) then s.Head else rac s.Tail

rac [ 1; 2; 3 ]
// e.)
let rec rdc (L: 'a list) =
    if (L.Tail.IsEmpty) then [] else L.Head :: rdc (L.Tail)

// f.)
let rec R(L: 'a list) =
    if (L = []) then [] else (rac L) :: R(rdc L)

// g.)
let inc (x: int) = x + 1

// h.)
let second (L: 'a list) = L.Tail.Head

//  i.)
let rec firstAbove0 (L: 'a list) =
    if (L.Head > 0) then L.Head else firstAbove0 L.Tail

// j.)
let rec smallest (L: int list) =
    if (L.Tail.IsEmpty) then L.Head
    else if (L.Head < (smallest L.Tail)) then L.Head
    else smallest L.Tail
