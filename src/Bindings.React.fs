
namespace FunScript.TypeScript.React
type AbstractView = interface end

namespace FunScript.TypeScript.React
type AnonymousType443 = interface end

namespace FunScript.TypeScript.React
type AnonymousType444<'P, 'S> = interface end

namespace FunScript.TypeScript.React
type AnonymousType445<'P, 'S> = interface end

namespace FunScript.TypeScript.React
type AnonymousType446 = interface end

namespace FunScript.TypeScript.React
type AnonymousType447 = interface end

namespace FunScript.TypeScript.React
type AnonymousType448 = interface end

namespace FunScript.TypeScript.React
type CSSProperties = interface end

namespace FunScript.TypeScript.React
type ChildContextProvider<'CC> = interface end

namespace FunScript.TypeScript.React
type ComponentClass<'P> = interface end

namespace FunScript.TypeScript.React
type ComponentLifecycle<'P, 'S> = interface end

namespace FunScript.TypeScript.React
type Factory<'P> = interface end

namespace FunScript.TypeScript.React
type Props<'T> = interface end

namespace FunScript.TypeScript.React
type Globals = interface end

namespace FunScript.TypeScript.React
type ReactDOM = interface end

namespace FunScript.TypeScript.React
type ReactElement<'P> = interface end

namespace FunScript.TypeScript.React
type ReactPropTypes = interface end

namespace FunScript.TypeScript.React
type SyntheticEvent = interface end

namespace FunScript.TypeScript.React
type Touch = interface end

namespace FunScript.TypeScript.React
type TouchList = interface end

namespace FunScript.TypeScript.React
type ValidationMap<'T> = interface end

namespace FunScript.TypeScript.React
type Validator<'T> = interface end

namespace FunScript.TypeScript.React
type ValidatorDelegate<'T> = delegate of 'T * string * string -> FunScript.TypeScript.Error

namespace FunScript.TypeScript.React
type anyren = interface end

namespace FunScript.TypeScript.React
type ClassicComponentClass<'P> =
        inherit ComponentClass<'P>

namespace FunScript.TypeScript.React
type ClassicElement<'P> =
        inherit ReactElement<'P>

namespace FunScript.TypeScript.React
type ClassicFactory<'P> =
        inherit Factory<'P>

namespace FunScript.TypeScript.React
type ClipboardEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type Component<'P, 'S> =
        inherit ComponentLifecycle<'P, 'S>

namespace FunScript.TypeScript.React
type DragEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type EventHandler<'E when 'E :> FunScript.TypeScript.React.SyntheticEvent> = interface end

namespace FunScript.TypeScript.React
type FocusEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type FormEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type KeyboardEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type Mixin<'P, 'S> =
        inherit ComponentLifecycle<'P, 'S>

namespace FunScript.TypeScript.React
type MouseEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type Requireable<'T> =
        inherit Validator<'T>

namespace FunScript.TypeScript.React
type TouchEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type UIEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type WheelEvent =
        inherit SyntheticEvent

namespace FunScript.TypeScript.React
type ClassicComponent<'P, 'S> =
        inherit Component<'P, 'S>

namespace FunScript.TypeScript.React
type ClipboardEventHandler =
        inherit EventHandler<ClipboardEvent>

namespace FunScript.TypeScript.React
type ComponentSpec<'P, 'S> =
        inherit Mixin<'P, 'S>

namespace FunScript.TypeScript.React
type DOMElement<'P> =
        inherit ClassicElement<'P>

namespace FunScript.TypeScript.React
type DOMFactory<'P> =
        inherit ClassicFactory<'P>

namespace FunScript.TypeScript.React
type DragEventHandler =
        inherit EventHandler<DragEvent>

namespace FunScript.TypeScript.React
type FocusEventHandler =
        inherit EventHandler<FocusEvent>

namespace FunScript.TypeScript.React
type FormEventHandler =
        inherit EventHandler<FormEvent>

namespace FunScript.TypeScript.React
type KeyboardEventHandler =
        inherit EventHandler<KeyboardEvent>

namespace FunScript.TypeScript.React
type MouseEventHandler =
        inherit EventHandler<MouseEvent>

namespace FunScript.TypeScript.React
type TouchEventHandler =
        inherit EventHandler<TouchEvent>

namespace FunScript.TypeScript.React
type UIEventHandler =
        inherit EventHandler<UIEvent>

namespace FunScript.TypeScript.React
type WheelEventHandler =
        inherit EventHandler<WheelEvent>

namespace FunScript.TypeScript.React
type DOMComponent<'P> =
        inherit ClassicComponent<'P, obj>

namespace FunScript.TypeScript.React
type DOMAttributes =
        inherit Props<DOMComponent<obj>>

namespace FunScript.TypeScript.React
type HTMLAttributes =
        inherit DOMAttributes

namespace FunScript.TypeScript.React
type SVGAttributes =
        inherit DOMAttributes


namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_0 =


    type FunScript.TypeScript.React.AbstractView with

            [<FunScript.JSEmitInline("({0}.styleMedia)"); CompiledName("styleMedia_2")>]
            member __.styleMedia with get() : FunScript.TypeScript.StyleMedia = failwith "never" and set (v : FunScript.TypeScript.StyleMedia) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.document)"); CompiledName("document_4")>]
            member __.document with get() : FunScript.TypeScript.Document = failwith "never" and set (v : FunScript.TypeScript.Document) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_1 =


    type FunScript.TypeScript.React.AnonymousType444<'P, 'S> with

            [<FunScript.JSEmitInline("({0}[{1}])"); CompiledName("Item_42")>]
            member __.Item with get(i : string) : FunScript.TypeScript.React.Component<obj, obj> = failwith "never" and set (i : string) (v : FunScript.TypeScript.React.Component<obj, obj>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_2 =


    type FunScript.TypeScript.React.AnonymousType445<'P, 'S> with

            [<FunScript.JSEmitInline("({0}[{1}])"); CompiledName("Item_43")>]
            member __.Item with get(i : string) : obj = failwith "never" and set (i : string) (v : obj) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_3 =


    type FunScript.TypeScript.React.AnonymousType446 with

            [<FunScript.JSEmitInline("({0}.__html)"); CompiledName("__html")>]
            member __.__html with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_4 =


    type FunScript.TypeScript.React.CSSProperties with

            [<FunScript.JSEmitInline("({0}.boxFlex)"); CompiledName("boxFlex")>]
            member __.boxFlex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.boxFlexGroup)"); CompiledName("boxFlexGroup")>]
            member __.boxFlexGroup with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.columnCount)"); CompiledName("columnCount_1")>]
            member __.columnCount with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.flex)"); CompiledName("flex_1")>]
            member __.flex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.flexGrow)"); CompiledName("flexGrow_1")>]
            member __.flexGrow with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.flexShrink)"); CompiledName("flexShrink_1")>]
            member __.flexShrink with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fontWeight)"); CompiledName("fontWeight_1")>]
            member __.fontWeight with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.lineClamp)"); CompiledName("lineClamp")>]
            member __.lineClamp with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.lineHeight)"); CompiledName("lineHeight_1")>]
            member __.lineHeight with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.opacity)"); CompiledName("opacity_1")>]
            member __.opacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.order)"); CompiledName("order_1")>]
            member __.order with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.orphans)"); CompiledName("orphans_1")>]
            member __.orphans with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.widows)"); CompiledName("widows_1")>]
            member __.widows with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.zIndex)"); CompiledName("zIndex_1")>]
            member __.zIndex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.zoom)"); CompiledName("zoom_1")>]
            member __.zoom with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fillOpacity)"); CompiledName("fillOpacity_1")>]
            member __.fillOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeOpacity)"); CompiledName("strokeOpacity_1")>]
            member __.strokeOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeWidth)"); CompiledName("strokeWidth_1")>]
            member __.strokeWidth with get() : float = failwith "never" and set (v : float) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_5 =


    type FunScript.TypeScript.React.ChildContextProvider<'CC> with

            [<FunScript.JSEmitInline("({0}.getChildContext())"); CompiledName("getChildContext")>]
            member __.getChildContext() : 'CC = failwith "never"
            [<FunScript.JSEmitInline("({0}.getChildContext = {1})"); CompiledName("getChildContextAux")>]
            member __.``getChildContext <-``(func : System.Func<'CC>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_6 =


    type FunScript.TypeScript.React.ClassicComponent<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.replaceState({1}, {?2}))"); CompiledName("replaceState_1")>]
            member __.replaceState(nextState : 'S, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.replaceState = {1})"); CompiledName("replaceState_1Aux")>]
            member __.``replaceState <-``(func : System.Func<'S, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode())"); CompiledName("getDOMNode")>]
            member __.getDOMNode<'TElement when 'TElement :> FunScript.TypeScript.Element>() : 'TElement = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode = {1})"); CompiledName("getDOMNodeAux")>]
            member __.``getDOMNode <-``<'TElement when 'TElement :> FunScript.TypeScript.Element>(func : System.Func<'TElement>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode())"); CompiledName("getDOMNode_1")>]
            member __.getDOMNode() : FunScript.TypeScript.Element = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDOMNode = {1})"); CompiledName("getDOMNode_1Aux")>]
            member __.``getDOMNode <-``(func : System.Func<FunScript.TypeScript.Element>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.isMounted())"); CompiledName("isMounted")>]
            member __.isMounted() : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.isMounted = {1})"); CompiledName("isMountedAux")>]
            member __.``isMounted <-``(func : System.Func<bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState())"); CompiledName("getInitialState")>]
            member __.getInitialState() : 'S = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState = {1})"); CompiledName("getInitialStateAux")>]
            member __.``getInitialState <-``(func : System.Func<'S>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setProps({1}, {?2}))"); CompiledName("setProps")>]
            member __.setProps(nextProps : 'P, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setProps = {1})"); CompiledName("setPropsAux")>]
            member __.``setProps <-``(func : System.Func<'P, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.replaceProps({1}, {?2}))"); CompiledName("replaceProps")>]
            member __.replaceProps(nextProps : 'P, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.replaceProps = {1})"); CompiledName("replacePropsAux")>]
            member __.``replaceProps <-``(func : System.Func<'P, System.Func<obj>, unit>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_7 =


    type FunScript.TypeScript.React.ClassicComponentClass<'P> with

            [<FunScript.JSEmitInline("(new {0}({?1}, {?2}))"); CompiledName("Create_473")>]
            member __.Create(?props : 'P, ?context : obj) : FunScript.TypeScript.React.ClassicComponent<'P, obj> = failwith "never"
            [<FunScript.JSEmitInline("(new {0} = {1})"); CompiledName("Create_473Aux")>]
            member __.``Create <-``(func : System.Func<'P, obj, FunScript.TypeScript.React.ClassicComponent<'P, obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps())"); CompiledName("getDefaultProps")>]
            member __.getDefaultProps() : 'P = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps = {1})"); CompiledName("getDefaultPropsAux")>]
            member __.``getDefaultProps <-``(func : System.Func<'P>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.displayName)"); CompiledName("displayName")>]
            member __.displayName with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_8 =


    type FunScript.TypeScript.React.ClassicElement<'P> with

            [<FunScript.JSEmitInline("({0}.type)"); CompiledName("_type_36")>]
            member __._type with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)"); CompiledName("_ref")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_9 =


    type FunScript.TypeScript.React.ClassicFactory<'P> with

            [<FunScript.JSEmitInline("({0}({?1}))"); CompiledName("Invoke_37")>]
            member __.Invoke(?props : 'P) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_37Aux")>]
            member __.``Invoke <-``(func : System.Func<'P, FunScript.TypeScript.React.ClassicElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}, {2...}))"); CompiledName("Invoke_38")>]
            member __.Invoke(props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_10 =


    type FunScript.TypeScript.React.ClipboardEvent with

            [<FunScript.JSEmitInline("({0}.clipboardData)"); CompiledName("clipboardData_2")>]
            member __.clipboardData with get() : FunScript.TypeScript.DataTransfer = failwith "never" and set (v : FunScript.TypeScript.DataTransfer) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_11 =


    type FunScript.TypeScript.React.Component<'P, 'S> with

            [<FunScript.JSEmitInline("(new React.Component({?0}, {?1}))"); CompiledName("Create_474")>]
            static member Create(?props : 'P, ?context : obj) : FunScript.TypeScript.React.Component<'P, 'S> = failwith "never"
            [<FunScript.JSEmitInline("(new React.Component = {0})"); CompiledName("Create_474Aux")>]
            static member ``Create <-``(func : System.Func<'P, obj, FunScript.TypeScript.React.Component<'P, 'S>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState({1}, {?2}))"); CompiledName("setState")>]
            member __.setState(f : System.Func<'S, 'P, 'S>, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState = {1})"); CompiledName("setStateAux")>]
            member __.``setState <-``(func : System.Func<System.Func<'S, 'P, 'S>, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState({1}, {?2}))"); CompiledName("setState_1")>]
            member __.setState(state : 'S, ?callback : System.Func<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.setState = {1})"); CompiledName("setState_1Aux")>]
            member __.``setState <-``(func : System.Func<'S, System.Func<obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forceUpdate())"); CompiledName("forceUpdate")>]
            member __.forceUpdate() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forceUpdate = {1})"); CompiledName("forceUpdateAux")>]
            member __.``forceUpdate <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.props)"); CompiledName("props")>]
            member __.props with get() : 'P = failwith "never" and set (v : 'P) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.state)"); CompiledName("state_2")>]
            member __.state with get() : 'S = failwith "never" and set (v : 'S) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.context)"); CompiledName("context")>]
            member __.context with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.refs)"); CompiledName("refs")>]
            member __.refs with get() : FunScript.TypeScript.React.AnonymousType444<'P, 'S> = failwith "never" and set (v : FunScript.TypeScript.React.AnonymousType444<'P, 'S>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_12 =


    type FunScript.TypeScript.React.ComponentClass<'P> with

            [<FunScript.JSEmitInline("(new {0}({?1}, {?2}))"); CompiledName("Create_475")>]
            member __.Create(?props : 'P, ?context : obj) : FunScript.TypeScript.React.Component<'P, obj> = failwith "never"
            [<FunScript.JSEmitInline("(new {0} = {1})"); CompiledName("Create_475Aux")>]
            member __.``Create <-``(func : System.Func<'P, obj, FunScript.TypeScript.React.Component<'P, obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.propTypes)"); CompiledName("propTypes")>]
            member __.propTypes with get() : FunScript.TypeScript.React.ValidationMap<'P> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<'P>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contextTypes)"); CompiledName("contextTypes")>]
            member __.contextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.childContextTypes)"); CompiledName("childContextTypes")>]
            member __.childContextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defaultProps)"); CompiledName("defaultProps")>]
            member __.defaultProps with get() : 'P = failwith "never" and set (v : 'P) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_13 =


    type FunScript.TypeScript.React.ComponentLifecycle<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.componentWillMount())"); CompiledName("componentWillMount")>]
            member __.componentWillMount() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillMount = {1})"); CompiledName("componentWillMountAux")>]
            member __.``componentWillMount <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidMount())"); CompiledName("componentDidMount")>]
            member __.componentDidMount() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidMount = {1})"); CompiledName("componentDidMountAux")>]
            member __.``componentDidMount <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillReceiveProps({1}, {2}))"); CompiledName("componentWillReceiveProps")>]
            member __.componentWillReceiveProps(nextProps : 'P, nextContext : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillReceiveProps = {1})"); CompiledName("componentWillReceivePropsAux")>]
            member __.``componentWillReceiveProps <-``(func : System.Func<'P, obj, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shouldComponentUpdate({1}, {2}, {3}))"); CompiledName("shouldComponentUpdate")>]
            member __.shouldComponentUpdate(nextProps : 'P, nextState : 'S, nextContext : obj) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.shouldComponentUpdate = {1})"); CompiledName("shouldComponentUpdateAux")>]
            member __.``shouldComponentUpdate <-``(func : System.Func<'P, 'S, obj, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUpdate({1}, {2}, {3}))"); CompiledName("componentWillUpdate")>]
            member __.componentWillUpdate(nextProps : 'P, nextState : 'S, nextContext : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUpdate = {1})"); CompiledName("componentWillUpdateAux")>]
            member __.``componentWillUpdate <-``(func : System.Func<'P, 'S, obj, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidUpdate({1}, {2}, {3}))"); CompiledName("componentDidUpdate")>]
            member __.componentDidUpdate(prevProps : 'P, prevState : 'S, prevContext : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentDidUpdate = {1})"); CompiledName("componentDidUpdateAux")>]
            member __.``componentDidUpdate <-``(func : System.Func<'P, 'S, obj, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUnmount())"); CompiledName("componentWillUnmount")>]
            member __.componentWillUnmount() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.componentWillUnmount = {1})"); CompiledName("componentWillUnmountAux")>]
            member __.``componentWillUnmount <-``(func : System.Func<unit>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_14 =


    type FunScript.TypeScript.React.ComponentSpec<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.render())"); CompiledName("render")>]
            member __.render() : FunScript.TypeScript.React.ReactElement<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.render = {1})"); CompiledName("renderAux")>]
            member __.``render <-``(func : System.Func<FunScript.TypeScript.React.ReactElement<obj>>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_15 =


    type FunScript.TypeScript.React.DOMAttributes with

            [<FunScript.JSEmitInline("({0}.onCopy)"); CompiledName("onCopy")>]
            member __.onCopy with get() : FunScript.TypeScript.React.ClipboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.ClipboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onCut)"); CompiledName("onCut")>]
            member __.onCut with get() : FunScript.TypeScript.React.ClipboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.ClipboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onPaste)"); CompiledName("onPaste")>]
            member __.onPaste with get() : FunScript.TypeScript.React.ClipboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.ClipboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onKeyDown)"); CompiledName("onKeyDown")>]
            member __.onKeyDown with get() : FunScript.TypeScript.React.KeyboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.KeyboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onKeyPress)"); CompiledName("onKeyPress")>]
            member __.onKeyPress with get() : FunScript.TypeScript.React.KeyboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.KeyboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onKeyUp)"); CompiledName("onKeyUp")>]
            member __.onKeyUp with get() : FunScript.TypeScript.React.KeyboardEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.KeyboardEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onFocus)"); CompiledName("onFocus")>]
            member __.onFocus with get() : FunScript.TypeScript.React.FocusEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FocusEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onBlur)"); CompiledName("onBlur")>]
            member __.onBlur with get() : FunScript.TypeScript.React.FocusEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FocusEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onChange)"); CompiledName("onChange")>]
            member __.onChange with get() : FunScript.TypeScript.React.FormEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FormEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onInput)"); CompiledName("onInput")>]
            member __.onInput with get() : FunScript.TypeScript.React.FormEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FormEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onSubmit)"); CompiledName("onSubmit")>]
            member __.onSubmit with get() : FunScript.TypeScript.React.FormEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.FormEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onClick)"); CompiledName("onClick")>]
            member __.onClick with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDoubleClick)"); CompiledName("onDoubleClick")>]
            member __.onDoubleClick with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDrag)"); CompiledName("onDrag")>]
            member __.onDrag with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragEnd)"); CompiledName("onDragEnd")>]
            member __.onDragEnd with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragEnter)"); CompiledName("onDragEnter")>]
            member __.onDragEnter with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragExit)"); CompiledName("onDragExit")>]
            member __.onDragExit with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragLeave)"); CompiledName("onDragLeave")>]
            member __.onDragLeave with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragOver)"); CompiledName("onDragOver")>]
            member __.onDragOver with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDragStart)"); CompiledName("onDragStart")>]
            member __.onDragStart with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onDrop)"); CompiledName("onDrop")>]
            member __.onDrop with get() : FunScript.TypeScript.React.DragEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.DragEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseDown)"); CompiledName("onMouseDown")>]
            member __.onMouseDown with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseEnter)"); CompiledName("onMouseEnter")>]
            member __.onMouseEnter with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseLeave)"); CompiledName("onMouseLeave")>]
            member __.onMouseLeave with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseMove)"); CompiledName("onMouseMove")>]
            member __.onMouseMove with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseOut)"); CompiledName("onMouseOut")>]
            member __.onMouseOut with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseOver)"); CompiledName("onMouseOver")>]
            member __.onMouseOver with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onMouseUp)"); CompiledName("onMouseUp")>]
            member __.onMouseUp with get() : FunScript.TypeScript.React.MouseEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.MouseEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchCancel)"); CompiledName("onTouchCancel")>]
            member __.onTouchCancel with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchEnd)"); CompiledName("onTouchEnd")>]
            member __.onTouchEnd with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchMove)"); CompiledName("onTouchMove")>]
            member __.onTouchMove with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onTouchStart)"); CompiledName("onTouchStart")>]
            member __.onTouchStart with get() : FunScript.TypeScript.React.TouchEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.TouchEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onScroll)"); CompiledName("onScroll")>]
            member __.onScroll with get() : FunScript.TypeScript.React.UIEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.UIEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.onWheel)"); CompiledName("onWheel")>]
            member __.onWheel with get() : FunScript.TypeScript.React.WheelEventHandler = failwith "never" and set (v : FunScript.TypeScript.React.WheelEventHandler) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dangerouslySetInnerHTML)"); CompiledName("dangerouslySetInnerHTML")>]
            member __.dangerouslySetInnerHTML with get() : FunScript.TypeScript.React.AnonymousType446 = failwith "never" and set (v : FunScript.TypeScript.React.AnonymousType446) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_16 =


    type FunScript.TypeScript.React.DOMComponent<'P> with

            [<FunScript.JSEmitInline("({0}.tagName)"); CompiledName("tagName_1")>]
            member __.tagName with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_17 =


    type FunScript.TypeScript.React.DOMElement<'P> with

            [<FunScript.JSEmitInline("({0}.type)"); CompiledName("_type_37")>]
            member __._type with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)"); CompiledName("_ref_1")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_18 =


    type FunScript.TypeScript.React.DOMFactory<'P> with

            [<FunScript.JSEmitInline("({0}({?1}))"); CompiledName("Invoke_39")>]
            member __.Invoke(?props : 'P) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_39Aux")>]
            member __.``Invoke <-``(func : System.Func<'P, FunScript.TypeScript.React.DOMElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}, {2...}))"); CompiledName("Invoke_40")>]
            member __.Invoke(props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_19 =


    type FunScript.TypeScript.React.DragEvent with

            [<FunScript.JSEmitInline("({0}.dataTransfer)"); CompiledName("dataTransfer_2")>]
            member __.dataTransfer with get() : FunScript.TypeScript.DataTransfer = failwith "never" and set (v : FunScript.TypeScript.DataTransfer) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_20 =


    type FunScript.TypeScript.React.EventHandler<'E when 'E :> FunScript.TypeScript.React.SyntheticEvent> with

            [<FunScript.JSEmitInline("({0}({1}))"); CompiledName("Invoke_41")>]
            member __.Invoke(_event : 'E) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_41Aux")>]
            member __.``Invoke <-``(func : System.Func<'E, unit>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_21 =


    type FunScript.TypeScript.React.Factory<'P> with

            [<FunScript.JSEmitInline("({0}({?1}))"); CompiledName("Invoke_42")>]
            member __.Invoke(?props : 'P) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_42Aux")>]
            member __.``Invoke <-``(func : System.Func<'P, FunScript.TypeScript.React.ReactElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}, {2...}))"); CompiledName("Invoke_43")>]
            member __.Invoke(props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_22 =


    type FunScript.TypeScript.React.FocusEvent with

            [<FunScript.JSEmitInline("({0}.relatedTarget)"); CompiledName("relatedTarget_3")>]
            member __.relatedTarget with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_23 =


    type FunScript.TypeScript.React.HTMLAttributes with

            [<FunScript.JSEmitInline("({0}.ref)"); CompiledName("_ref_2")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.accept)"); CompiledName("accept_1")>]
            member __.accept with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.acceptCharset)"); CompiledName("acceptCharset_1")>]
            member __.acceptCharset with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.accessKey)"); CompiledName("accessKey_1")>]
            member __.accessKey with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.action)"); CompiledName("action_2")>]
            member __.action with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.allowFullScreen)"); CompiledName("allowFullScreen")>]
            member __.allowFullScreen with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.allowTransparency)"); CompiledName("allowTransparency")>]
            member __.allowTransparency with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.alt)"); CompiledName("alt_5")>]
            member __.alt with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.async)"); CompiledName("_async_1")>]
            member __._async with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoComplete)"); CompiledName("autoComplete")>]
            member __.autoComplete with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoFocus)"); CompiledName("autoFocus")>]
            member __.autoFocus with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoPlay)"); CompiledName("autoPlay")>]
            member __.autoPlay with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cellPadding)"); CompiledName("cellPadding_1")>]
            member __.cellPadding with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cellSpacing)"); CompiledName("cellSpacing_1")>]
            member __.cellSpacing with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.charSet)"); CompiledName("charSet")>]
            member __.charSet with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.checked)"); CompiledName("_checked_1")>]
            member __._checked with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.classID)"); CompiledName("classID")>]
            member __.classID with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.className)"); CompiledName("className_2")>]
            member __.className with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cols)"); CompiledName("cols_3")>]
            member __.cols with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.colSpan)"); CompiledName("colSpan_1")>]
            member __.colSpan with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.content)"); CompiledName("content_2")>]
            member __.content with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contentEditable)"); CompiledName("contentEditable_1")>]
            member __.contentEditable with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contextMenu)"); CompiledName("contextMenu")>]
            member __.contextMenu with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.controls)"); CompiledName("controls_1")>]
            member __.controls with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.coords)"); CompiledName("coords_3")>]
            member __.coords with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.crossOrigin)"); CompiledName("crossOrigin_1")>]
            member __.crossOrigin with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.data)"); CompiledName("data_9")>]
            member __.data with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dateTime)"); CompiledName("dateTime_3")>]
            member __.dateTime with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defer)"); CompiledName("defer_1")>]
            member __.defer with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dir)"); CompiledName("dir_4")>]
            member __.dir with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.disabled)"); CompiledName("disabled_2")>]
            member __.disabled with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.download)"); CompiledName("download")>]
            member __.download with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.draggable)"); CompiledName("draggable_1")>]
            member __.draggable with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.encType)"); CompiledName("encType")>]
            member __.encType with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.form)"); CompiledName("form_13")>]
            member __.form with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.formNoValidate)"); CompiledName("formNoValidate_2")>]
            member __.formNoValidate with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.frameBorder)"); CompiledName("frameBorder_3")>]
            member __.frameBorder with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.height)"); CompiledName("height_30")>]
            member __.height with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.hidden)"); CompiledName("hidden_3")>]
            member __.hidden with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.href)"); CompiledName("href_10")>]
            member __.href with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.hrefLang)"); CompiledName("hrefLang")>]
            member __.hrefLang with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.htmlFor)"); CompiledName("htmlFor_2")>]
            member __.htmlFor with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.httpEquiv)"); CompiledName("httpEquiv_1")>]
            member __.httpEquiv with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.icon)"); CompiledName("icon")>]
            member __.icon with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.id)"); CompiledName("id_5")>]
            member __.id with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.label)"); CompiledName("label_5")>]
            member __.label with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.lang)"); CompiledName("lang_1")>]
            member __.lang with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.list)"); CompiledName("list_1")>]
            member __.list with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.loop)"); CompiledName("loop_5")>]
            member __.loop with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.manifest)"); CompiledName("manifest")>]
            member __.manifest with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.max)"); CompiledName("max_4")>]
            member __.max with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.maxLength)"); CompiledName("maxLength_2")>]
            member __.maxLength with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.media)"); CompiledName("media_9")>]
            member __.media with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.mediaGroup)"); CompiledName("mediaGroup")>]
            member __.mediaGroup with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.method)"); CompiledName("_method_2")>]
            member __._method with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.min)"); CompiledName("min_3")>]
            member __.min with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.multiple)"); CompiledName("multiple_2")>]
            member __.multiple with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.muted)"); CompiledName("muted_1")>]
            member __.muted with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.name)"); CompiledName("name_36")>]
            member __.name with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.noValidate)"); CompiledName("noValidate_1")>]
            member __.noValidate with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.open)"); CompiledName("_open_6")>]
            member __._open with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pattern)"); CompiledName("pattern_1")>]
            member __.pattern with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.placeholder)"); CompiledName("placeholder_2")>]
            member __.placeholder with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.poster)"); CompiledName("poster_1")>]
            member __.poster with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preload)"); CompiledName("preload_1")>]
            member __.preload with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.radioGroup)"); CompiledName("radioGroup")>]
            member __.radioGroup with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.readOnly)"); CompiledName("readOnly_4")>]
            member __.readOnly with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rel)"); CompiledName("rel_2")>]
            member __.rel with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.required)"); CompiledName("required_3")>]
            member __.required with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.role)"); CompiledName("role")>]
            member __.role with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rows)"); CompiledName("rows_4")>]
            member __.rows with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rowSpan)"); CompiledName("rowSpan_1")>]
            member __.rowSpan with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sandbox)"); CompiledName("sandbox_1")>]
            member __.sandbox with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scope)"); CompiledName("scope_2")>]
            member __.scope with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scrollLeft)"); CompiledName("scrollLeft_1")>]
            member __.scrollLeft with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scrolling)"); CompiledName("scrolling_2")>]
            member __.scrolling with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.scrollTop)"); CompiledName("scrollTop_1")>]
            member __.scrollTop with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.seamless)"); CompiledName("seamless")>]
            member __.seamless with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.selected)"); CompiledName("selected_2")>]
            member __.selected with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shape)"); CompiledName("shape_2")>]
            member __.shape with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.size)"); CompiledName("size_8")>]
            member __.size with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sizes)"); CompiledName("sizes")>]
            member __.sizes with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.span)"); CompiledName("span_1")>]
            member __.span with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.spellCheck)"); CompiledName("spellCheck")>]
            member __.spellCheck with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.src)"); CompiledName("src_11")>]
            member __.src with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.srcDoc)"); CompiledName("srcDoc")>]
            member __.srcDoc with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.srcSet)"); CompiledName("srcSet")>]
            member __.srcSet with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.start)"); CompiledName("start_7")>]
            member __.start with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.step)"); CompiledName("step_1")>]
            member __.step with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.style)"); CompiledName("style_8")>]
            member __.style with get() : FunScript.TypeScript.React.CSSProperties = failwith "never" and set (v : FunScript.TypeScript.React.CSSProperties) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tabIndex)"); CompiledName("tabIndex_1")>]
            member __.tabIndex with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.target)"); CompiledName("target_12")>]
            member __.target with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.title)"); CompiledName("title_4")>]
            member __.title with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.type)"); CompiledName("_type_38")>]
            member __._type with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.useMap)"); CompiledName("useMap_4")>]
            member __.useMap with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.value)"); CompiledName("value_17")>]
            member __.value with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.width)"); CompiledName("width_34")>]
            member __.width with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.wmode)"); CompiledName("wmode")>]
            member __.wmode with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoCapitalize)"); CompiledName("autoCapitalize")>]
            member __.autoCapitalize with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.autoCorrect)"); CompiledName("autoCorrect")>]
            member __.autoCorrect with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.property)"); CompiledName("_property")>]
            member __._property with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.itemProp)"); CompiledName("itemProp")>]
            member __.itemProp with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.itemScope)"); CompiledName("itemScope")>]
            member __.itemScope with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.itemType)"); CompiledName("itemType")>]
            member __.itemType with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_24 =


    type FunScript.TypeScript.React.KeyboardEvent with

            [<FunScript.JSEmitInline("({0}.altKey)"); CompiledName("altKey_4")>]
            member __.altKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.charCode)"); CompiledName("charCode_1")>]
            member __.charCode with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ctrlKey)"); CompiledName("ctrlKey_4")>]
            member __.ctrlKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState({1}))"); CompiledName("getModifierState_2")>]
            member __.getModifierState(key : string) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState = {1})"); CompiledName("getModifierState_2Aux")>]
            member __.``getModifierState <-``(func : System.Func<string, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.key)"); CompiledName("key_5")>]
            member __.key with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.keyCode)"); CompiledName("keyCode_2")>]
            member __.keyCode with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.locale)"); CompiledName("locale_6")>]
            member __.locale with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.location)"); CompiledName("location_4")>]
            member __.location with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.metaKey)"); CompiledName("metaKey_3")>]
            member __.metaKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.repeat)"); CompiledName("repeat_2")>]
            member __.repeat with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shiftKey)"); CompiledName("shiftKey_4")>]
            member __.shiftKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.which)"); CompiledName("which_2")>]
            member __.which with get() : float = failwith "never" and set (v : float) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_25 =


    type FunScript.TypeScript.React.Mixin<'P, 'S> with

            [<FunScript.JSEmitInline("({0}.mixins)"); CompiledName("mixins")>]
            member __.mixins with get() : FunScript.TypeScript.React.Mixin<'P, 'S> = failwith "never" and set (v : FunScript.TypeScript.React.Mixin<'P, 'S>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.statics)"); CompiledName("statics")>]
            member __.statics with get() : FunScript.TypeScript.React.AnonymousType445<'P, 'S> = failwith "never" and set (v : FunScript.TypeScript.React.AnonymousType445<'P, 'S>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.displayName)"); CompiledName("displayName_1")>]
            member __.displayName with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.propTypes)"); CompiledName("propTypes_1")>]
            member __.propTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.contextTypes)"); CompiledName("contextTypes_1")>]
            member __.contextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.childContextTypes)"); CompiledName("childContextTypes_1")>]
            member __.childContextTypes with get() : FunScript.TypeScript.React.ValidationMap<obj> = failwith "never" and set (v : FunScript.TypeScript.React.ValidationMap<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps())"); CompiledName("getDefaultProps_1")>]
            member __.getDefaultProps() : 'P = failwith "never"
            [<FunScript.JSEmitInline("({0}.getDefaultProps = {1})"); CompiledName("getDefaultProps_1Aux")>]
            member __.``getDefaultProps <-``(func : System.Func<'P>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState())"); CompiledName("getInitialState_1")>]
            member __.getInitialState() : 'S = failwith "never"
            [<FunScript.JSEmitInline("({0}.getInitialState = {1})"); CompiledName("getInitialState_1Aux")>]
            member __.``getInitialState <-``(func : System.Func<'S>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_26 =


    type FunScript.TypeScript.React.MouseEvent with

            [<FunScript.JSEmitInline("({0}.altKey)"); CompiledName("altKey_5")>]
            member __.altKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.button)"); CompiledName("button_3")>]
            member __.button with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.buttons)"); CompiledName("buttons_2")>]
            member __.buttons with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientX)"); CompiledName("clientX_4")>]
            member __.clientX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientY)"); CompiledName("clientY_4")>]
            member __.clientY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ctrlKey)"); CompiledName("ctrlKey_5")>]
            member __.ctrlKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState({1}))"); CompiledName("getModifierState_3")>]
            member __.getModifierState(key : string) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState = {1})"); CompiledName("getModifierState_3Aux")>]
            member __.``getModifierState <-``(func : System.Func<string, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.metaKey)"); CompiledName("metaKey_4")>]
            member __.metaKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageX)"); CompiledName("pageX_1")>]
            member __.pageX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageY)"); CompiledName("pageY_1")>]
            member __.pageY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.relatedTarget)"); CompiledName("relatedTarget_4")>]
            member __.relatedTarget with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenX)"); CompiledName("screenX_6")>]
            member __.screenX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenY)"); CompiledName("screenY_6")>]
            member __.screenY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shiftKey)"); CompiledName("shiftKey_5")>]
            member __.shiftKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_27 =


    type FunScript.TypeScript.React.Props<'T> with

            [<FunScript.JSEmitInline("({0}.children)"); CompiledName("children_1")>]
            member __.children with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.key)"); CompiledName("key_6")>]
            member __.key with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)"); CompiledName("_ref_3")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_28 =


    type FunScript.TypeScript.React.Globals with

            [<FunScript.JSEmitInline("(React.createClass({0}))"); CompiledName("createClass")>]
            static member createClass<'P, 'S>(spec : FunScript.TypeScript.React.ComponentSpec<'P, 'S>) : FunScript.TypeScript.React.ClassicComponentClass<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createClass = {0})"); CompiledName("createClassAux")>]
            static member ``createClass <-``<'P, 'S>(func : System.Func<FunScript.TypeScript.React.ComponentSpec<'P, 'S>, FunScript.TypeScript.React.ClassicComponentClass<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory({0}))"); CompiledName("createFactory")>]
            static member createFactory<'P>(_type : string) : FunScript.TypeScript.React.DOMFactory<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory = {0})"); CompiledName("createFactoryAux")>]
            static member ``createFactory <-``<'P>(func : System.Func<string, FunScript.TypeScript.React.DOMFactory<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory({0}))"); CompiledName("createFactory_1")>]
            static member createFactory<'P>(_type : FunScript.TypeScript.React.ClassicComponentClass<'P>) : FunScript.TypeScript.React.ClassicFactory<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory = {0})"); CompiledName("createFactory_1Aux")>]
            static member ``createFactory <-``<'P>(func : System.Func<FunScript.TypeScript.React.ClassicComponentClass<'P>, FunScript.TypeScript.React.ClassicFactory<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory({0}))"); CompiledName("createFactory_2")>]
            static member createFactory<'P>(_type : FunScript.TypeScript.React.ComponentClass<'P>) : FunScript.TypeScript.React.Factory<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createFactory = {0})"); CompiledName("createFactory_2Aux")>]
            static member ``createFactory <-``<'P>(func : System.Func<FunScript.TypeScript.React.ComponentClass<'P>, FunScript.TypeScript.React.Factory<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {?1}))"); CompiledName("createElement_122")>]
            static member createElement<'P>(_type : string, ?props : 'P) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement = {0})"); CompiledName("createElement_122Aux")>]
            static member ``createElement <-``<'P>(func : System.Func<string, 'P, FunScript.TypeScript.React.DOMElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {1}, {2...}))"); CompiledName("createElement_123")>]
            static member createElement<'P>(_type : string, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {?1}))"); CompiledName("createElement_124")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ClassicComponentClass<'P>, ?props : 'P) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement = {0})"); CompiledName("createElement_124Aux")>]
            static member ``createElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ClassicComponentClass<'P>, 'P, FunScript.TypeScript.React.ClassicElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {1}, {2...}))"); CompiledName("createElement_125")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ClassicComponentClass<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {?1}))"); CompiledName("createElement_126")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ComponentClass<'P>, ?props : 'P) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement = {0})"); CompiledName("createElement_126Aux")>]
            static member ``createElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ComponentClass<'P>, 'P, FunScript.TypeScript.React.ReactElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.createElement({0}, {1}, {2...}))"); CompiledName("createElement_127")>]
            static member createElement<'P>(_type : FunScript.TypeScript.React.ComponentClass<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {?1}))"); CompiledName("cloneElement")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.DOMElement<'P>, ?props : 'P) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement = {0})"); CompiledName("cloneElementAux")>]
            static member ``cloneElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.DOMElement<'P>, 'P, FunScript.TypeScript.React.DOMElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {1}, {2...}))"); CompiledName("cloneElement_1")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.DOMElement<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.DOMElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {?1}))"); CompiledName("cloneElement_2")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ClassicElement<'P>, ?props : 'P) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement = {0})"); CompiledName("cloneElement_2Aux")>]
            static member ``cloneElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ClassicElement<'P>, 'P, FunScript.TypeScript.React.ClassicElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {1}, {2...}))"); CompiledName("cloneElement_3")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ClassicElement<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ClassicElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {?1}))"); CompiledName("cloneElement_4")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ReactElement<'P>, ?props : 'P) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement = {0})"); CompiledName("cloneElement_4Aux")>]
            static member ``cloneElement <-``<'P>(func : System.Func<FunScript.TypeScript.React.ReactElement<'P>, 'P, FunScript.TypeScript.React.ReactElement<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.cloneElement({0}, {1}, {2...}))"); CompiledName("cloneElement_5")>]
            static member cloneElement<'P>(element : FunScript.TypeScript.React.ReactElement<'P>, props : 'P, [<System.ParamArray>] children : array<obj>) : FunScript.TypeScript.React.ReactElement<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.render({0}, {1}, {?2}))"); CompiledName("render_1")>]
            static member render<'P>(element : FunScript.TypeScript.React.DOMElement<'P>, container : FunScript.TypeScript.Element, ?callback : System.Func<obj>) : FunScript.TypeScript.React.DOMComponent<'P> = failwith "never"
            [<FunScript.JSEmitInline("(React.render = {0})"); CompiledName("render_1Aux")>]
            static member ``render <-``<'P>(func : System.Func<FunScript.TypeScript.React.DOMElement<'P>, FunScript.TypeScript.Element, System.Func<obj>, FunScript.TypeScript.React.DOMComponent<'P>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.render({0}, {1}, {?2}))"); CompiledName("render_2")>]
            static member render<'P, 'S>(element : FunScript.TypeScript.React.ClassicElement<'P>, container : FunScript.TypeScript.Element, ?callback : System.Func<obj>) : FunScript.TypeScript.React.ClassicComponent<'P, 'S> = failwith "never"
            [<FunScript.JSEmitInline("(React.render = {0})"); CompiledName("render_2Aux")>]
            static member ``render <-``<'P, 'S>(func : System.Func<FunScript.TypeScript.React.ClassicElement<'P>, FunScript.TypeScript.Element, System.Func<obj>, FunScript.TypeScript.React.ClassicComponent<'P, 'S>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.render({0}, {1}, {?2}))"); CompiledName("render_3")>]
            static member render<'P, 'S>(element : FunScript.TypeScript.React.ReactElement<'P>, container : FunScript.TypeScript.Element, ?callback : System.Func<obj>) : FunScript.TypeScript.React.Component<'P, 'S> = failwith "never"
            [<FunScript.JSEmitInline("(React.render = {0})"); CompiledName("render_3Aux")>]
            static member ``render <-``<'P, 'S>(func : System.Func<FunScript.TypeScript.React.ReactElement<'P>, FunScript.TypeScript.Element, System.Func<obj>, FunScript.TypeScript.React.Component<'P, 'S>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.unmountComponentAtNode({0}))"); CompiledName("unmountComponentAtNode")>]
            static member unmountComponentAtNode(container : FunScript.TypeScript.Element) : bool = failwith "never"
            [<FunScript.JSEmitInline("(React.unmountComponentAtNode = {0})"); CompiledName("unmountComponentAtNodeAux")>]
            static member ``unmountComponentAtNode <-``(func : System.Func<FunScript.TypeScript.Element, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToString({0}))"); CompiledName("renderToString")>]
            static member renderToString(element : FunScript.TypeScript.React.ReactElement<obj>) : string = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToString = {0})"); CompiledName("renderToStringAux")>]
            static member ``renderToString <-``(func : System.Func<FunScript.TypeScript.React.ReactElement<obj>, string>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToStaticMarkup({0}))"); CompiledName("renderToStaticMarkup")>]
            static member renderToStaticMarkup(element : FunScript.TypeScript.React.ReactElement<obj>) : string = failwith "never"
            [<FunScript.JSEmitInline("(React.renderToStaticMarkup = {0})"); CompiledName("renderToStaticMarkupAux")>]
            static member ``renderToStaticMarkup <-``(func : System.Func<FunScript.TypeScript.React.ReactElement<obj>, string>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.isValidElement({0}))"); CompiledName("isValidElement")>]
            static member isValidElement(_object : FunScript.TypeScript.React.AnonymousType443) : bool = failwith "never"
            [<FunScript.JSEmitInline("(React.isValidElement = {0})"); CompiledName("isValidElementAux")>]
            static member ``isValidElement <-``(func : System.Func<FunScript.TypeScript.React.AnonymousType443, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.initializeTouchEvents({0}))"); CompiledName("initializeTouchEvents")>]
            static member initializeTouchEvents(shouldUseTouch : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.initializeTouchEvents = {0})"); CompiledName("initializeTouchEventsAux")>]
            static member ``initializeTouchEvents <-``(func : System.Func<bool, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))"); CompiledName("findDOMNode")>]
            static member findDOMNode<'TElement when 'TElement :> FunScript.TypeScript.Element>(_component : FunScript.TypeScript.React.Component<obj, obj>) : 'TElement = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})"); CompiledName("findDOMNodeAux")>]
            static member ``findDOMNode <-``<'TElement when 'TElement :> FunScript.TypeScript.Element>(func : System.Func<FunScript.TypeScript.React.Component<obj, obj>, 'TElement>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))"); CompiledName("findDOMNode_1")>]
            static member findDOMNode<'TElement when 'TElement :> FunScript.TypeScript.Element>(element : FunScript.TypeScript.Element) : 'TElement = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})"); CompiledName("findDOMNode_1Aux")>]
            static member ``findDOMNode <-``<'TElement when 'TElement :> FunScript.TypeScript.Element>(func : System.Func<FunScript.TypeScript.Element, 'TElement>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))"); CompiledName("findDOMNode_2")>]
            static member findDOMNode(_component : FunScript.TypeScript.React.Component<obj, obj>) : FunScript.TypeScript.Element = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})"); CompiledName("findDOMNode_2Aux")>]
            static member ``findDOMNode <-``(func : System.Func<FunScript.TypeScript.React.Component<obj, obj>, FunScript.TypeScript.Element>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode({0}))"); CompiledName("findDOMNode_3")>]
            static member findDOMNode(element : FunScript.TypeScript.Element) : FunScript.TypeScript.Element = failwith "never"
            [<FunScript.JSEmitInline("(React.findDOMNode = {0})"); CompiledName("findDOMNode_3Aux")>]
            static member ``findDOMNode <-``(func : System.Func<FunScript.TypeScript.Element, FunScript.TypeScript.Element>) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.DOM)"); CompiledName("DOM")>]
            static member DOM with get() : FunScript.TypeScript.React.ReactDOM = failwith "never" and set (v : FunScript.TypeScript.React.ReactDOM) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.PropTypes)"); CompiledName("PropTypes")>]
            static member PropTypes with get() : FunScript.TypeScript.React.ReactPropTypes = failwith "never" and set (v : FunScript.TypeScript.React.ReactPropTypes) : unit = failwith "never"
            [<FunScript.JSEmitInline("(React.Children)"); CompiledName("Children")>]
            static member Children with get() : FunScript.TypeScript.React.anyren = failwith "never" and set (v : FunScript.TypeScript.React.anyren) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_29 =


    type FunScript.TypeScript.React.ReactDOM with

            [<FunScript.JSEmitInline("({0}.a)"); CompiledName("a_2")>]
            member __.a with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.abbr)"); CompiledName("abbr_1")>]
            member __.abbr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.address)"); CompiledName("address")>]
            member __.address with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.area)"); CompiledName("area")>]
            member __.area with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.article)"); CompiledName("article")>]
            member __.article with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.aside)"); CompiledName("aside")>]
            member __.aside with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.audio)"); CompiledName("audio")>]
            member __.audio with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.b)"); CompiledName("b_2")>]
            member __.b with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.base)"); CompiledName("_base")>]
            member __._base with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.bdi)"); CompiledName("bdi")>]
            member __.bdi with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.bdo)"); CompiledName("bdo")>]
            member __.bdo with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.big)"); CompiledName("big")>]
            member __.big with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.blockquote)"); CompiledName("blockquote")>]
            member __.blockquote with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.body)"); CompiledName("body_1")>]
            member __.body with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.br)"); CompiledName("br")>]
            member __.br with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.button)"); CompiledName("button_4")>]
            member __.button with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.canvas)"); CompiledName("canvas_2")>]
            member __.canvas with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.caption)"); CompiledName("caption_1")>]
            member __.caption with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cite)"); CompiledName("cite_5")>]
            member __.cite with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.code)"); CompiledName("code_10")>]
            member __.code with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.col)"); CompiledName("col")>]
            member __.col with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.colgroup)"); CompiledName("colgroup")>]
            member __.colgroup with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.data)"); CompiledName("data_10")>]
            member __.data with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.datalist)"); CompiledName("datalist")>]
            member __.datalist with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dd)"); CompiledName("dd")>]
            member __.dd with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.del)"); CompiledName("del")>]
            member __.del with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.details)"); CompiledName("details")>]
            member __.details with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dfn)"); CompiledName("dfn")>]
            member __.dfn with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dialog)"); CompiledName("dialog")>]
            member __.dialog with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.div)"); CompiledName("div")>]
            member __.div with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dl)"); CompiledName("dl")>]
            member __.dl with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dt)"); CompiledName("dt")>]
            member __.dt with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.em)"); CompiledName("em")>]
            member __.em with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.embed)"); CompiledName("embed")>]
            member __.embed with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fieldset)"); CompiledName("fieldset")>]
            member __.fieldset with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.figcaption)"); CompiledName("figcaption")>]
            member __.figcaption with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.figure)"); CompiledName("figure")>]
            member __.figure with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.footer)"); CompiledName("footer")>]
            member __.footer with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.form)"); CompiledName("form_14")>]
            member __.form with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h1)"); CompiledName("h1")>]
            member __.h1 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h2)"); CompiledName("h2")>]
            member __.h2 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h3)"); CompiledName("h3")>]
            member __.h3 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h4)"); CompiledName("h4")>]
            member __.h4 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h5)"); CompiledName("h5")>]
            member __.h5 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.h6)"); CompiledName("h6")>]
            member __.h6 with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.head)"); CompiledName("head_1")>]
            member __.head with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.header)"); CompiledName("header")>]
            member __.header with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.hr)"); CompiledName("hr")>]
            member __.hr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.html)"); CompiledName("html")>]
            member __.html with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.i)"); CompiledName("i")>]
            member __.i with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.iframe)"); CompiledName("iframe")>]
            member __.iframe with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.img)"); CompiledName("img")>]
            member __.img with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.input)"); CompiledName("input_2")>]
            member __.input with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ins)"); CompiledName("ins")>]
            member __.ins with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.kbd)"); CompiledName("kbd")>]
            member __.kbd with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.keygen)"); CompiledName("keygen")>]
            member __.keygen with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.label)"); CompiledName("label_6")>]
            member __.label with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.legend)"); CompiledName("legend")>]
            member __.legend with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.li)"); CompiledName("li")>]
            member __.li with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.link)"); CompiledName("link_1")>]
            member __.link with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.main)"); CompiledName("main")>]
            member __.main with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.map)"); CompiledName("map_1")>]
            member __.map with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.mark)"); CompiledName("mark_1")>]
            member __.mark with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.menu)"); CompiledName("menu")>]
            member __.menu with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.menuitem)"); CompiledName("menuitem")>]
            member __.menuitem with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.meta)"); CompiledName("meta")>]
            member __.meta with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.meter)"); CompiledName("meter")>]
            member __.meter with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.nav)"); CompiledName("nav")>]
            member __.nav with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.noscript)"); CompiledName("noscript")>]
            member __.noscript with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.object)"); CompiledName("_object_2")>]
            member __._object with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ol)"); CompiledName("ol")>]
            member __.ol with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.optgroup)"); CompiledName("optgroup")>]
            member __.optgroup with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.option)"); CompiledName("option")>]
            member __.option with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.output)"); CompiledName("output")>]
            member __.output with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.p)"); CompiledName("p")>]
            member __.p with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.param)"); CompiledName("param")>]
            member __.param with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.picture)"); CompiledName("picture")>]
            member __.picture with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pre)"); CompiledName("pre")>]
            member __.pre with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.progress)"); CompiledName("progress")>]
            member __.progress with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.q)"); CompiledName("q")>]
            member __.q with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rp)"); CompiledName("rp")>]
            member __.rp with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rt)"); CompiledName("rt")>]
            member __.rt with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ruby)"); CompiledName("ruby")>]
            member __.ruby with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.s)"); CompiledName("s")>]
            member __.s with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.samp)"); CompiledName("samp")>]
            member __.samp with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.script)"); CompiledName("script")>]
            member __.script with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.section)"); CompiledName("section")>]
            member __.section with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.select)"); CompiledName("select_5")>]
            member __.select with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.small)"); CompiledName("small")>]
            member __.small with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.source)"); CompiledName("source_5")>]
            member __.source with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.span)"); CompiledName("span_2")>]
            member __.span with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strong)"); CompiledName("strong")>]
            member __.strong with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.style)"); CompiledName("style_9")>]
            member __.style with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sub)"); CompiledName("sub")>]
            member __.sub with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.summary)"); CompiledName("summary_1")>]
            member __.summary with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.sup)"); CompiledName("sup")>]
            member __.sup with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.table)"); CompiledName("table")>]
            member __.table with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tbody)"); CompiledName("tbody")>]
            member __.tbody with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.td)"); CompiledName("td")>]
            member __.td with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.textarea)"); CompiledName("textarea")>]
            member __.textarea with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tfoot)"); CompiledName("tfoot")>]
            member __.tfoot with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.th)"); CompiledName("th")>]
            member __.th with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.thead)"); CompiledName("thead")>]
            member __.thead with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.time)"); CompiledName("time_1")>]
            member __.time with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.title)"); CompiledName("title_5")>]
            member __.title with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tr)"); CompiledName("tr")>]
            member __.tr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.track)"); CompiledName("track_3")>]
            member __.track with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.u)"); CompiledName("u")>]
            member __.u with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ul)"); CompiledName("ul")>]
            member __.ul with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}[\"var\"])"); CompiledName("``var``")>]
            member __.``var`` with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.video)"); CompiledName("video")>]
            member __.video with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.wbr)"); CompiledName("wbr")>]
            member __.wbr with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.HTMLAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.circle)"); CompiledName("circle")>]
            member __.circle with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defs)"); CompiledName("defs")>]
            member __.defs with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ellipse)"); CompiledName("ellipse")>]
            member __.ellipse with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.g)"); CompiledName("g")>]
            member __.g with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.line)"); CompiledName("line")>]
            member __.line with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.linearGradient)"); CompiledName("linearGradient")>]
            member __.linearGradient with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.mask)"); CompiledName("mask_1")>]
            member __.mask with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.path)"); CompiledName("path")>]
            member __.path with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pattern)"); CompiledName("pattern_2")>]
            member __.pattern with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.polygon)"); CompiledName("polygon")>]
            member __.polygon with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.polyline)"); CompiledName("polyline")>]
            member __.polyline with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.radialGradient)"); CompiledName("radialGradient")>]
            member __.radialGradient with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rect)"); CompiledName("rect_1")>]
            member __.rect with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stop)"); CompiledName("stop_3")>]
            member __.stop with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.svg)"); CompiledName("svg")>]
            member __.svg with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.text)"); CompiledName("text_9")>]
            member __.text with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.tspan)"); CompiledName("tspan")>]
            member __.tspan with get() : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes> = failwith "never" and set (v : FunScript.TypeScript.React.DOMFactory<FunScript.TypeScript.React.SVGAttributes>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_30 =


    type FunScript.TypeScript.React.ReactElement<'P> with

            [<FunScript.JSEmitInline("({0}.type)"); CompiledName("_type_39")>]
            member __._type with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.props)"); CompiledName("props_1")>]
            member __.props with get() : 'P = failwith "never" and set (v : 'P) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.key)"); CompiledName("key_7")>]
            member __.key with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ref)"); CompiledName("_ref_4")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_31 =


    type FunScript.TypeScript.React.ReactPropTypes with

            [<FunScript.JSEmitInline("({0}.any)"); CompiledName("any")>]
            member __.any with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.array)"); CompiledName("array")>]
            member __.array with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.bool)"); CompiledName("_bool")>]
            member __._bool with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.func)"); CompiledName("func")>]
            member __.func with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.number)"); CompiledName("number")>]
            member __.number with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.object)"); CompiledName("_object_3")>]
            member __._object with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.string)"); CompiledName("_string")>]
            member __._string with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.node)"); CompiledName("node")>]
            member __.node with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.element)"); CompiledName("element")>]
            member __.element with get() : FunScript.TypeScript.React.Requireable<obj> = failwith "never" and set (v : FunScript.TypeScript.React.Requireable<obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.instanceOf({1}))"); CompiledName("instanceOf")>]
            member __.instanceOf(expectedClass : FunScript.TypeScript.React.AnonymousType447) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.instanceOf = {1})"); CompiledName("instanceOfAux")>]
            member __.``instanceOf <-``(func : System.Func<FunScript.TypeScript.React.AnonymousType447, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOf({1}))"); CompiledName("oneOf")>]
            member __.oneOf(types : array<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOf = {1})"); CompiledName("oneOfAux")>]
            member __.``oneOf <-``(func : System.Func<array<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOfType({1}))"); CompiledName("oneOfType")>]
            member __.oneOfType(types : array<FunScript.TypeScript.React.ValidatorDelegate<obj>>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.oneOfType = {1})"); CompiledName("oneOfTypeAux")>]
            member __.``oneOfType <-``(func : System.Func<array<FunScript.TypeScript.React.ValidatorDelegate<obj>>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.arrayOf({1}))"); CompiledName("arrayOf")>]
            member __.arrayOf(_type : FunScript.TypeScript.React.ValidatorDelegate<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.arrayOf = {1})"); CompiledName("arrayOfAux")>]
            member __.``arrayOf <-``(func : System.Func<FunScript.TypeScript.React.ValidatorDelegate<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.objectOf({1}))"); CompiledName("objectOf")>]
            member __.objectOf(_type : FunScript.TypeScript.React.ValidatorDelegate<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.objectOf = {1})"); CompiledName("objectOfAux")>]
            member __.``objectOf <-``(func : System.Func<FunScript.TypeScript.React.ValidatorDelegate<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shape({1}))"); CompiledName("shape_3")>]
            member __.shape(_type : FunScript.TypeScript.React.ValidationMap<obj>) : FunScript.TypeScript.React.Requireable<obj> = failwith "never"
            [<FunScript.JSEmitInline("({0}.shape = {1})"); CompiledName("shape_3Aux")>]
            member __.``shape <-``(func : System.Func<FunScript.TypeScript.React.ValidationMap<obj>, FunScript.TypeScript.React.Requireable<obj>>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_32 =


    type FunScript.TypeScript.React.Requireable<'T> with

            [<FunScript.JSEmitInline("({0}.isRequired)"); CompiledName("isRequired")>]
            member __.isRequired with get() : FunScript.TypeScript.React.ValidatorDelegate<'T> = failwith "never" and set (v : FunScript.TypeScript.React.ValidatorDelegate<'T>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_33 =


    type FunScript.TypeScript.React.SVGAttributes with

            [<FunScript.JSEmitInline("({0}.ref)"); CompiledName("_ref_5")>]
            member __._ref with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cx)"); CompiledName("cx_3")>]
            member __.cx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cy)"); CompiledName("cy_3")>]
            member __.cy with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.d)"); CompiledName("d_2")>]
            member __.d with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dx)"); CompiledName("dx_2")>]
            member __.dx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.dy)"); CompiledName("dy_2")>]
            member __.dy with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fill)"); CompiledName("fill_2")>]
            member __.fill with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fillOpacity)"); CompiledName("fillOpacity_2")>]
            member __.fillOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fontFamily)"); CompiledName("fontFamily_1")>]
            member __.fontFamily with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fontSize)"); CompiledName("fontSize_1")>]
            member __.fontSize with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fx)"); CompiledName("fx_1")>]
            member __.fx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.fy)"); CompiledName("fy_1")>]
            member __.fy with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.gradientTransform)"); CompiledName("gradientTransform_1")>]
            member __.gradientTransform with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.gradientUnits)"); CompiledName("gradientUnits_1")>]
            member __.gradientUnits with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.markerEnd)"); CompiledName("markerEnd_1")>]
            member __.markerEnd with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.markerMid)"); CompiledName("markerMid_1")>]
            member __.markerMid with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.markerStart)"); CompiledName("markerStart_1")>]
            member __.markerStart with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.offset)"); CompiledName("offset_2")>]
            member __.offset with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.opacity)"); CompiledName("opacity_2")>]
            member __.opacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.patternContentUnits)"); CompiledName("patternContentUnits_1")>]
            member __.patternContentUnits with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.patternUnits)"); CompiledName("patternUnits_1")>]
            member __.patternUnits with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.points)"); CompiledName("points_1")>]
            member __.points with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preserveAspectRatio)"); CompiledName("preserveAspectRatio_3")>]
            member __.preserveAspectRatio with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.r)"); CompiledName("r_2")>]
            member __.r with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.rx)"); CompiledName("rx_2")>]
            member __.rx with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ry)"); CompiledName("ry_2")>]
            member __.ry with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.spreadMethod)"); CompiledName("spreadMethod_1")>]
            member __.spreadMethod with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopColor)"); CompiledName("stopColor_1")>]
            member __.stopColor with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopOpacity)"); CompiledName("stopOpacity_1")>]
            member __.stopOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stroke)"); CompiledName("stroke_2")>]
            member __.stroke with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeDasharray)"); CompiledName("strokeDasharray_1")>]
            member __.strokeDasharray with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeLinecap)"); CompiledName("strokeLinecap_1")>]
            member __.strokeLinecap with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeOpacity)"); CompiledName("strokeOpacity_2")>]
            member __.strokeOpacity with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.strokeWidth)"); CompiledName("strokeWidth_2")>]
            member __.strokeWidth with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.textAnchor)"); CompiledName("textAnchor_1")>]
            member __.textAnchor with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.transform)"); CompiledName("transform_3")>]
            member __.transform with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.version)"); CompiledName("version_4")>]
            member __.version with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.viewBox)"); CompiledName("viewBox_1")>]
            member __.viewBox with get() : string = failwith "never" and set (v : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.x1)"); CompiledName("x1_6")>]
            member __.x1 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.x2)"); CompiledName("x2_6")>]
            member __.x2 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.x)"); CompiledName("x_33")>]
            member __.x with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.y1)"); CompiledName("y1_6")>]
            member __.y1 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.y2)"); CompiledName("y2_6")>]
            member __.y2 with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.y)"); CompiledName("y_33")>]
            member __.y with get() : float = failwith "never" and set (v : float) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_34 =


    type FunScript.TypeScript.React.SyntheticEvent with

            [<FunScript.JSEmitInline("({0}.bubbles)"); CompiledName("bubbles_2")>]
            member __.bubbles with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.cancelable)"); CompiledName("cancelable_2")>]
            member __.cancelable with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.currentTarget)"); CompiledName("currentTarget_1")>]
            member __.currentTarget with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.defaultPrevented)"); CompiledName("defaultPrevented_1")>]
            member __.defaultPrevented with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.eventPhase)"); CompiledName("eventPhase_1")>]
            member __.eventPhase with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.isTrusted)"); CompiledName("isTrusted_1")>]
            member __.isTrusted with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.nativeEvent)"); CompiledName("nativeEvent")>]
            member __.nativeEvent with get() : FunScript.TypeScript.Event = failwith "never" and set (v : FunScript.TypeScript.Event) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preventDefault())"); CompiledName("preventDefault_1")>]
            member __.preventDefault() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.preventDefault = {1})"); CompiledName("preventDefault_1Aux")>]
            member __.``preventDefault <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopPropagation())"); CompiledName("stopPropagation_1")>]
            member __.stopPropagation() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.stopPropagation = {1})"); CompiledName("stopPropagation_1Aux")>]
            member __.``stopPropagation <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.target)"); CompiledName("target_13")>]
            member __.target with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.timeStamp)"); CompiledName("timeStamp_1")>]
            member __.timeStamp with get() : FunScript.TypeScript.Date = failwith "never" and set (v : FunScript.TypeScript.Date) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.type)"); CompiledName("_type_40")>]
            member __._type with get() : string = failwith "never" and set (v : string) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_35 =


    type FunScript.TypeScript.React.Touch with

            [<FunScript.JSEmitInline("({0}.identifier)"); CompiledName("identifier")>]
            member __.identifier with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.target)"); CompiledName("target_14")>]
            member __.target with get() : FunScript.TypeScript.EventTarget = failwith "never" and set (v : FunScript.TypeScript.EventTarget) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenX)"); CompiledName("screenX_7")>]
            member __.screenX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.screenY)"); CompiledName("screenY_7")>]
            member __.screenY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientX)"); CompiledName("clientX_5")>]
            member __.clientX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.clientY)"); CompiledName("clientY_5")>]
            member __.clientY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageX)"); CompiledName("pageX_2")>]
            member __.pageX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.pageY)"); CompiledName("pageY_2")>]
            member __.pageY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_36 =


    type FunScript.TypeScript.React.TouchEvent with

            [<FunScript.JSEmitInline("({0}.altKey)"); CompiledName("altKey_6")>]
            member __.altKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.changedTouches)"); CompiledName("changedTouches")>]
            member __.changedTouches with get() : FunScript.TypeScript.React.TouchList = failwith "never" and set (v : FunScript.TypeScript.React.TouchList) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.ctrlKey)"); CompiledName("ctrlKey_6")>]
            member __.ctrlKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState({1}))"); CompiledName("getModifierState_4")>]
            member __.getModifierState(key : string) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.getModifierState = {1})"); CompiledName("getModifierState_4Aux")>]
            member __.``getModifierState <-``(func : System.Func<string, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.metaKey)"); CompiledName("metaKey_5")>]
            member __.metaKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.shiftKey)"); CompiledName("shiftKey_6")>]
            member __.shiftKey with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.targetTouches)"); CompiledName("targetTouches")>]
            member __.targetTouches with get() : FunScript.TypeScript.React.TouchList = failwith "never" and set (v : FunScript.TypeScript.React.TouchList) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.touches)"); CompiledName("touches")>]
            member __.touches with get() : FunScript.TypeScript.React.TouchList = failwith "never" and set (v : FunScript.TypeScript.React.TouchList) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_37 =


    type FunScript.TypeScript.React.TouchList with

            [<FunScript.JSEmitInline("({0}[{1}])"); CompiledName("Item_45")>]
            member __.Item with get(i : int) : FunScript.TypeScript.React.Touch = failwith "never" and set (i : int) (v : FunScript.TypeScript.React.Touch) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.length)"); CompiledName("length_52")>]
            member __.length with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.item({1}))"); CompiledName("item_33")>]
            member __.item(index : float) : FunScript.TypeScript.React.Touch = failwith "never"
            [<FunScript.JSEmitInline("({0}.item = {1})"); CompiledName("item_33Aux")>]
            member __.``item <-``(func : System.Func<float, FunScript.TypeScript.React.Touch>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.identifiedTouch({1}))"); CompiledName("identifiedTouch")>]
            member __.identifiedTouch(identifier : float) : FunScript.TypeScript.React.Touch = failwith "never"
            [<FunScript.JSEmitInline("({0}.identifiedTouch = {1})"); CompiledName("identifiedTouchAux")>]
            member __.``identifiedTouch <-``(func : System.Func<float, FunScript.TypeScript.React.Touch>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_38 =


    type FunScript.TypeScript.React.UIEvent with

            [<FunScript.JSEmitInline("({0}.detail)"); CompiledName("detail_3")>]
            member __.detail with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.view)"); CompiledName("view_2")>]
            member __.view with get() : FunScript.TypeScript.React.AbstractView = failwith "never" and set (v : FunScript.TypeScript.React.AbstractView) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_39 =


    type FunScript.TypeScript.React.ValidationMap<'T> with

            [<FunScript.JSEmitInline("({0}[{1}])"); CompiledName("Item_46")>]
            member __.Item with get(i : string) : FunScript.TypeScript.React.ValidatorDelegate<'T> = failwith "never" and set (i : string) (v : FunScript.TypeScript.React.ValidatorDelegate<'T>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_40 =


    type FunScript.TypeScript.React.Validator<'T> with

            [<FunScript.JSEmitInline("({0}({1}, {2}, {3}))"); CompiledName("Invoke_44")>]
            member __.Invoke(_object : 'T, key : string, componentName : string) : FunScript.TypeScript.Error = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_44Aux")>]
            member __.``Invoke <-``(func : System.Func<'T, string, string, FunScript.TypeScript.Error>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_41 =


    type FunScript.TypeScript.React.WheelEvent with

            [<FunScript.JSEmitInline("({0}.deltaMode)"); CompiledName("deltaMode_1")>]
            member __.deltaMode with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.deltaX)"); CompiledName("deltaX_1")>]
            member __.deltaX with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.deltaY)"); CompiledName("deltaY_1")>]
            member __.deltaY with get() : float = failwith "never" and set (v : float) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.deltaZ)"); CompiledName("deltaZ_1")>]
            member __.deltaZ with get() : float = failwith "never" and set (v : float) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_react_42 =


    type FunScript.TypeScript.React.anyren with

            [<FunScript.JSEmitInline("({0}.map({1}, {2}))"); CompiledName("map_2")>]
            member __.map<'T>(children : obj, fn : System.Func<obj, 'T>) : FunScript.TypeScript.React.AnonymousType448 = failwith "never"
            [<FunScript.JSEmitInline("({0}.map = {1})"); CompiledName("map_2Aux")>]
            member __.``map <-``<'T>(func : System.Func<obj, System.Func<obj, 'T>, FunScript.TypeScript.React.AnonymousType448>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forEach({1}, {2}))"); CompiledName("forEach_3")>]
            member __.forEach(children : obj, fn : System.Func<obj, obj>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.forEach = {1})"); CompiledName("forEach_3Aux")>]
            member __.``forEach <-``(func : System.Func<obj, System.Func<obj, obj>, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.count({1}))"); CompiledName("count_3")>]
            member __.count(children : obj) : float = failwith "never"
            [<FunScript.JSEmitInline("({0}.count = {1})"); CompiledName("count_3Aux")>]
            member __.``count <-``(func : System.Func<obj, float>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.only({1}))"); CompiledName("only_1")>]
            member __.only(children : obj) : obj = failwith "never"
            [<FunScript.JSEmitInline("({0}.only = {1})"); CompiledName("only_1Aux")>]
            member __.``only <-``(func : System.Func<obj, obj>) : unit = failwith "never"
