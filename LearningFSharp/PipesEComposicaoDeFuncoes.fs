module PipesEComposicaoDeFuncoes

let multiplicarPor2 = (*) 2

let dobrarValoresDeUmaListaComOperador () =
    [ 0 .. 10 ]
    |> List.filter (fun numero -> numero < 5)
    |> List.map multiplicarPor2

let numeroImpar valor =
    not (valor % 2 = 0)

let converteBooleanoParaTexto valor =
    if valor then "Sim" else "Não"

let verificaSeONumeroEImpar valor =
    let resultado = numeroImpar valor
    converteBooleanoParaTexto resultado


let compor funcao1 funcao2 parametro =
    funcao2 (funcao1 (parametro))

let verificaSeONumeroEImparUsandoCompor =
    numeroImpar >> converteBooleanoParaTexto
    
let somaDepoisMultiplica =
    compor ((+)1) ((*)2)
    
let somaDepoisMultiplicaUsandoOOperador valorParaSomar =
    (+)valorParaSomar >> (*)

let dobraDepoisSoma =
    (+) << (*)2