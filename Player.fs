namespace Player

open System
open System.IO

type Player public(name:string) =
    member val playerName = name with get,set
    