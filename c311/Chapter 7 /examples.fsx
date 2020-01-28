//  Converts days to miliseconds:

let days2ms days =
    let hours = days * 24.0
    let minutes = hours * 60.0
    let seconds = minutes * 60.0
    seconds * 1000.0

// Println debugging for F# code

let rec fac n =
    match n with
    | 0
    | 1 -> (bigint 1)
    | n ->
        let _ = printfn "fac %d" n
        let result = (bigint n) * fac (n - 1)
        let _ = printfn "result: %d" n result
        result

// These are being built to reduce time complexity
let rec linfib n =
    match n with
    | 0 -> (1, 0)
    | 1 -> (1, 1)
    | 2 -> (2, 1)
    | 3 -> (3, 2)
    | 4 -> (5, 3)
    | n ->
        let (a, b) = linfib (n - 1)
        let _ = printfn "fib %d = %d" n (a + b)
        (a + b, a)
