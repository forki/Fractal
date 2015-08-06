namespace Fractal

open System
open System.Collections.Generic
open FunScript
open FunScript.TypeScript
open FunScript.TypeScript.React
open FunScript.TypeScript.Mui

[<ReflectedDefinition>]
[<AutoOpen>]
module Bindings =
    type Element with
        [<FunScript.JSEmitInline("({0}.value)")>]
        member __.value with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

    type EventTarget with
        [<FunScript.JSEmitInline("({0}.value)")>]
        member __.value with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
        [<FunScript.JSEmitInline("({0}.checked)")>]
        member __.check with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"

[<ReflectedDefinition>]
[<AutoOpen>]
module internal Helpers =

    module JS =
        [<JSEmitInline("this")>]
        let this<'O> : 'O = failwith "never"

        [<FunScript.JSEmitInline("require({0})")>]
        let require (path : string) : 'T = failwith "never"

    let obj (lst : array<string * 'a>) =
        let t = Dictionary<string,obj>()
        lst |> Array.iter(fun i -> t.Add(fst i, snd i ))
        t :> obj

    let (==>) a b = a, box<obj> b


[<ReflectedDefinition>]
[<AutoOpen>]
module Component =
    type ClipboardEvent = React.ClipboardEvent
    type DragEvent = React.DragEvent
    type FocusEvent = React.FocusEvent
    type FormEvent = React.FormEvent
    type KeyboardEvent = React.KeyboardEvent
    type MouseEvent = React.MouseEvent
    type TouchEvent = React.TouchEvent
    type UIEvent = React.UIEvent
    type WheelEvent = React.WheelEvent

    type Reference<'P,'S> = React.Reference<'P,'S>
    type DOMElement<'A> = React.DOMElement<'A>
    type Nothing () = class end

    type FractalComponent<'T,'S> () =
        interface ComponentSpec<'T, 'S>
        interface Component<'T, 'S>

    type FractalDefinition<'P, 'S> =
        | Render of (FractalComponent<'P, 'S> -> ReactElement<obj>)
        | ComponentWillMount of (FractalComponent<'P,'S> -> unit)
        | ComponentDidMount of (FractalComponent<'P,'S> -> unit)
        | ComponentWillReceiveProps of ('P -> FractalComponent<'P,'S> -> unit)
        | ShouldComponentUpdate of ('P -> 'S -> FractalComponent<'P,'S> -> bool)
        | ComponentWillUpdate of ('P -> 'S -> FractalComponent<'P,'S>  -> unit)
        | ComponentDidUpdate of ('P -> 'S -> FractalComponent<'P,'S> -> unit)
        | ComponentWillUnmount of (FractalComponent<'P,'S> -> unit)
        | GetInitialState of (FractalComponent<'P,'S> -> 'S)

    let internal defToTuple d =
        match d with
        | Render v -> "render" ==> (fun _ -> JS.this |> v)
        | ComponentWillMount v -> "componentWillMount" ==> (fun _ -> JS.this |> v)
        | ComponentDidMount v -> "componentDidMount" ==> (fun _ -> JS.this |> v )
        | ComponentWillReceiveProps v -> "componentWillReceiveProps" ==> (fun a _ -> JS.this |> v a)
        | ShouldComponentUpdate v -> "shouldComponentUpdate" ==> (fun p s _ -> JS.this |> v p s)
        | ComponentWillUpdate v -> "componentWillUpdate" ==> (fun p s _ -> JS.this |> v p s)
        | ComponentDidUpdate v -> "componentDidUpdate" ==> (fun p s _ -> JS.this v p s)
        | ComponentWillUnmount v -> "componentWillUnmount" ==> (fun _ -> JS.this |> v )
        | GetInitialState v -> "getInitialState" ==> (fun _ -> JS.this |> v )

    let internal defsToObj lst =
        lst |> Array.map (defToTuple) |> obj

[<ReflectedDefinition>]
[<AutoOpen>]
module Dynamic =
        [<JSEmitInline("({0}[{1}])")>]
        let (?) (ob: obj) (prop: string): 'a = failwith "never"

        [<JSEmitInline("({0}[{1}] = {2})")>]
        let (?<-) (ob: obj) (prop: string) (value: 'a): unit = failwith "never"

[<ReflectedDefinition>]
module Fractal =
    let internal createElement (props : 'P) (cmponent : ComponentClass<'P>) =
        Globals.createElement(cmponent, props, null)

    let createComponent<'P,'S> (lst : FractalDefinition<'P, 'S> []) props=
        let t = lst |> defsToObj |> unbox<ComponentSpec<'P,'S>>
        t.setChildContext ()
        t.setChildContextTypes ()
        t |> Globals.createClass
        |> createElement props

    let findDOMNode (reference : Component<_,_>) =
        Globals.findDOMNode(reference)

    let render (id : string) (cmponent : ReactElement<_>) =
         Globals.render(cmponent, Globals.document.getElementById(id))
         |> ignore


[<ReflectedDefinition>]
module Message =
    type Subscription = {
        topic : string
        unsubscribe : unit -> unit
    }

    let subscribe topic (cb : 'a -> unit) =
        createEmpty<PostalSubscriptionDefinition>()
        |> fun n -> n.topic <- topic
                    n.callback <- Func<_,_,_>(fun n _ -> cb (n |> unbox<'a>) :> obj)
                    n
        |> Globals.postal.subscribe
        |> unbox<Subscription>

    let publish topic data =
        createEmpty<PostalEnvelope> ()
        |> fun n ->
            n.topic <- topic
            n.data <- data
            n
        |> Globals.postal.publish
        |> ignore

[<ReflectedDefinition>]
module Request =
    let AsyncGetJSON<'T>  (req : Net.WebRequest) = async {
        let req: FunScript.Core.Web.WebRequest = unbox req
        req.Headers.Add("Accept", "application/json")
        let! res = req.AsyncGetResponse ()
        let stream =  res.GetResponseStream()
        let data = System.Text.Encoding.UTF8.GetString stream.Contents
        try
            let d = Globals.JSON.parse data
            return (unbox<'T>(d) |> Either.succeed )
        with
        | exn -> return Either.Failure [exn]
    }

    let AsyncPostJSON<'T,'R> (data: 'T) (r : Net.WebRequest) = async {
        let req: FunScript.Core.Web.WebRequest = unbox r
        req.Headers.Add("Accept", "application/json")
        req.Headers.Add("Content-Type", "application/json")
        req.Method <- "POST"
        let str = Globals.JSON.stringify data
        let data = System.Text.Encoding.UTF8.GetBytes str
        let stream = req.GetRequestStream()
        stream.Write (data, 0, data.Length )
        let! res = req.AsyncGetResponse ()
        let stream =  res.GetResponseStream()
        let data = System.Text.Encoding.UTF8.GetString stream.Contents
        try
            let d = Globals.JSON.parse data
            return (unbox<'R>(d) |> Either.succeed )
        with
        | exn -> return Either.Failure [exn]

    }

[<ReflectedDefinition>]
module Router =

    let add (path : string) (handler : 'a -> unit) =
        Globals.routie.Invoke(path, handler |> unbox<Function>)

    let navigate (path : string) =
        Globals.routie.Invoke(path) 
