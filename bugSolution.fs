let xLock = new System.Object()
let yLock = new System.Object()

let mutable x = 0
let mutable y = 0

let rec loop () =
    lock xLock (
        if x < 10 then
            x <- x + 1
    )

    lock yLock (
        if y < 5 then
            loop ()
        else
            printfn "%d %d" x y
    )

loop ()