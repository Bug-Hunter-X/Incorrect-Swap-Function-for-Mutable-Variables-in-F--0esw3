let swap x y = 
    let temp = x
    x <- y
    y <- temp

let x = ref 10
let y = ref 20

swap x.Value y.Value
printf "%d %d" x.Value y.Value

//Correct Solution
let swapCorrect x y = (y,x)

let a = 10
let b = 20
let (a,b) = swapCorrect a b
printf "%d %d" a b