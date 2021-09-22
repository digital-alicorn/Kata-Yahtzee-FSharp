namespace FSharp.Kata.Yahtzee

module Yahtzee =

    let Ones diceRoll = List.sumBy(fun x -> if x = 1 then x else 0) diceRoll
    
    let Twos diceRoll = List.sumBy(fun x -> if x = 2 then x else 0) diceRoll
    
    let Threes diceRoll = List.sumBy(fun x -> if x = 3 then x else 0) diceRoll
    
    let Fours diceRoll = List.sumBy(fun x -> if x = 4 then x else 0) diceRoll
    
    let Fives diceRoll = List.sumBy(fun x -> if x = 5 then x else 0) diceRoll
    
    let Sixes diceRoll = List.sumBy(fun x -> if x = 6 then x else 0) diceRoll

    let Pair diceRoll = 
        match List.sortDescending diceRoll with 
        | [a; b; _; _; _] when a = b -> a * 2
        | [_; a; b; _; _] when a = b -> a * 2
        | [_; _; a; b; _] when a = b -> a * 2
        | [_; _; _; a; b] when a = b -> a * 2
        | _ -> 0
    
    let TwoPairs diceRoll = 
        match List.sortDescending diceRoll with
        | [a; b; c; d; _] when a = b && c = d -> a * 2 + c * 2
        | [a; b; _; c; d] when a = b && c = d -> a * 2 + c * 2
        | [_; a; b; c; d] when a = b && c = d -> a * 2 + c * 2
        | _ -> 0

    let ThreeOfAKind diceRoll = 
        match List.sortDescending diceRoll with 
        | [a; b; c; _; _] when a = b && b = c -> a * 3
        | [_; a; b; c; _] when a = b && b = c -> a * 3
        | [_; _; a; b; c] when a = b && b = c -> a * 3
        | _ -> 0

    let FourOfAKind diceRoll = 
        match List.sortDescending diceRoll with 
        | [a; b; c; d; _] when a = b && b = c && c = d -> a * 4
        | [_; a; b; c; d] when a = b && b = c && c = d -> a * 4
        | _ -> 0

    let SmallStraight diceRoll =
        match diceRoll with
        | [1; 2; 3; 4; 5] -> 15
        | _ -> 0

    let LargeStraight diceRoll = 
        match diceRoll with
        | [2; 3; 4; 5; 6] -> 20
        | _ -> 0

    let FullHouse diceRoll =
        match List.sortDescending diceRoll with
        | [a; b; c; d; e] when a = b && b <> c && c = d && d = e -> a * 2 + c * 3
        | [a; b; c; d; e] when a = b && b = c && c <> d && d = e -> a * 3 + d * 2
        | _ -> 0

    let Yahtzee diceRoll = 
        match List.sortDescending diceRoll with
        | [a; b; c; d; e] when a = b && b = c && c = d && d = e -> 50
        | _ -> 0

    let Chance (diceRoll : int list) = List.sum diceRoll