module PropertyBasedTests
open MyMathLibrary
open FsCheck.Xunit

[<Property>]
let ``A+(B+C)=(A+B)+C`` a b c=
    let (<+>) = MyMath.Add // let's define custom local operator - it's the same as MyMath.Add
    let result1=  a <+> (b <+> c)
    let result2= (a <+> b) <+> c
    result1=result2
    

[<Property>]
let ``A+B=B+A`` a b =
    let result1 = MyMath.Add a b
    let result2 = MyMath.Add b a
    result1 = result2

[<Property>]
let ``A+0=A`` a =
    let result = MyMath.Add a 0
    result = a