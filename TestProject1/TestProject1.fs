module TestProject1
open Deedle

[<EntryPoint>]
let main argv =
    let x = Series.ofValues [1;2;3]
    printfn "%A" x
    0 // return an integer exit code
