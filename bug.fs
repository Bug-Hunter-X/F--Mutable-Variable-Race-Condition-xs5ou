let mutable x = 0
let mutable y = 0

let rec loop () =
    if x < 10 then
        x <- x + 1
    else
        y <- y + 1

    if y < 5 then
        loop ()
    else
        printfn "%d %d" x y

loop ()