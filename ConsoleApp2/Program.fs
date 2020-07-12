// Learn more about F# at http://fsharp.org

open System
open PeriodoDeTempo

[<EntryPoint>]
let main argv =
    // Problema a ser resolvido: Acoplamento Temportal /  Dependência de Ordem
    // Solução: Imutabilidade
    let periodo: Periodo =
        { DataInicial = DateTime.Parse "08/20/2016"
          DataFinal = DateTime.Parse "08/31/2016" }

    let datasParaTeste =
        [| DateTime.Parse "08/18/2016"
           DateTime.Parse "08/22/2016"
           DateTime.Parse "09/01/2016" |]

    // Problema a ser resolvido: Efeitos Colaterais
    // Solução: Expressões ao invés de declarações
    for data in datasParaTeste do
        let dataEstaNoPeriodo = verificarSeDataEstaEntreOPeriodo periodo data
        printfn "%b" dataEstaNoPeriodo

    let exemploUsoDeExpressao numero =
        let resultado =
            if numero % 2 = 0 then 2 else 0
        printfn "%i" resultado

    exemploUsoDeExpressao 20

    // Problema a ser resolvido:
    // Solução: Funções Aninhadas
    let escreverNumeroEParOuImpar numero =
        let verificaSeONumeroEPar = numero % 2 = 0
        let escreverNumeroPar () = printfn "O número %i é par" numero
        let escreverNumerImpar () = printfn "O número %i é impar" numero
        if verificaSeONumeroEPar then escreverNumeroPar () else escreverNumerImpar ()

    escreverNumeroEParOuImpar 21

    FuncoesDeAltaOrdem.imprimirListaDeNumeros 2 [ 1; 2; 3; 5; 6 ]
    
    // Pipes
    let result = PipesEComposicaoDeFuncoes.dobrarValoresDeUmaListaComOperador()
    printfn "O resultado é: %i." result.Length
    
    // Composição de função e Currying
    let resultado = PipesEComposicaoDeFuncoes.somaDepoisMultiplicaUsandoOOperador 1 1 <| 2
    printfn "O resultado é: %i." resultado
    
    0
