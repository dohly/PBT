module ExampleBasedTests

open Xunit
open MyMathLibrary

[<Fact>]
let ``When I add 1 + 3, I expect 4``()=
    let result = MyMath.Add 1 3
    Assert.Equal(4,result)

[<Fact>]
let ``When I add 2 + 2, I expect 4``()=
    let result = MyMath.Add 2 2
    Assert.Equal(4,result)

[<Fact>]
let ``When I add -1 + 3, I expect 2``()=
    let result = MyMath.Add 2 2
    Assert.Equal(4,result)
