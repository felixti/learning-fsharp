module ConsoleApp2.Listas

type Nome = Nome of string

type Cliente =
    { Id: int
      Nome: Nome }

let rec excluirClienteComId id jaPercorridos (lista: Cliente list) =
    match lista with
    | head :: tail when head.Id = id -> jaPercorridos @ tail
    | head :: tail -> excluirClienteComId id (head :: jaPercorridos) tail
    | [] -> jaPercorridos
