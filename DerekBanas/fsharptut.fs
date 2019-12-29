open System

// =======================================
// BUILD and RUN with REPL DEVELOPMENT:
// SELECT ALL (CMD + A) 
// ALT + ENTER 
// =======================================

// declare a function
let hello() =
// print without a new line
    printf "Enter your name : "

    let name = Console.ReadLine()
// prints a new line
    printfn "Hello %s" name

    // %i = ints
    // %f = floats
    // %b = booleans
    // %s = strings
    // %A = Datatypes like tuples etcs
    // %O = objects

// Creates a Function to display PI to 27 digits:
let piFloat() =

    let big_pi = 3.141592653589797328462643383M

    printfn "Big PI : %M" big_pi
    
let bind_stuff() =
    // Makes a mutable variable:
    let mutable weight = 175
    weight <- 170

    printfn "Weight : %i " weight

    // Reference Cells for changing values:

    let change_me = ref 10
    change_me := 50

    printfn "Change : %i" ! change_me

bind_stuff()

// hello()

// piFloat()

Console.ReadKey() |> ignore
