open System
(* This is a multi-line comment *)
// This is a single-line comment

let sign num =
    if num > 0 then "positive"
    elif num < 0 then "negative"
    else "zero"

let main() =
    Console.WriteLine("sign 5: {0}", (sign 5))

main()