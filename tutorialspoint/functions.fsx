// Function to calculate the volume of a cyclinder:
let cylinderVolume radius length: float =
    // Function body:
    let pi = 3.14159
    length * pi * radius

let vol = cylinderVolume 3.0 5.0

printf " Volume: %g" vol

// Function to return the larger of two numbers:
let max num1 num2: int32 =
    if num1 > num2 then num1 else num2

// Double it function will double the arguments taken:
let doubleIt (x: int) = 2 * x


// RECURIVE FUNCTIONS:
let rec fib n =
    if n < 2 then 1 else fib (n - 1) + fib (n - 2)
