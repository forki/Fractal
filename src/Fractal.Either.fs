namespace Fractal

[<ReflectedDefinition>]
module Either =
    type Result<'T, 'E> =
    | Success of 'T
    | Failure of 'E list

    /// create a Success with no messages
    let succeed x =
        Success (x)

    /// create a Failure with a message
    let fail msg =
        Failure [msg]

    /// A function that applies either fSuccess or fFailure
    /// depending on the case.
    let either fSuccess fFailure = function
        | Success x -> fSuccess x
        | Failure errors -> fFailure errors

    /// given a function wrapped in a result
    /// and a value wrapped in a result
    /// apply the function to the value only if both are Success
    let applyR f result =
        match f,result with
        | Success f, Success x ->
            (f(x)) |> Success
        | Failure errs, Success _
        | Success _, Failure errs ->
            errs |> Failure
        | Failure errs1, Failure errs2 ->
            errs1 @ errs2 |> Failure

    /// infix version of apply
    let (<*>) = applyR

    /// given a function that transforms a value
    /// apply it only if the result is on the Success branch
    let liftR f result =
        let f' =  f |> succeed
        applyR f' result

    /// given two values wrapped in results apply a function to both
    let lift2R f result1 result2 =
        let f' = liftR f result1
        applyR f' result2

    /// given three values wrapped in results apply a function to all
    let lift3R f result1 result2 result3 =
        let f' = lift2R f result1 result2
        applyR f' result3

    /// given four values wrapped in results apply a function to all
    let lift4R f result1 result2 result3 result4 =
        let f' = lift3R f result1 result2 result3
        applyR f' result4

    /// infix version of liftR
    let (<!>) = liftR

    /// synonym for liftR
    let map = liftR

    /// given an RopResult, call a unit function on the success branch
    /// and pass thru the result
    let successTee<'a,'b> (f : 'a -> unit) (result : Result<'a, 'b>) =
        let fSuccess x : Result<'a, 'b> =
            f x
            Success x
        let fFailure errs : Result<'a, 'b> = Failure errs
        either fSuccess fFailure result

    /// given an RopResult, call a unit function on the failure branch
    /// and pass thru the result
    let failureTee<'a,'b> (f : 'b list -> unit) (result : Result<'a, 'b>)=
        let fSuccess (x) : Result<'a, 'b> = Success (x)
        let fFailure errs : Result<'a, 'b> =
            f errs
            Failure errs
        either fSuccess fFailure result

    /// given an RopResult, in the success case, return the value.
    /// In the failure case, determine the value to return by
    /// applying a function to the errors in the failure case
    let valueOrDefault f result =
        match result with
        | Success (x,_) -> x
        | Failure errors -> f errors

    /// lift an option to a RopResult.
    /// Return Success if Some
    /// or the given message if None
    let failIfNone message = function
        | Some x -> succeed x
        | None -> fail message

    /// given an RopResult option, return it
    /// or the given message if None
    let failIfNoneR message = function
        | Some rop -> rop
        | None -> fail message
