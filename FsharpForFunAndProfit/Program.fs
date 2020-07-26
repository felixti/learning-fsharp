// Learn more about F# at http://fsharp.org

open System

type NameAndSize =
    { Name: string
      Size: int }

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let product n =
        let initialValue = 1
        [ 1 .. n ] |> List.fold (fun productSoFar x -> productSoFar * x) initialValue

    let result = product 10
    printfn "The result is %A" result

    let sumOfOdds n =
        let initialValue = 0

        let action sumSoFar x =
            if x % 2 = 0 then sumSoFar else sumSoFar + x
        [ 1 .. n ] |> List.fold action initialValue

    let resultSumOfOdds = sumOfOdds 10
    printfn "The result of sum of odds is %A" resultSumOfOdds


    let alternatingSum n =
        let initialValue = (true, 0)
        let log x = printfn "The result of alternating sum is %A" x; x
        let action (isNeg, sumSoFar) x =
            if isNeg then (false, sumSoFar - x) else (true, sumSoFar + x)

        [ 1 .. n ]
        |> List.fold action initialValue
        |> snd
        |> log

    [1..10] |> List.map alternatingSum |> ignore
    // printfn "The result of alternating sum is %A" resultAlternatingSum

    let maxNameAndSize list =
        let innerMaxNameAndSize initialValue rest =
            let action masSoFar x =
                if masSoFar.Size < x.Size then x else masSoFar
            rest |> List.fold action initialValue

        match list with
        | [] -> None
        | head :: tail ->
            let max = innerMaxNameAndSize head tail
            Some max

    let list =
        [ { Name = "Felipe"
            Size = 50 }
          { Name = "Daniela"
            Size = 40 } ]

    let resultOfMaxNameAndSize = maxNameAndSize list
    match resultOfMaxNameAndSize with
    | Some v -> printfn "The result of max name and size is %A" v.Name
    | None _ -> printfn "Nothing"
    

    0 // return an integer exit code
