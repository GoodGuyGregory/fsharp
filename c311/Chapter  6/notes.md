## Chapter 6 Notes:

**Types**

**primative type**- Any type that a progam can use but cannot define for itself in the language

**constructed type**- Any type that a programmer can define (using the primative types

**Class vs Type**

What you are doing vs the representation of the type 


**Size Matters**

```f#
let rec fact n :bigint = 
    match n with
    | 0 -> bigint 1
```
```c++
int fact(int n) {
    switch(n) {
        case 0: 
    }
}
```

**Arrays**

Not Recommended in F# because they create side-effects. example in the notes DONT DO IT 💩

**Union Types**

**IEEE 754**

**Features to Look for in Languages**

Things to consider

*Type Annotations: Static are written in the program, Dynamic are determined at runtime.
for example in Python the type is checked at Runtime, this is also the case for JS, which is also hella weird 💩
*Dynamic Languages: static types prevent programmers from making mistakes. F# makes type inferences. 
