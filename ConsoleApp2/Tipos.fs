module Tipos

let verificSeONumeroPar numero =
    if numero % 2 = 0
        then "Par"
        else "Ímpar"

let verificaSeONumeroParComPatternMatching  numero =
    match numero % 2 = 0 with
    | true -> "Par"
    | false -> "Impar"

let verificaSeONumeroParOuZeroComPatternMatching  numero =
    match numero with
    | 0 -> "Zero"
    | numero when numero % 2 = 0 -> "Par"
    | _ -> "Impar"
    
// Não utilizar mutable, somente como fonte de aprendizado da linguagem
let fatorial numeroParaCalcularFatorial =
    let mutable acumulador = numeroParaCalcularFatorial
    for numero = numeroParaCalcularFatorial-1 downto 1 do
        acumulador <- acumulador * numero
    acumulador
    
// Recursão usando funcao sensacional!!!
let rec fatorialComPatternMatching numero =
    match numero with
    | 0 | 1 -> 1
    | 2 -> 2
    | _ -> numero * fatorialComPatternMatching (numero-1)
    
let fatorialComFuncaoAninhada numero =
    let rec fatorial numero =
        match numero with
        | 0 | 1 -> 1
        | 2 -> 2
        | _ -> numero * fatorialComPatternMatching (numero-1)
        
    fatorial numero
    
// Tipos: Abreviacoes e Apelidos para tipos ja existentes
type Numero = int
type Codigo = string
type OperacaoMatematica = int -> int -> int

// Tipos: Tuplas
let inteiroEBool = 2, true
let outroInteiroEBool = -1, false

let tupla1 = 1, 2, 3
let tupla2 = 1, true, "Gabriel"
let tupla3 = 3, false
let tupla4 = 1, 2,3, false, "Teste"
let tupla5 = (+), false
let tupla6 = false, 2

// Tipos: Records
type inteiroEBool = { valorInteiro: int; valorBooleano: bool }
let inteiroEBoolComRecords = { valorInteiro = 2; valorBooleano = true }
let { valorInteiro = inteiro; valorBooleano = bool  } = inteiroEBoolComRecords

let InteiroEBoolComWith = { inteiroEBoolComRecords with valorBooleano = false }

// Tipos: Discriminated unions
type InteiroOuBool =
    | Inteiro of int
    | Bool of bool

type Pessoa = { Nome: string; Idade: int }

type DiscriminatedComplexos =
    | IntOuBool of InteiroOuBool
    | Pessoa of Pessoa
    | Tupla of int * string

