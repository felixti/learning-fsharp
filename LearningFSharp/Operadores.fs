module Operadores

open System
open Funtores

let (^) string1 string2 =
    sprintf "%s%s" string1 string2


let (!!) string = String.IsNullOrEmpty string

let (<~) (string: string) substring =
    (!! substring || string.Contains substring)


let (><) lista1 lista2 =
    lista1
    |> Set.ofList
    |> Set.intersect (Set.ofList lista2)
    |> Set.toList

let (<!>) = map

let (<*>) = apply

let (|>=) valor funcao =
    valor
    |> bind funcao

let (>>=) funcao1 funcao2 =
    funcao1
    >> bind funcao2