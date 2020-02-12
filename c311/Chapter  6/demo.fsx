// Type to represent a name age height and weight
type person = Person of string * int * float * float

let president = Person("George", 57, 70.0, 175.0)

let getName (Person(name, age, height, weight)) = name

// getName used on President
getName president

// Union Types:
type Element =
    | I of int
    | F of double
