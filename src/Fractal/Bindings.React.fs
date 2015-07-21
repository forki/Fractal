namespace FunScript.TypeScript.React

type AbstractView = interface end


type AnonymousType443 = interface end


type AnonymousType444<'P, 'S> = interface end


type AnonymousType445<'P, 'S> = interface end


type AnonymousType446 = interface end


type AnonymousType447 = interface end


type AnonymousType448 = interface end


type CSSProperties = interface end


type ChildContextProvider<'CC> = interface end


type ComponentClass<'P> = interface end


type ComponentLifecycle<'P, 'S> = interface end


type Factory<'P> = interface end


type Props<'T> = interface end


type Globals = interface end


type ReactDOM = interface end


type ReactElement<'P> = interface end


type ReactPropTypes = interface end


type SyntheticEvent = interface end


type Touch = interface end


type TouchList = interface end


type ValidationMap<'T> = interface end


type Validator<'T> = interface end


type ValidatorDelegate<'T> = delegate of 'T * string * string -> FunScript.TypeScript.Error


type anyren = interface end


type ClassicComponentClass<'P> =
        inherit ComponentClass<'P>


type ClassicElement<'P> =
        inherit ReactElement<'P>


type ClassicFactory<'P> =
        inherit Factory<'P>


type ClipboardEvent =
        inherit SyntheticEvent


type Component<'P, 'S> =
        inherit ComponentLifecycle<'P, 'S>


type DragEvent =
        inherit SyntheticEvent


type EventHandler<'E when 'E :> SyntheticEvent > = interface end


type FocusEvent =
        inherit SyntheticEvent


type FormEvent =
        inherit SyntheticEvent


type KeyboardEvent =
        inherit SyntheticEvent


type Mixin<'P, 'S> =
        inherit ComponentLifecycle<'P, 'S>


type MouseEvent =
        inherit SyntheticEvent


type Requireable<'T> =
        inherit Validator<'T>


type TouchEvent =
        inherit SyntheticEvent


type UIEvent =
        inherit SyntheticEvent


type WheelEvent =
        inherit SyntheticEvent


type ClassicComponent<'P, 'S> =
        inherit Component<'P, 'S>


type ClipboardEventHandler =
        inherit EventHandler<ClipboardEvent>


type ComponentSpec<'P, 'S> =
        inherit Mixin<'P, 'S>


type DOMElement<'P> =
        inherit ClassicElement<'P>


type DOMFactory<'P> =
        inherit ClassicFactory<'P>


type DragEventHandler =
        inherit EventHandler<DragEvent>


type FocusEventHandler =
        inherit EventHandler<FocusEvent>


type FormEventHandler =
        inherit EventHandler<FormEvent>


type KeyboardEventHandler =
        inherit EventHandler<KeyboardEvent>


type MouseEventHandler =
        inherit EventHandler<MouseEvent>


type TouchEventHandler =
        inherit EventHandler<TouchEvent>


type UIEventHandler =
        inherit EventHandler<UIEvent>


type WheelEventHandler =
        inherit EventHandler<WheelEvent>


type DOMComponent<'P> =
        inherit ClassicComponent<'P, obj>


type DOMAttributes =
        inherit Props<DOMComponent<obj>>


type HTMLAttributes =
        inherit DOMAttributes


type SVGAttributes =
        inherit DOMAttributes


namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensionsReact =


    type FunScript.TypeScript.React.AbstractView with

            [<FunScript.JSEmitInline("({0}.styleMedia)")>]
            member __.styleMedia with get() : FunScript.TypeScript.StyleMedia = failwith "never" and set (v : FunScript.TypeScript.StyleMedia) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.document)")>]
            member __.document with get() : FunScript.TypeScript.Document = failwith "never" and set (v : FunScript.TypeScript.Document) : unit = failwith "never"

    type FunScript.TypeScript.React.AnonymousType444<'P, 'S> with

            [<FunScript.JSEmitInline("({0}[{1}])")>]
            member __.Item with get(i : string) : FunScript.TypeScript.React.Component<obj, obj> = failwith "never" and set (i : string) (v : FunScript.TypeScript.React.Component<obj, obj>) : unit = failwith "never"


    type FunScript.TypeScript.React.AnonymousType445<'P, 'S> with

            [<FunScript.JSEmitInline("({0}[{1}])")>]
            member __.Item with get(i : string) : obj = failwith "never" and set (i : string) (v : obj) : unit = failwith "never"


    type FunScript.TypeScript.React.AnonymousType446 with

            [<FunScript.JSEmitInline("({0}.__html)")>]
            member __.__html with get() : string = failwith "never" and set (v : string) : unit = failwith "never"


    type FunScript.TypeScript.React.CSSProperties with

            [<FunScript.JSEmitInline("({0}.boxFlex)")>]
            member __.boxFlex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.boxFlexGroup)")>]
            member __.boxFlexGroup with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.columnCount)")>]
            member __.columnCount with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.flex)")>]
            member __.flex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.flexGrow)")>]
            member __.flexGrow with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.flexShrink)")>]
            member __.flexShrink with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fontWeight)")>]
            member __.fontWeight with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.lineClamp)")>]
            member __.lineClamp with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.lineHeight)")>]
            member __.lineHeight with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.opacity)")>]
            member __.opacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.order)")>]
            member __.order with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.orphans)")>]
            member __.orphans with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.widows)")>]
            member __.widows with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.zIndex)")>]
            member __.zIndex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.zoom)")>]
            member __.zoom with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fillOpacity)")>]
            member __.fillOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeOpacity)")>]
            member __.strokeOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeWidth)")>]
            member __.strokeWidth with get() : float = failwith "never" and set (v : float) : unit = failwith "never"


    type FunScript.TypeScript.React.ChildContextProvider<'CC> with

            [<FunScript.JSEmitInline("({0}.getChildContext())")>]
            member __.getChildContext() : 'CC = failwith "never"
            [<FunScript.JSEmitInline("({0}.getChildContext = {1})")>]
            member __.``getChildContext <-``(func : System.Func<'CC>) : unit = failwith "never"


    type FunScript.TypeScript.React.ClassicComponent<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.replaceState({1}, {?2}))")>]
            member __.replaceState(nextState : 'S, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.replaceState = {1})")>]
            member __.``replaceState <-``(func : System.Func<'S, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode())")>]
            member __.getDOMNode<'TElement when 'TElement :> FunScript.TypeScript.Element>() : 'TElement = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode = {1})")>]
            member __.``getDOMNode <-``<'TElement when 'TElement :> FunScript.TypeScript.Element>(func : System.Func<'TElement>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode())")>]
            member __.getDOMNode() : FunScript.TypeScript.Element = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode = {1})")>]
            member __.``getDOMNode <-``(func : System.Func<FunScript.TypeScript.Element>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.isMounted())")>]
            member __.isMounted() : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.isMounted = {1})")>]
            member __.``isMounted <-``(func : System.Func<bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState())")>]
            member __.getInitialState() : 'S = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState = {1})")>]
            member __.``getInitialState <-``(func : System.Func<'S>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setProps({1}, {?2}))")>]
            member __.setProps(nextProps : 'P, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setProps = {1})")>]
            member __.``setProps <-``(func : System.Func<'P, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.replaceProps({1}, {?2}))")>]
            member __.replaceProps(nextProps : 'P, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.replaceProps = {1})")>]
            member __.``replaceProps <-``(func : System.Func<'P, System.Func<obj>, unit>) : unit = failwith "never"


    type FunScript.TypeScript.React.ClassicComponentClass<'P> with

            [<FunScript.JSEmitInline("(new {0}({?1}, {?2}))")>]
            member __.Create(?props : 'P, ?context : obj) : FunScript.TypeScript.React.ClassicComponent<'P, obj> = failwith "never"
            [<FunScript.JSEmitInline("(new {0} = {1})")>]
            member __.``Create <-``(func : System.Func<'P, obj, FunScript.TypeScript.React.ClassicComponent<'P, obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps())")>]
            member __.getDefaultProps() : 'P = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps = {1})")>]
            member __.``getDefaultProps <-``(func : System.Func<'P>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.displayName)")>]
            member __.displayName with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.ClassicElement<'P> with

            [<FunScript.JSEmitInline("({0}.type)")>]
            member __._type with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.ClassicFactory<'P> with

            [<FunScript.JSEmitInline("({0}({?1}))")>]
            member __.Invoke(?props : 'P) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})")>]
            member __.``Invoke <-``(func : System.Func<'P, FunScript.TypeScript.React.ClassicElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}, {2...}))")>]
            member __.Invoke(props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"



    type FunScript.TypeScript.React.ClipboardEvent with

            [<FunScript.JSEmitInline("({0}.clipboardData)")>]
            member __.clipboardData with get() : FunScript.TypeScript.DataTransfer = failwith "never" and set (v : FunScript.TypeScript.DataTransfer) : unit = failwith "never"



    type FunScript.TypeScript.React.Component<'P, 'S> with

            [<FunScript.JSEmitInline("(new React.Component({?0}, {?1}))")>]
            static member Create(?props : 'P, ?context : obj) : FunScript.TypeScript.React.Component<'P, 'S> = failwith "never"
            [<FunScript.JSEmitInline("(new React.Component = {0})")>]
            static member ``Create <-``(func : System.Func<'P, obj, FunScript.TypeScript.React.Component<'P, 'S>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState({1}, {?2}))")>]
            member __.setState(f : System.Func<'S, 'P, 'S>, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState = {1})")>]
            member __.``setState <-``(func : System.Func<System.Func<'S, 'P, 'S>, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState({1}, {?2}))")>]
            member __.setState(state : 'S, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState = {1})")>]
            member __.``setState <-``(func : System.Func<'S, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forceUpdate())")>]
            member __.forceUpdate() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forceUpdate = {1})")>]
            member __.``forceUpdate <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.props)")>]
            member __.props with get() : 'P = failwith "never" and set (v : 'P) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.state)")>]
            member __.state with get() : 'S = failwith "never" and set (v : 'S) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.context)")>]
            member __.context with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.refs)")>]
            member __.refs with get() : FunScript.TypeScript.React.AnonymousType444<'P, 'S> = failwith "never" and set (v : FunScript.TypeScript.React.AnonymousType444<'P, 'S>) : unit = failwith "never"



    type FunScript.TypeScript.React.ComponentClass<'P> with

            [<FunScript.JSEmitInline("(new {0}({?1}, {?2}))")>]
            member __.Create(?props : 'P, ?context : obj) : FunScript.TypeScript.React.Component<'P, obj> = failwith "never"
            [<FunScript.JSEmitInline("(new {0} = {1})")>]
            member __.``Create <-``(func : System.Func<'P, obj, FunScript.TypeScript.React.Component<'P, obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.propTypes)")>]
            member __.propTypes with get() : FunScript.TypeScript.React.ValidationMap<'P> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<'P>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contextTypes)")>]
            member __.contextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.childContextTypes)")>]
            member __.childContextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defaultProps)")>]
            member __.defaultProps with get() : 'P = failwith "never" and set (v : 'P) : unit = failwith "never"



    type FunScript.TypeScript.React.ComponentLifecycle<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.componentWillMount())")>]
            member __.componentWillMount() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillMount = {1})")>]
            member __.``componentWillMount <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidMount())")>]
            member __.componentDidMount() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidMount = {1})")>]
            member __.``componentDidMount <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillReceiveProps({1}, {2}))")>]
            member __.componentWillReceiveProps(nextProps : 'P, nextContext : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillReceiveProps = {1})")>]
            member __.``componentWillReceiveProps <-``(func : System.Func<'P, obj, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shouldComponentUpdate({1}, {2}, {3}))")>]
            member __.shouldComponentUpdate(nextProps : 'P, nextState : 'S, nextContext : obj) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.shouldComponentUpdate = {1})")>]
            member __.``shouldComponentUpdate <-``(func : System.Func<'P, 'S, obj, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUpdate({1}, {2}, {3}))")>]
            member __.componentWillUpdate(nextProps : 'P, nextState : 'S, nextContext : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUpdate = {1})")>]
            member __.``componentWillUpdate <-``(func : System.Func<'P, 'S, obj, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidUpdate({1}, {2}, {3}))")>]
            member __.componentDidUpdate(prevProps : 'P, prevState : 'S, prevContext : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidUpdate = {1})")>]
            member __.``componentDidUpdate <-``(func : System.Func<'P, 'S, obj, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUnmount())")>]
            member __.componentWillUnmount() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUnmount = {1})")>]
            member __.``componentWillUnmount <-``(func : System.Func<unit>) : unit = failwith "never"

    type FunScript.TypeScript.React.ComponentSpec<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.render())")>]
            member __.render() : FunScript.TypeScript.React.ReactElement<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.render = {1})")>]
            member __.``render <-``(func : System.Func<FunScript.TypeScript.React.ReactElement<obj>>) : unit = failwith "never"



    type FunScript.TypeScript.React.DOMAttributes with

            [<FunScript.JSEmitInline("({0}.onCopy)")>]
            member __.onCopy with get() : FunScript.TypeScript.React.ClipboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.ClipboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onCut)")>]
            member __.onCut with get() : FunScript.TypeScript.React.ClipboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.ClipboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onPaste)")>]
            member __.onPaste with get() : FunScript.TypeScript.React.ClipboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.ClipboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onKeyDown)")>]
            member __.onKeyDown with get() : FunScript.TypeScript.React.KeyboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.KeyboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onKeyPress)")>]
            member __.onKeyPress with get() : FunScript.TypeScript.React.KeyboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.KeyboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onKeyUp)")>]
            member __.onKeyUp with get() : FunScript.TypeScript.React.KeyboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.KeyboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onFocus)")>]
            member __.onFocus with get() : FunScript.TypeScript.React.FocusEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FocusEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onBlur)")>]
            member __.onBlur with get() : FunScript.TypeScript.React.FocusEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FocusEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onChange)")>]
            member __.onChange with get() : FunScript.TypeScript.React.FormEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FormEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onInput)")>]
            member __.onInput with get() : FunScript.TypeScript.React.FormEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FormEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onSubmit)")>]
            member __.onSubmit with get() : FunScript.TypeScript.React.FormEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FormEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onClick)")>]
            member __.onClick with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDoubleClick)")>]
            member __.onDoubleClick with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDrag)")>]
            member __.onDrag with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragEnd)")>]
            member __.onDragEnd with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragEnter)")>]
            member __.onDragEnter with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragExit)")>]
            member __.onDragExit with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragLeave)")>]
            member __.onDragLeave with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragOver)")>]
            member __.onDragOver with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragStart)")>]
            member __.onDragStart with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDrop)")>]
            member __.onDrop with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseDown)")>]
            member __.onMouseDown with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseEnter)")>]
            member __.onMouseEnter with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseLeave)")>]
            member __.onMouseLeave with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseMove)")>]
            member __.onMouseMove with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseOut)")>]
            member __.onMouseOut with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseOver)")>]
            member __.onMouseOver with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseUp)")>]
            member __.onMouseUp with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchCancel)")>]
            member __.onTouchCancel with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchEnd)")>]
            member __.onTouchEnd with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchMove)")>]
            member __.onTouchMove with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchStart)")>]
            member __.onTouchStart with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onScroll)")>]
            member __.onScroll with get() : FunScript.TypeScript.React.UIEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.UIEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onWheel)")>]
            member __.onWheel with get() : FunScript.TypeScript.React.WheelEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.WheelEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dangerouslySetInnerHTML)")>]
            member __.dangerouslySetInnerHTML with get() : FunScript.TypeScript.React.AnonymousType446 = failwith "never" and set (v : FunScript.TypeScript.React.AnonymousType446) : unit = failwith "never"



    type FunScript.TypeScript.React.DOMComponent<'P> with

            [<FunScript.JSEmitInline("({0}.tagName)")>]
            member __.tagName with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.DOMElement<'P> with

            [<FunScript.JSEmitInline("({0}.type)")>]
            member __._type with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.DOMFactory<'P> with

            [<FunScript.JSEmitInline("({0}({?1}))")>]
            member __.Invoke(?props : 'P) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})")>]
            member __.``Invoke <-``(func : System.Func<'P, FunScript.TypeScript.React.DOMElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}, {2...}))")>]
            member __.Invoke(props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"



    type FunScript.TypeScript.React.DragEvent with

            [<FunScript.JSEmitInline("({0}.dataTransfer)")>]
            member __.dataTransfer with get() : FunScript.TypeScript.DataTransfer = failwith "never" and set (v : FunScript.TypeScript.DataTransfer) : unit = failwith "never"



    type FunScript.TypeScript.React.EventHandler<'E when 'E :> FunScript.TypeScript.React.SyntheticEvent> with

            [<FunScript.JSEmitInline("({0}({1}))")>]
            member __.Invoke(_event : 'E) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})")>]
            member __.``Invoke <-``(func : System.Func<'E, unit>) : unit = failwith "never"



    type FunScript.TypeScript.React.Factory<'P> with

            [<FunScript.JSEmitInline("({0}({?1}))")>]
            member __.Invoke(?props : 'P) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})")>]
            member __.``Invoke <-``(func : System.Func<'P, FunScript.TypeScript.React.ReactElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}, {2...}))")>]
            member __.Invoke(props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"



    type FunScript.TypeScript.React.FocusEvent with

            [<FunScript.JSEmitInline("({0}.relatedTarget)")>]
            member __.relatedTarget with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"



    type FunScript.TypeScript.React.HTMLAttributes with

            [<FunScript.JSEmitInline("({0}.ref)")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.accept)")>]
            member __.accept with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.acceptCharset)")>]
            member __.acceptCharset with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.accessKey)")>]
            member __.accessKey with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.action)")>]
            member __.action with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.allowFullScreen)")>]
            member __.allowFullScreen with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.allowTransparency)")>]
            member __.allowTransparency with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.alt)")>]
            member __.alt with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.async)")>]
            member __._async with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoComplete)")>]
            member __.autoComplete with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoFocus)")>]
            member __.autoFocus with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoPlay)")>]
            member __.autoPlay with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cellPadding)")>]
            member __.cellPadding with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cellSpacing)")>]
            member __.cellSpacing with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.charSet)")>]
            member __.charSet with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.checked)")>]
            member __._checked with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.classID)")>]
            member __.classID with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.className)")>]
            member __.className with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cols)")>]
            member __.cols with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.colSpan)")>]
            member __.colSpan with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.content)")>]
            member __.content with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contentEditable)")>]
            member __.contentEditable with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contextMenu)")>]
            member __.contextMenu with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.controls)")>]
            member __.controls with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.coords)")>]
            member __.coords with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.crossOrigin)")>]
            member __.crossOrigin with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.data)")>]
            member __.data with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dateTime)")>]
            member __.dateTime with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defer)")>]
            member __.defer with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dir)")>]
            member __.dir with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.disabled)")>]
            member __.disabled with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.download)")>]
            member __.download with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.draggable)")>]
            member __.draggable with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.encType)")>]
            member __.encType with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.form)")>]
            member __.form with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.formNoValidate)")>]
            member __.formNoValidate with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.frameBorder)")>]
            member __.frameBorder with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.height)")>]
            member __.height with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.hidden)")>]
            member __.hidden with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.href)")>]
            member __.href with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.hrefLang)")>]
            member __.hrefLang with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.htmlFor)")>]
            member __.htmlFor with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.httpEquiv)")>]
            member __.httpEquiv with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.icon)")>]
            member __.icon with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.id)")>]
            member __.id with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.label)")>]
            member __.label with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.lang)")>]
            member __.lang with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.list)")>]
            member __.list with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.loop)")>]
            member __.loop with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.manifest)")>]
            member __.manifest with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.max)")>]
            member __.max with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.maxLength)")>]
            member __.maxLength with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.media)")>]
            member __.media with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.mediaGroup)")>]
            member __.mediaGroup with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.method)")>]
            member __._method with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.min)")>]
            member __.min with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.multiple)")>]
            member __.multiple with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.muted)")>]
            member __.muted with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.name)")>]
            member __.name with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.noValidate)")>]
            member __.noValidate with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.open)")>]
            member __._open with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pattern)")>]
            member __.pattern with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.placeholder)")>]
            member __.placeholder with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.poster)")>]
            member __.poster with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preload)")>]
            member __.preload with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.radioGroup)")>]
            member __.radioGroup with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.readOnly)")>]
            member __.readOnly with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rel)")>]
            member __.rel with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.required)")>]
            member __.required with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.role)")>]
            member __.role with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rows)")>]
            member __.rows with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rowSpan)")>]
            member __.rowSpan with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sandbox)")>]
            member __.sandbox with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scope)")>]
            member __.scope with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scrollLeft)")>]
            member __.scrollLeft with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scrolling)")>]
            member __.scrolling with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scrollTop)")>]
            member __.scrollTop with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.seamless)")>]
            member __.seamless with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.selected)")>]
            member __.selected with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shape)")>]
            member __.shape with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.size)")>]
            member __.size with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sizes)")>]
            member __.sizes with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.span)")>]
            member __.span with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.spellCheck)")>]
            member __.spellCheck with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.src)")>]
            member __.src with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.srcDoc)")>]
            member __.srcDoc with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.srcSet)")>]
            member __.srcSet with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.start)")>]
            member __.start with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.step)")>]
            member __.step with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.style)")>]
            member __.style with get() : FunScript.TypeScript.React.CSSProperties = failwith "never" and set (v : FunScript.TypeScript.React.CSSProperties) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tabIndex)")>]
            member __.tabIndex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.target)")>]
            member __.target with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.title)")>]
            member __.title with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.type)")>]
            member __._type with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.useMap)")>]
            member __.useMap with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.value)")>]
            member __.value with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.width)")>]
            member __.width with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.wmode)")>]
            member __.wmode with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoCapitalize)")>]
            member __.autoCapitalize with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoCorrect)")>]
            member __.autoCorrect with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.property)")>]
            member __._property with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.itemProp)")>]
            member __.itemProp with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.itemScope)")>]
            member __.itemScope with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.itemType)")>]
            member __.itemType with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.KeyboardEvent with

            [<FunScript.JSEmitInline("({0}.altKey)")>]
            member __.altKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.charCode)")>]
            member __.charCode with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ctrlKey)")>]
            member __.ctrlKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState({1}))")>]
            member __.getModifierState(key : string) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState = {1})")>]
            member __.``getModifierState <-``(func : System.Func<string, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.key)")>]
            member __.key with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.keyCode)")>]
            member __.keyCode with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.locale)")>]
            member __.locale with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.location)")>]
            member __.location with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.metaKey)")>]
            member __.metaKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.repeat)")>]
            member __.repeat with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shiftKey)")>]
            member __.shiftKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.which)")>]
            member __.which with get() : float = failwith "never" and set (v : float) : unit = failwith "never"



    type FunScript.TypeScript.React.Mixin<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.mixins)")>]
            member __.mixins with get() : FunScript.TypeScript.React.Mixin<'P, 'S> = failwith "never" and set (v : FunScript.TypeScript.React.Mixin<'P, 'S>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.statics)")>]
            member __.statics with get() : FunScript.TypeScript.React.AnonymousType445<'P, 'S> = failwith "never" and set (v : FunScript.TypeScript.React.AnonymousType445<'P, 'S>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.displayName)")>]
            member __.displayName with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.propTypes)")>]
            member __.propTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contextTypes)")>]
            member __.contextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.childContextTypes)")>]
            member __.childContextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps())")>]
            member __.getDefaultProps() : 'P = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps = {1})")>]
            member __.``getDefaultProps <-``(func : System.Func<'P>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState())")>]
            member __.getInitialState() : 'S = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState = {1})")>]
            member __.``getInitialState <-``(func : System.Func<'S>) : unit = failwith "never"



    type FunScript.TypeScript.React.MouseEvent with

            [<FunScript.JSEmitInline("({0}.altKey)")>]
            member __.altKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.button)")>]
            member __.button with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.buttons)")>]
            member __.buttons with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientX)")>]
            member __.clientX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientY)")>]
            member __.clientY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ctrlKey)")>]
            member __.ctrlKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState({1}))")>]
            member __.getModifierState(key : string) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState = {1})")>]
            member __.``getModifierState <-``(func : System.Func<string, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.metaKey)")>]
            member __.metaKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageX)")>]
            member __.pageX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageY)")>]
            member __.pageY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.relatedTarget)")>]
            member __.relatedTarget with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenX)")>]
            member __.screenX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenY)")>]
            member __.screenY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shiftKey)")>]
            member __.shiftKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"



    type FunScript.TypeScript.React.Props<'T> with

            [<FunScript.JSEmitInline("({0}.children)")>]
            member __.children with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.key)")>]
            member __.key with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.Globals with

            [<FunScript.JSEmitInline("(React.createClass({0}))")>]
            static member createClass<'P, 'S>(spec : FunScript.TypeScript.React.ComponentSpec<'P, 'S>) : FunScript.TypeScript.React.ClassicComponentClass<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createClass = {0})")>]
            static member ``createClass <-``<'P, 'S>(func : System.Func<FunScript.TypeScript.React.ComponentSpec<'P, 'S>, FunScript.TypeScript.React.ClassicComponentClass<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory({0}))")>]
            static member createFactory<'P>(_type : string) : FunScript.TypeScript.React.DOMFactory<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory = {0})")>]
            static member ``createFactory <-``<'P>(func : System.Func<string, FunScript.TypeScript.React.DOMFactory<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory({0}))")>]
            static member createFactory<'P>(_type : FunScript.TypeScript.React.ClassicComponentClass<'P>) : FunScript.TypeScript.React.ClassicFactory<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory = {0})")>]
            static member ``createFactory <-``<'P>(func : System.Func<FunScript.TypeScript.React.ClassicComponentClass<'P>, FunScript.TypeScript.React.ClassicFactory<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory({0}))")>]
            static member createFactory<'P>(_type : FunScript.TypeScript.React.ComponentClass<'P>) : FunScript.TypeScript.React.Factory<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory = {0})")>]
            static member ``createFactory <-``<'P>(func : System.Func<FunScript.TypeScript.React.ComponentClass<'P>, FunScript.TypeScript.React.Factory<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {?1}))")>]
            static member createElement<'P>(_type : string, ?props : 'P) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement = {0})")>]
            static member ``createElement <-``<'P>(func : System.Func<string, 'P, FunScript.TypeScript.React.DOMElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {1}, {2...}))")>]
            static member createElement<'P>(_type : string, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {?1}))")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ClassicComponentClass<'P>, ?props : 'P) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement = {0})")>]
            static member ``createElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ClassicComponentClass<'P>, 'P, FunScript.TypeScript.React.ClassicElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {1}, {2...}))")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ClassicComponentClass<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {?1}))")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ComponentClass<'P>, ?props : 'P) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement = {0})")>]
            static member ``createElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ComponentClass<'P>, 'P, FunScript.TypeScript.React.ReactElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {1}, {2...}))")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ComponentClass<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {?1}))")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.DOMElement<'P>, ?props : 'P) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement = {0})")>]
            static member ``cloneElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.DOMElement<'P>, 'P, FunScript.TypeScript.React.DOMElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {1}, {2...}))")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.DOMElement<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {?1}))")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ClassicElement<'P>, ?props : 'P) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement = {0})")>]
            static member ``cloneElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ClassicElement<'P>, 'P, FunScript.TypeScript.React.ClassicElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {1}, {2...}))")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ClassicElement<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {?1}))")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ReactElement<'P>, ?props : 'P) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement = {0})")>]
            static member ``cloneElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ReactElement<'P>, 'P, FunScript.TypeScript.React.ReactElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {1}, {2...}))")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ReactElement<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.render({0}, {1}, {?2}))")>]
            static member render<'P>(element : FunScript.TypeScript.React.DOMElement<'P>, container : FunScript.TypeScript.Element, ?callback : System.Func<obj>) : FunScript.TypeScript.React.DOMComponent<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.render = {0})")>]
            static member ``render <-``<'P>(func : System.Func<FunScript.TypeScript.React.DOMElement<'P>, FunScript.TypeScript.Element, System.Func<obj>, FunScript.TypeScript.React.DOMComponent<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.render({0}, {1}, {?2}))")>]
            static member render<'P, 'S>(element : FunScript.TypeScript.React.ClassicElement<'P>, container : FunScript.TypeScript.Element, ?callback : System.Func<obj>) : FunScript.TypeScript.React.ClassicComponent<'P, 'S> = failwith "never"
            [<FunScript.JSEmitInline("(React.render = {0})")>]
            static member ``render <-``<'P, 'S>(func : System.Func<FunScript.TypeScript.React.ClassicElement<'P>, FunScript.TypeScript.Element, System.Func<obj>, FunScript.TypeScript.React.ClassicComponent<'P, 'S>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.render({0}, {1}, {?2}))")>]
            static member render<'P, 'S>(element : FunScript.TypeScript.React.ReactElement<'P>, container : FunScript.TypeScript.Element, ?callback : System.Func<obj>) : FunScript.TypeScript.React.Component<'P, 'S> = failwith "never"
            [<FunScript.JSEmitInline("(React.render = {0})")>]
            static member ``render <-``<'P, 'S>(func : System.Func<FunScript.TypeScript.React.ReactElement<'P>, FunScript.TypeScript.Element, System.Func<obj>, FunScript.TypeScript.React.Component<'P, 'S>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.unmountComponentAtNode({0}))")>]
            static member unmountComponentAtNode(container : FunScript.TypeScript.Element) : bool = failwith "never"
            [<FunScript.JSEmitInline("(React.unmountComponentAtNode = {0})")>]
            static member ``unmountComponentAtNode <-``(func : System.Func<FunScript.TypeScript.Element, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToString({0}))")>]
            static member renderToString(element : FunScript.TypeScript.React.ReactElement<obj>) : string = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToString = {0})")>]
            static member ``renderToString <-``(func : System.Func<FunScript.TypeScript.React.ReactElement<obj>, string>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToStaticMarkup({0}))")>]
            static member renderToStaticMarkup(element : FunScript.TypeScript.React.ReactElement<obj>) : string = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToStaticMarkup = {0})")>]
            static member ``renderToStaticMarkup <-``(func : System.Func<FunScript.TypeScript.React.ReactElement<obj>, string>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.isValidElement({0}))")>]
            static member isValidElement(_object : FunScript.TypeScript.React.AnonymousType443) : bool = failwith "never"
            [<FunScript.JSEmitInline("(React.isValidElement = {0})")>]
            static member ``isValidElement <-``(func : System.Func<FunScript.TypeScript.React.AnonymousType443, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.initializeTouchEvents({0}))")>]
            static member initializeTouchEvents(shouldUseTouch : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.initializeTouchEvents = {0})")>]
            static member ``initializeTouchEvents <-``(func : System.Func<bool, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))")>]
            static member findDOMNode<'TElement when 'TElement :> FunScript.TypeScript.Element>(_component : FunScript.TypeScript.React.Component<obj, obj>) : 'TElement = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})")>]
            static member ``findDOMNode <-``<'TElement when 'TElement :> FunScript.TypeScript.Element>(func : System.Func<FunScript.TypeScript.React.Component<obj, obj>, 'TElement>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))")>]
            static member findDOMNode<'TElement when 'TElement :> FunScript.TypeScript.Element>(element : FunScript.TypeScript.Element) : 'TElement = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})")>]
            static member ``findDOMNode <-``<'TElement when 'TElement :> FunScript.TypeScript.Element>(func : System.Func<FunScript.TypeScript.Element, 'TElement>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))")>]
            static member findDOMNode(_component : FunScript.TypeScript.React.Component<obj, obj>) : FunScript.TypeScript.Element = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})")>]
            static member ``findDOMNode <-``(func : System.Func<FunScript.TypeScript.React.Component<obj, obj>, FunScript.TypeScript.Element>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))")>]
            static member findDOMNode(element : FunScript.TypeScript.Element) : FunScript.TypeScript.Element = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})")>]
            static member ``findDOMNode <-``(func : System.Func<FunScript.TypeScript.Element, FunScript.TypeScript.Element>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.DOM)")>]
            static member DOM with get() : FunScript.TypeScript.React.ReactDOM = failwith "never" and set (v : FunScript.TypeScript.React.ReactDOM) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.PropTypes)")>]
            static member PropTypes with get() : FunScript.TypeScript.React.ReactPropTypes = failwith "never" and set (v : FunScript.TypeScript.React.ReactPropTypes) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.Children)")>]
            static member Children with get() : FunScript.TypeScript.React.anyren = failwith "never" and set (v : FunScript.TypeScript.React.anyren) : unit = failwith "never"



    type FunScript.TypeScript.React.ReactDOM with

            [<FunScript.JSEmitInline("({0}.a)")>]
            member __.a with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.abbr)")>]
            member __.abbr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.address)")>]
            member __.address with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.area)")>]
            member __.area with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.article)")>]
            member __.article with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.aside)")>]
            member __.aside with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.audio)")>]
            member __.audio with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.b)")>]
            member __.b with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.base)")>]
            member __._base with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.bdi)")>]
            member __.bdi with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.bdo)")>]
            member __.bdo with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.big)")>]
            member __.big with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.blockquote)")>]
            member __.blockquote with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.body)")>]
            member __.body with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.br)")>]
            member __.br with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.button)")>]
            member __.button with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.canvas)")>]
            member __.canvas with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.caption)")>]
            member __.caption with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cite)")>]
            member __.cite with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.code)")>]
            member __.code with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.col)")>]
            member __.col with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.colgroup)")>]
            member __.colgroup with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.data)")>]
            member __.data with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.datalist)")>]
            member __.datalist with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dd)")>]
            member __.dd with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.del)")>]
            member __.del with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.details)")>]
            member __.details with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dfn)")>]
            member __.dfn with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dialog)")>]
            member __.dialog with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.div)")>]
            member __.div with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dl)")>]
            member __.dl with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dt)")>]
            member __.dt with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.em)")>]
            member __.em with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.embed)")>]
            member __.embed with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fieldset)")>]
            member __.fieldset with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.figcaption)")>]
            member __.figcaption with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.figure)")>]
            member __.figure with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.footer)")>]
            member __.footer with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.form)")>]
            member __.form with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h1)")>]
            member __.h1 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h2)")>]
            member __.h2 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h3)")>]
            member __.h3 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h4)")>]
            member __.h4 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h5)")>]
            member __.h5 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h6)")>]
            member __.h6 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.head)")>]
            member __.head with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.header)")>]
            member __.header with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.hr)")>]
            member __.hr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.html)")>]
            member __.html with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.i)")>]
            member __.i with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.iframe)")>]
            member __.iframe with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.img)")>]
            member __.img with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.input)")>]
            member __.input with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ins)")>]
            member __.ins with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.kbd)")>]
            member __.kbd with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.keygen)")>]
            member __.keygen with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.label)")>]
            member __.label with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.legend)")>]
            member __.legend with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.li)")>]
            member __.li with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.link)")>]
            member __.link with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.main)")>]
            member __.main with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.map)")>]
            member __.map with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.mark)")>]
            member __.mark with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.menu)")>]
            member __.menu with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.menuitem)")>]
            member __.menuitem with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.meta)")>]
            member __.meta with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.meter)")>]
            member __.meter with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.nav)")>]
            member __.nav with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.noscript)")>]
            member __.noscript with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.object)")>]
            member __._object with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ol)")>]
            member __.ol with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.optgroup)")>]
            member __.optgroup with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.option)")>]
            member __.option with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.output)")>]
            member __.output with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.p)")>]
            member __.p with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.param)")>]
            member __.param with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.picture)")>]
            member __.picture with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pre)")>]
            member __.pre with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.progress)")>]
            member __.progress with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.q)")>]
            member __.q with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rp)")>]
            member __.rp with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rt)")>]
            member __.rt with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ruby)")>]
            member __.ruby with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.s)")>]
            member __.s with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.samp)")>]
            member __.samp with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.script)")>]
            member __.script with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.section)")>]
            member __.section with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.select)")>]
            member __.select with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.small)")>]
            member __.small with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.source)")>]
            member __.source with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.span)")>]
            member __.span with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strong)")>]
            member __.strong with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.style)")>]
            member __.style with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sub)")>]
            member __.sub with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.summary)")>]
            member __.summary with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sup)")>]
            member __.sup with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.table)")>]
            member __.table with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tbody)")>]
            member __.tbody with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.td)")>]
            member __.td with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.textarea)")>]
            member __.textarea with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tfoot)")>]
            member __.tfoot with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.th)")>]
            member __.th with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.thead)")>]
            member __.thead with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.time)")>]
            member __.time with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.title)")>]
            member __.title with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tr)")>]
            member __.tr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.track)")>]
            member __.track with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.u)")>]
            member __.u with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ul)")>]
            member __.ul with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}[\"var\"])")>]
            member __.``var`` with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.video)")>]
            member __.video with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.wbr)")>]
            member __.wbr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.circle)")>]
            member __.circle with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defs)")>]
            member __.defs with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ellipse)")>]
            member __.ellipse with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.g)")>]
            member __.g with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.line)")>]
            member __.line with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.linearGradient)")>]
            member __.linearGradient with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.mask)")>]
            member __.mask with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.path)")>]
            member __.path with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pattern)")>]
            member __.pattern with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.polygon)")>]
            member __.polygon with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.polyline)")>]
            member __.polyline with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.radialGradient)")>]
            member __.radialGradient with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rect)")>]
            member __.rect with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stop)")>]
            member __.stop with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.svg)")>]
            member __.svg with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.text)")>]
            member __.text with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tspan)")>]
            member __.tspan with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"



    type FunScript.TypeScript.React.ReactElement<'P> with

            [<FunScript.JSEmitInline("({0}.type)")>]
            member __._type with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.props)")>]
            member __.props with get() : 'P = failwith "never" and set (v : 'P) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.key)")>]
            member __.key with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.ReactPropTypes with

            [<FunScript.JSEmitInline("({0}.any)")>]
            member __.any with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.array)")>]
            member __.array with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.bool)")>]
            member __._bool with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.func)")>]
            member __.func with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.number)")>]
            member __.number with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.object)")>]
            member __._object with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.string)")>]
            member __._string with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.node)")>]
            member __.node with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.element)")>]
            member __.element with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.instanceOf({1}))")>]
            member __.instanceOf(expectedClass : FunScript.TypeScript.React.AnonymousType447) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.instanceOf = {1})")>]
            member __.``instanceOf <-``(func : System.Func<FunScript.TypeScript.React.AnonymousType447, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOf({1}))")>]
            member __.oneOf(types : array<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOf = {1})")>]
            member __.``oneOf <-``(func : System.Func<array<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOfType({1}))")>]
            member __.oneOfType(types : array<FunScript.TypeScript.React.ValidatorDelegate<obj>>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOfType = {1})")>]
            member __.``oneOfType <-``(func : System.Func<array<FunScript.TypeScript.React.ValidatorDelegate<obj>>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.arrayOf({1}))")>]
            member __.arrayOf(_type : FunScript.TypeScript.React.ValidatorDelegate<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.arrayOf = {1})")>]
            member __.``arrayOf <-``(func : System.Func<FunScript.TypeScript.React.ValidatorDelegate<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.objectOf({1}))")>]
            member __.objectOf(_type : FunScript.TypeScript.React.ValidatorDelegate<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.objectOf = {1})")>]
            member __.``objectOf <-``(func : System.Func<FunScript.TypeScript.React.ValidatorDelegate<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shape({1}))")>]
            member __.shape(_type : FunScript.TypeScript.React.ValidationMap<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.shape = {1})")>]
            member __.``shape <-``(func : System.Func<FunScript.TypeScript.React.ValidationMap<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"



    type FunScript.TypeScript.React.Requireable<'T> with

            [<FunScript.JSEmitInline("({0}.isRequired)")>]
            member __.isRequired with get() : FunScript.TypeScript.React.ValidatorDelegate<'T> = failwith "never" and set (v : FunScript.TypeScript.React.ValidatorDelegate<'T>) : unit = failwith "never"



    type FunScript.TypeScript.React.SVGAttributes with

            [<FunScript.JSEmitInline("({0}.ref)")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cx)")>]
            member __.cx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cy)")>]
            member __.cy with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.d)")>]
            member __.d with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dx)")>]
            member __.dx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dy)")>]
            member __.dy with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fill)")>]
            member __.fill with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fillOpacity)")>]
            member __.fillOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fontFamily)")>]
            member __.fontFamily with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fontSize)")>]
            member __.fontSize with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fx)")>]
            member __.fx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fy)")>]
            member __.fy with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.gradientTransform)")>]
            member __.gradientTransform with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.gradientUnits)")>]
            member __.gradientUnits with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.markerEnd)")>]
            member __.markerEnd with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.markerMid)")>]
            member __.markerMid with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.markerStart)")>]
            member __.markerStart with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.offset)")>]
            member __.offset with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.opacity)")>]
            member __.opacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.patternContentUnits)")>]
            member __.patternContentUnits with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.patternUnits)")>]
            member __.patternUnits with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.points)")>]
            member __.points with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preserveAspectRatio)")>]
            member __.preserveAspectRatio with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.r)")>]
            member __.r with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rx)")>]
            member __.rx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ry)")>]
            member __.ry with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.spreadMethod)")>]
            member __.spreadMethod with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopColor)")>]
            member __.stopColor with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopOpacity)")>]
            member __.stopOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stroke)")>]
            member __.stroke with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeDasharray)")>]
            member __.strokeDasharray with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeLinecap)")>]
            member __.strokeLinecap with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeOpacity)")>]
            member __.strokeOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeWidth)")>]
            member __.strokeWidth with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.textAnchor)")>]
            member __.textAnchor with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.transform)")>]
            member __.transform with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.version)")>]
            member __.version with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.viewBox)")>]
            member __.viewBox with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.x1)")>]
            member __.x1 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.x2)")>]
            member __.x2 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.x)")>]
            member __.x with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.y1)")>]
            member __.y1 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.y2)")>]
            member __.y2 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.y)")>]
            member __.y with get() : float = failwith "never" and set (v : float) : unit = failwith "never"



    type FunScript.TypeScript.React.SyntheticEvent with

            [<FunScript.JSEmitInline("({0}.bubbles)")>]
            member __.bubbles with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cancelable)")>]
            member __.cancelable with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.currentTarget)")>]
            member __.currentTarget with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defaultPrevented)")>]
            member __.defaultPrevented with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.eventPhase)")>]
            member __.eventPhase with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.isTrusted)")>]
            member __.isTrusted with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.nativeEvent)")>]
            member __.nativeEvent with get() : FunScript.TypeScript.Event = failwith "never" and set (v : FunScript.TypeScript.Event) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preventDefault())")>]
            member __.preventDefault() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preventDefault = {1})")>]
            member __.``preventDefault <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopPropagation())")>]
            member __.stopPropagation() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopPropagation = {1})")>]
            member __.``stopPropagation <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.target)")>]
            member __.target with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.timeStamp)")>]
            member __.timeStamp with get() : FunScript.TypeScript.Date = failwith "never" and set (v : FunScript.TypeScript.Date) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.type)")>]
            member __._type with get() : string = failwith "never" and set (v : string) : unit = failwith "never"



    type FunScript.TypeScript.React.Touch with

            [<FunScript.JSEmitInline("({0}.identifier)")>]
            member __.identifier with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.target)")>]
            member __.target with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenX)")>]
            member __.screenX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenY)")>]
            member __.screenY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientX)")>]
            member __.clientX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientY)")>]
            member __.clientY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageX)")>]
            member __.pageX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageY)")>]
            member __.pageY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"



    type FunScript.TypeScript.React.TouchEvent with

            [<FunScript.JSEmitInline("({0}.altKey)")>]
            member __.altKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.changedTouches)")>]
            member __.changedTouches with get() : FunScript.TypeScript.React.TouchList = failwith "never" and set (v : FunScript.TypeScript.React.TouchList) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ctrlKey)")>]
            member __.ctrlKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState({1}))")>]
            member __.getModifierState(key : string) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState = {1})")>]
            member __.``getModifierState <-``(func : System.Func<string, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.metaKey)")>]
            member __.metaKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shiftKey)")>]
            member __.shiftKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.targetTouches)")>]
            member __.targetTouches with get() : FunScript.TypeScript.React.TouchList = failwith "never" and set (v : FunScript.TypeScript.React.TouchList) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.touches)")>]
            member __.touches with get() : FunScript.TypeScript.React.TouchList = failwith "never" and set (v : FunScript.TypeScript.React.TouchList) : unit = failwith "never"



    type FunScript.TypeScript.React.TouchList with

            [<FunScript.JSEmitInline("({0}[{1}])")>]
            member __.Item with get(i : int) : FunScript.TypeScript.React.Touch = failwith "never" and set (i : int) (v : FunScript.TypeScript.React.Touch) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.length)")>]
            member __.length with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.item({1}))")>]
            member __.item(index : float) : FunScript.TypeScript.React.Touch = failwith "never"
            [<FunScript.JSEmitInline("({0}.item = {1})")>]
            member __.``item <-``(func : System.Func<float, FunScript.TypeScript.React.Touch>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.identifiedTouch({1}))")>]
            member __.identifiedTouch(identifier : float) : FunScript.TypeScript.React.Touch = failwith "never"
            [<FunScript.JSEmitInline("({0}.identifiedTouch = {1})")>]
            member __.``identifiedTouch <-``(func : System.Func<float, FunScript.TypeScript.React.Touch>) : unit = failwith "never"



    type FunScript.TypeScript.React.UIEvent with

            [<FunScript.JSEmitInline("({0}.detail)")>]
            member __.detail with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.view)")>]
            member __.view with get() : FunScript.TypeScript.React.AbstractView = failwith "never" and set (v : FunScript.TypeScript.React.AbstractView) : unit = failwith "never"



    type FunScript.TypeScript.React.ValidationMap<'T> with

            [<FunScript.JSEmitInline("({0}[{1}])")>]
            member __.Item with get(i : string) : FunScript.TypeScript.React.ValidatorDelegate<'T> = failwith "never" and set (i : string) (v : FunScript.TypeScript.React.ValidatorDelegate<'T>) : unit = failwith "never"



    type FunScript.TypeScript.React.Validator<'T> with

            [<FunScript.JSEmitInline("({0}({1}, {2}, {3}))")>]
            member __.Invoke(_object : 'T, key : string, componentName : string) : FunScript.TypeScript.Error = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})")>]
            member __.``Invoke <-``(func : System.Func<'T, string, string, FunScript.TypeScript.Error>) : unit = failwith "never"



    type FunScript.TypeScript.React.WheelEvent with

            [<FunScript.JSEmitInline("({0}.deltaMode)")>]
            member __.deltaMode with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.deltaX)")>]
            member __.deltaX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.deltaY)")>]
            member __.deltaY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.deltaZ)")>]
            member __.deltaZ with get() : float = failwith "never" and set (v : float) : unit = failwith "never"



    type FunScript.TypeScript.React.anyren with

            [<FunScript.JSEmitInline("({0}.map({1}, {2}))")>]
            member __.map<'T>(children : obj, fn : System.Func<obj, 'T>) : FunScript.TypeScript.React.AnonymousType448 = failwith "never"
            [<FunScript.JSEmitInline("({0}.map = {1})")>]
            member __.``map <-``<'T>(func : System.Func<obj, System.Func<obj, 'T>, FunScript.TypeScript.React.AnonymousType448>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forEach({1}, {2}))")>]
            member __.forEach(children : obj, fn : System.Func<obj, obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forEach = {1})")>]
            member __.``forEach <-``(func : System.Func<obj, System.Func<obj, obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.count({1}))")>]
            member __.count(children : obj) : float = failwith "never"
            [<FunScript.JSEmitInline("({0}.count = {1})")>]
            member __.``count <-``(func : System.Func<obj, float>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.only({1}))")>]
            member __.only(children : obj) : obj = failwith "never"
            [<FunScript.JSEmitInline("({0}.only = {1})")>]
            member __.``only <-``(func : System.Func<obj, obj>) : unit = failwith "never"
