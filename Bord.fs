namespace Bord

open System

type Bord public() =
    let mutable bord = [|[|2;2;2|];[|2;2;2|]|]

    member this.Init public hoge =
        for i = 0 to 2 do
            for j = 0 to 2 do
                bord[i][j] <- 2
        0
    
    member this.Put public x y t =
        bord[x][y] <- t
        0
            
        

