module Funtores

type Resultado<'a> =
    | Sucesso of 'a
    | Falha of string


// Mappable Functor
let map funcao valor =
    match valor with
    | Sucesso n -> Sucesso(funcao n)
    | Falha erro -> Falha erro


// Applicatives Functor
let apply funcao valor =
    match funcao, valor with
    | Sucesso f, Sucesso n -> Sucesso(f n)
    | _, Falha erro -> Falha erro
    | Falha erro, _ -> Falha erro


let bind funcao valor =
    match valor with
    | Sucesso n -> funcao n
    | Falha erro -> Falha erro

let map2 funcao = bind (funcao >> Sucesso)

let apply2 funcao valor =
    bind (fun f -> map2 f valor) funcao
