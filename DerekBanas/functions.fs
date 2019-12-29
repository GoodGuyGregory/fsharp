open System


// Create your First Funtion in F#
let get_sum (x : int, y : int) : int = x + y
// called by Repel the same way with get_sum(9,10);;


// Factorial Functions with Recursion
let rec factorial x = 
        if x < 1 then 1
        else x * factorial (x - 1) 

// Recursive Function calls are done with (factorial 4);;

    // Recursion Breakdown can be seen below:
        // 1st: result = 4 * factorial(3) = 4 * 6 = 24
        // 2nd: result = 3 * factorial(2) = 3 * 2 = 6
        // 3rd: result = 2 * factorial(1) = 2 * 1 = 2
    

Console.ReadKey() |> ignore
