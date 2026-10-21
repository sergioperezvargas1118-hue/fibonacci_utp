//
// Tarea para el Jueves
//
// Usando listas y fold, vamos a crear una funcion
// que me retorned la secuencia de los n primeros numeros
// de fibonacci.
//
// Hints: Usar fold, CONS, y List.rev
//


let fibonacci n =
    match n with
    | n when n <= 0 -> []
    | 1 -> [0]
    | _ ->
        [3 .. n]
        |> List.fold (fun acc _ -> (acc.[0] + acc.[1]) :: acc) [1; 0]
        |> List.rev


let resultado = fibonacci 6 

resultado |> List.iter(fun x -> printfn$"{x}")
    


