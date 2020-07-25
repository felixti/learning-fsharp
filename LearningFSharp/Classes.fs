module Classes

type IPessoa =
    abstract Nome: string
    abstract Sobrenome: string
    abstract NomeCompleto: string

type Pessoa(nome: string, sobrenome: string) =
    let mutable _nome = nome
    let mutable _sobrenome = sobrenome

    member this.Nome
        with get () = _nome
        and set value = _nome <- value

    member this.Sobrenome
        with get () = _sobrenome
        and set value = _sobrenome <- value

let felipe = Pessoa("Felipe", "Felix")

felipe.Nome <- "Augusto Felix"

type PessoaComAutoProperty(nome: string, sobrenome: string) =
    member val Nome = nome with get, set
    member val Sobrenome = sobrenome with get, set

let felix = PessoaComAutoProperty("Felipe Augusto", "Felix")

felix.Nome <- "Felipe A."

type PessoaComIdade(idade: int) =
    let mutable _maioridade = false
    do _maioridade <- idade >= 18

    member val Idade = idade with get, set
    member val Maioridade = _maioridade

type PessoaComHeranca(nome: string, sobrenome: string, idade: int) =
    inherit PessoaComAutoProperty(nome, sobrenome)
    let mutable _maioridade = false
    do _maioridade <- idade >= 18

    member val Idade = idade with get, set
    member val Maioridade = _maioridade

type PessoaComInterface (nome:string, sobrenome:string) =
    member val Nome = nome with get, set
    member val Sobrenome = sobrenome with get, set
    
    interface IPessoa with
        member this.Nome = nome
        member this.Sobrenome = sobrenome
        member this.NomeCompleto = sprintf "%s %s" nome sobrenome
        
        
let gabriel4 = PessoaComInterface( "Gabriel" , "Schade" )
let nomeCompleto = (gabriel4 :> IPessoa).NomeCompleto
        