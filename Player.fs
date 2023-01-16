namespace ConsoleGame

open System

type Player public(name:string) =
    member val playerName = name with get,set
    
