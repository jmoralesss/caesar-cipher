module CaesarCipher.Test

open CaesarCipher.Console
open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let ShouldPassEncryption () =
    let input = "jonathan"
    let expected = "glk^qe^k"

    let actual = encrypt input

    Assert.AreEqual(expected, actual)
    
[<Test>]
let ShouldNotPassEncryption () =
    let input = "jonathan"
    let expected = "glk^qe^eadf"

    let actual = encrypt input

    Assert.AreNotEqual(expected, actual)
    
[<Test>]
let ShouldPassDecryption () =
    let input = "glk^qe^k"
    let expected = "jonathan"

    let actual = decrypt input

    Assert.AreEqual(expected, actual)