module CaesarCipher.Console

open System

let printLogo() = 
    printfn "
█▀▀ ▄▀█ █▀▀ █▀ ▄▀█ █▀█   █▀▀ █ █▀█ █░█ █▀▀ █▀█
█▄▄ █▀█ ██▄ ▄█ █▀█ █▀▄   █▄▄ █ █▀▀ █▀█ ██▄ █▀▄
    "

let getDecision() =
    printf "1) Encrypt 2) Decrypt:"
    Console.ReadLine()

let getMessage() =
    printf "Enter text: "
    Console.ReadLine()

let convert (message: string) mapping = 
    message
    |> Seq.toArray
    |> Array.map mapping
    |> Array.fold (fun x y -> string(x + string (y))) ""

let encrypt input = convert input (fun x -> char ((int x) - 3))
    
let decrypt input = convert input (fun x -> char ((int x) + 3))

[<EntryPoint>]
let main argv =
    printLogo()

    let decision = if getDecision().Equals("1") then encrypt else decrypt

    let message = getMessage()

    let result = decision message

    printfn "Result: %s" result

    0 // return an integer exit code