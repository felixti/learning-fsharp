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
// let inteiroEBool = 2, true
let outroInteiroEBool = -1, false

let tupla1 = 1, 2, 3
let tupla2 = 1, true, "Gabriel"
let tupla3 = 3, false
let tupla4 = 1, 2,3, false, "Teste"
let tupla5 = (+), false
let tupla6 = false, 2

// Tipos: Records
type inteiroEBool = { valorInteiro: int; valorBooleano: bool }

let inteiroEBool = { valorInteiro = 2; valorBooleano = true }

let { valorInteiro = inteiro; valorBooleano = bool } = inteiroEBool
let inteiroEBoolComRecords = { valorInteiro = 2; valorBooleano = true }
let { valorInteiro = novoInteiro; valorBooleano = novoBool  } = inteiroEBoolComRecords

let segundInteiroEBool =
    { valorInteiro = novoInteiro + 10
      valorBooleano = not novoBool }
    
let terceiroInteiroEBool = { inteiroEBoolComRecords with valorBooleano = false }


// Tipos: Discriminated unions
type InteiroOuBool =
    | Inteiro of int
    | Bool of bool

type Pessoa = { Nome: string; Idade: int }

type DiscriminatedComplexos =
    | IntOuBool of InteiroOuBool
    | PessoaDoDiscriminated of Pessoa
    | Tupla of int * string

type Resultado =
    | Sucesso
    | Erros of string list
    
let resultadoDeSucesso = Sucesso
let resultadoComErros = Erros ["Inválido"]

// let inteiroDoDiscriminated = Inteiro 1
// let intOuBool = IntOuBool inteiroDoDiscriminated
let pessoa = PessoaDoDiscriminated { Nome= "Gabriel" ; Idade = 26 }
let tupla = Tupla ( 3 , "Gabriel" )

let inteiroDoDiscriminated = Inteiro 1
let boolDoDiscriminated = Bool false

let escreveInteiroOuBool inteiroOuBooleano =
    match inteiroOuBooleano with
    | Inteiro valorInteiro -> printfn "%i" valorInteiro
    | Bool valorBooleano -> printfn "%b" valorBooleano
    
escreveInteiroOuBool boolDoDiscriminated
escreveInteiroOuBool inteiroDoDiscriminated


type Nome = | Nome of string
type Sobrenome = | Sobrenome of string
type Client = { Id: int ; Nome: Nome; Sobrenome: Sobrenome; }

let criarCliente id nome sobrenome =
    { Id = id; Nome = nome; Sobrenome = sobrenome; }

let id = 1
let nome = Nome "Felipe"
let sobrenome = Sobrenome "Felix"

let cliente = criarCliente id nome sobrenome
let (Nome nome2) = nome

let testeComValor = Some "Teste com valor"
let testeSemValor = None

let lenght =
    match testeComValor with
    | Some texto -> texto.Length
    | None -> 0


[<Measure>] type km
[<Measure>] type m

[<Measure>] type h
[<Measure>] type s

let velocidadeDoCarro = 130<km/h>
let velocidadeDoSom = 340.29<m/s>

[<Measure>] type velocidade = km/h
[<Measure>] type velocidade2 = m/s

let quilometros = 100.0<km>
let metros = 1000.0<m>
let fatorConversaoQuilometroPorMetro = 0.001<km/m>
let metrosConvertidos = metros * fatorConversaoQuilometroPorMetro
let soma = (+) quilometros metrosConvertidos

let elevarAoQuadrado (valor: int<_>) =
    valor * valor

