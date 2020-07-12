namespace Modulos

[<RequireQualifiedAccess>]
module FuncoesDeEscrita =
    let escrever nome = printfn "seu nome é: %s" nome

[<RequireQualifiedAccess>]
module FuncoesDeEscritaDeNumeros =
    let escrever idade =
        printfn "sua idade é: %i" idade