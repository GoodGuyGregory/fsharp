## Chapter 7

Printing Values:

%d - prints int
%f - floats values
%s - string values
%A - prints lists and tuple values (the whole thing)
%o - will print objects and use toString method to print the object


using local side effects to debug your code :

```fsharp
let rec fac n = 
    match n with
        | 0 | 1 -> (bigint 1)
        | n -> 
        let _ = printfn "%d" n
            bigint n * fac (n - 1)
```

**C# Functions as Parameters**

Functional programming is all about composition and using delegates in C# is a common technique for doing this.