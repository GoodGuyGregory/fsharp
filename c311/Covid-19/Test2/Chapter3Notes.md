## Syntax Semantics

### Precedence in Grammars

Operator Precedence

* Applies when the order of evaluation is not completely decided by parentheses
* Each operator has a precedence level, and those with higher precedence are performed before those with lower precedence, as if parenthesized
* Most languages put * at a higher precedence level
than +, so that:
    `a+b*c = a+(b*c)`

Operator Associativity

Applies when the order of evaluation is not decided by parentheses or by precedence
* Left-associative operators group left to right: a+b+c+d = ((a+b)+c)+d

*  Right-associative operators group right to left: a+b+c+d = a+(b+(c+d))

* Most operators in most languages are leftassociative, but there are exceptions

**Abstract Syntax Trees**

Language systems usually store an abbreviated version of the parse tree called the AST or (Abstract Syntax Tree)

**AST to Reverse Polish Notation**

Abstract Syntax Tree holds the infix expression operations and operands.

* Traversing the AST in post-order produces the RPN.
* RPN operator precedence is unambiguous.
* Operands are arranged in proper order for post-order evaluation.
* Easily evaluated on hardware using a stack

