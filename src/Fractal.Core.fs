namespace Fractal

open System
open System.Collections.Generic
open FunScript
open FunScript.TypeScript
open FunScript.TypeScript.React
open FunScript.TypeScript.Mui

[<ReflectedDefinition>]
[<AutoOpen>]
module Helpers =
    type Element with
        [<FunScript.JSEmitInline("({0}.value)")>]
        member __.value with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

    type EventTarget with
        [<FunScript.JSEmitInline("({0}.value)")>]
        member __.value with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
        [<FunScript.JSEmitInline("({0}.checked)")>]
        member __.check with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"

    module JS =
        [<JSEmitInline("this")>]
        let this<'O> :  'O = failwith "never"

        [<FunScript.JSEmitInline("require({0})")>]
        let require (path : string) : 'T = failwith "never"

    let obj (lst : list<string * 'a>) =
        let t = Dictionary<string,obj>()
        lst |> List.iter(fun i -> t.Add(fst i, snd i ))
        t :> obj

    let (==>) a b = a, box<obj> b


[<ReflectedDefinition>]
[<AutoOpen>]
module Fractal =
    type Nothing () = class end

    type ReactComponent<'T,'S> () =
        interface ComponentSpec<'T, 'S>
        interface Component<'T, 'S>

    module React =
        let defineComponent<'T, 'S> (render : ReactComponent<'T, 'S> -> DOMElement<obj> ) =
            let comp = ReactComponent<'T, 'S>()
            comp.``render <-``(fun _ -> JS.this |> render |> unbox<ReactElement<obj>>)
            comp

        let componentWillMount (cb : unit -> unit) (cmponent : ReactComponent<_,_>) =
            cmponent.``componentWillMount <-``(fun _ -> cb ())
            cmponent

        let componentDidMount (cb : unit -> unit) (cmponent : ReactComponent<_,_>) =
            cmponent.``componentDidMount <-``(fun _ -> cb ())
            cmponent

        let componentWillReceiveProps (cb : 'P -> unit) (cmponent : ReactComponent<'P,_>) =
            cmponent.``componentWillReceiveProps <-``(fun a _ -> cb a)
            cmponent

        let shouldComponentUpdate (cb : 'P -> 'S -> bool) (cmponent : ReactComponent<'P,'S>) =
            cmponent.``shouldComponentUpdate <-``(fun p s _ -> cb p s)
            cmponent

        let componentWillUpdate (cb : 'P -> 'S -> unit) (cmponent : ReactComponent<'P,'S>) =
            cmponent.``componentWillUpdate <-``(fun p s _ -> cb p s)
            cmponent

        let componentDidUpdate (cb : 'P -> 'S -> unit) (cmponent : ReactComponent<'P,'S>) =
            cmponent.``componentDidUpdate <-``(fun p s _ -> cb p s)
            cmponent

        let componentWillUnmount (cb : unit -> unit) (cmponent : ReactComponent<_,_>) =
            cmponent.``componentWillUnmount <-``(fun _ -> cb ())
            cmponent

        let getInitialState (cb : unit -> 'S) (cmponent : ReactComponent<_,'S>) =
            cmponent.``getInitialState <-``(fun _ -> cb ())
            cmponent

        let addMaterial (material : mui, tm : ThemeManager) (cmponent : ReactComponent<_,_>) =
            cmponent.``getChildContext <-``(fun _ -> obj ["muiTheme" ==> tm.getCurrentTheme()] )
            cmponent.childContextTypes <- ( obj ["muiTheme" ==> Globals.PropTypes._object.isRequired ] )
            cmponent

        let createComponent (cmponent : ReactComponent<_,_>) =
            cmponent |> unbox<ComponentSpec<_,_>> |> Globals.createClass

        let render (id : string) (cmponent : ClassicElement<_>) =
             Globals.render(cmponent, Globals.document.getElementById(id))
             |> ignore

    module Message =
        let subscribe topic (cb : 'a -> unit) =
            createEmpty<PostalSubscriptionDefinition>()
            |> fun n -> n.topic <- topic
                        n.callback <- Func<_,_,_>(fun n _ -> cb (n |> unbox<'a>) :> obj)
                        n
            |> Globals.postal.subscribe
            |> ignore

        let publish topic data =
            createEmpty<PostalEnvelope> ()
            |> fun n ->
                n.topic <- topic
                n.data <- data
                n
            |> Globals.postal.publish
            |> ignore
