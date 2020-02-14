// Pattern Matching:

let describeInt i =
    match i with
    | 1 -> "One"
    | 2 -> "Two"
    | _ -> "Many"

let tryFirst (items: string list) =
    match items with
    | [] -> None
    | f :: _ -> Some f

let printFirstFew (items: string list) =
    match items with
    | [] -> printfn "Empty List"
    | [ a ] -> printfn "One Element: %s" a
    | [ a; b ] -> printfn "Two elements: %s %s" a b
    | a :: b :: _ -> printfn "More than two: %s %s ..." a b

let firstOrDefault dflt (items: string list) =
    match tryFirst items with
    | Some x -> x
    | None -> dflt

type MayHap<'T> =
    | Summat of 'T
    | Nowt


let tryFirst2 (items: string list) =
    match items with
    | [] -> Nowt
    | f :: _ -> Summat f

let firstOrDefault2 dflt (items: string list) =
    match tryFirst2 items with
    | Summat x -> x
    | Nowt -> dflt
