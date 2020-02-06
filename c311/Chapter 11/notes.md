## Data Types in F#

**Enumerations**

`type` defines a type in F#

creates a type constructor, and a data constructor

unlike C++ and C there is no distinction with the enumeration and the creation of numeric values of the function

here we see *day* being the type constructor,

and the data constructor is *Mon* etc..
`type day = Mon | Tues | Wed | Thur | Fri | Sat | Sun`

`let isWeekday x = note (x = Sat || x = Sun);;`

**Data Constructors**

Create a value of ints or floats:

These are thought of as Wrappers

`type IR = I of int | R of double`

**Types and Implicit Operations**

`let x = Value 5;;`

wont allow for `x+x`, because the value of the function handling isnt defined for these types

to get the values out of a variable you can utilize pattern matching

```f#
let x = Value 5

let (Value y) = x
```
**Option Types**

used for division by zero etc, used for predefined functions when results are not always defined.

### Examine notes for Binary C tree:

## Last Section for F# programming