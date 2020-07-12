namespace OutroNamespace
open Modulos

module FuncoesDeEscritaUtilizandoOutrosModulos =
    let escrever nome idade =
        FuncoesDeEscrita.escrever nome
        FuncoesDeEscritaDeNumeros.escrever idade