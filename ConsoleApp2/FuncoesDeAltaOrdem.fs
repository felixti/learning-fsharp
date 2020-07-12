module FuncoesDeAltaOrdem

let executarAcaoSobreElementos lista acao =
    lista |> List.iter acao

let imprimirNomes nomes =
    executarAcaoSobreElementos nomes (printfn "Ola %s.")

let multiplicarEImprimirNumero multiplicador numero =
    printfn "%i." (numero * multiplicador)

let imprimirDobroDosNumero multiplicador numeros =
    executarAcaoSobreElementos numeros (fun numero -> multiplicarEImprimirNumero multiplicador numero)

let imprimirListaDeNumeros multiplicador numeros =
    executarAcaoSobreElementos numeros (multiplicarEImprimirNumero multiplicador)
