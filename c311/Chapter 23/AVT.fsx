type AST =
    | Const of int
    | Plus of AST * AST
    | Minus of AST * AST

let rec valN exp =
    match exp with
    | Const n -> Const n
    | Plus(Const v1, Const v2) -> Const(v1, v2)
    | Plus(e1, e2) -> valN (Plus(valN e1, valN e2))
    | Times(Const v1, Const v2) -> Const(v1, v2)
    | Times(e1, e2) -> valN (Timess(valN e1, valN e2))

let x = 1 in f = (fun n)

let f5 = (Apply(Var "f", Const 5))
let x2 = (let ("x", Const 2, f5))
let f = (let ("f", Fn ("n", Times (Var "n", Var "x")), x2))
let x1 = (Let ( "x", Const 1, f))