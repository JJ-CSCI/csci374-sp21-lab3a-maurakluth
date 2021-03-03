module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    v * 25.4;;

let footToInch x =
    x * 12.0;;

let yardToFoot v =
    v * 3.0;;

let mileToYard mile =
    mile * 1760.0;;

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    y |> yardToFoot |> footToInch |> inchToMillimeter;;

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
    fun x->x 
      x / 1000.0;;

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    n |> divBy1000;;

let meterToKilometer =
    fun x->x 
      x * 1000;;

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    fun x->x
      x |> millimeterToMeter |> meterToKilometer;;

let inchToMeter =
    fun x->x 
      x |> inchToMillimeter |> millimeterToMeter;;

let yardToKilometer =
    fun x->x
      x |> yardToMillimeter |> millimeterToKilometer;;

let mileToMeter =
    fun x->x 
      x |> mileToYard |> yardToMillimeter |> millimeterToMeter;;


// Define following weight unit transformations
let ounceToGram v =
    v * 28.3;;

let poundToOunce p =
    p * 16.0;;

let shortTonToPound t =
    t *2000.0;;


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    g |> divBy1000;;

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun x->x
      x |> gramToKilogram |> divBy1000;;

let poundToKilogram =
    fun x->x 
      x |> poundToOunce |> ounceToGram |> gramToKilogram;;

let shortTonToMetricTon =
    fun x->x
      x |> shortTonToPound |> poundToOunce |> ounceToGram |> gramToMetricTon;;
