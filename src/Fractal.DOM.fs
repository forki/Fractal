namespace Fractal

open System
open FunScript
open FunScript.TypeScript
open FunScript.TypeScript.React

[<ReflectedDefinition>]
[<AutoOpen>]
module DOM =



    type internal Union = {
        ``_CaseName`` : string
        Item : obj
    }

    let internal unionToTupple du =
        let lowerFirst = function | "" -> "" | s -> s.Substring(0,1).ToLower() + s.Substring(1)

        let du' = du |> unbox<Union>
        let name = (du'.``_CaseName``) |> lowerFirst
        name ==> du'.Item

    let internal attrsToObj lst =
        lst |> Array.map (unionToTupple) |> obj

    type Attr =
        | OnCopy of (Component.ClipboardEvent -> unit)
        | OnCut of (Component.ClipboardEvent -> unit)
        | OnPaste of (Component.ClipboardEvent -> unit )
        | OnKeyDown of (Component.KeyboardEvent -> unit)
        | OnKeyPress of (Component.KeyboardEvent -> unit)
        | OnKeyUp of (Component.KeyboardEvent -> unit)
        | OnFocus of (Component.FocusEvent -> unit)
        | OnBlur of (Component.FocusEvent -> unit)
        | OnChange of (Component.FormEvent -> unit)
        | OnInput of (Component.FormEvent -> unit)
        | OnSubmit of (Component.FormEvent -> unit)
        | OnClick of (Component.MouseEvent -> unit)
        | OnDoubleClick of (Component.MouseEvent -> unit)
        | OnDrag of (Component.DragEvent -> unit)
        | OnDragEnd of (Component.DragEvent -> unit)
        | OnDragEnter of (Component.DragEvent -> unit)
        | OnDragExit of (Component.DragEvent -> unit)
        | OnDragLeave of (Component.DragEvent -> unit)
        | OnDragOver of (Component.DragEvent -> unit)
        | OnDragStart of (Component.DragEvent -> unit)
        | OnDrop of (Component.DragEvent -> unit)
        | OnMouseDown of (Component.MouseEvent -> unit)
        | OnMouseEnter of (Component.MouseEvent -> unit)
        | OnMouseLeave of (Component.MouseEvent -> unit)
        | OnMouseMove of (Component.MouseEvent -> unit)
        | OnMouseOut of (Component.MouseEvent -> unit)
        | OnMouseOver of (Component.MouseEvent -> unit)
        | OnMouseUp of (Component.MouseEvent -> unit)
        | OnTouchCancel of (Component.TouchEvent -> unit)
        | OnTouchEnd of (Component.TouchEvent -> unit)
        | OnTouchMove of (Component.TouchEvent -> unit)
        | OnTouchStart of (Component.TouchEvent -> unit)
        | OnScroll of (Component.UIEvent -> unit)
        | OnWheel of (Component.WheelEvent -> unit)
        | Ref of string
        | Accept of string
        | AcceptCharset of string
        | AccessKey of string
        | Action of string
        | AllowFullScreen of bool
        | AllowTransparency of bool
        | Alt of string
        | Async of bool
        | AutoComplete of bool
        | AutoPlay of bool
        | CellPadding of float
        | CellSpacing of float
        | CharSet of string
        | Checked of bool
        | ClassId of string
        | ClassName of string
        | Cols of float
        | ColSpan of float
        | Content of string
        | ContentEditable of bool
        | ContextMenu of string
        | Controls of obj
        | Coords of string
        | CrossOrigin of string
        | Data of string
        | DateTime of string
        | Defer of bool
        | Dir of string
        | Disabled of bool
        | Download of obj
        | Draggable of bool
        | EncType of string
        | Form of string
        | FormNoValidate of bool
        | FrameBorder of float
        | Height of float
        | Hidden of bool
        | Href of string
        | HrefLang of string
        | HtmlFor of string
        | HttpEquiv of string
        | Icon of string
        | Id of string
        | Label of string
        | Lang of string
        | List of string
        | Loop of bool
        | Manifest of string
        | Max of float
        | MaxLength of float
        | Media of string
        | MediaGroup of string
        | Method of string
        | Min of float
        | Multiple of bool
        | Muted of bool
        | Name of string
        | NoValidate of bool
        | Open of bool
        | Pattern of string
        | Placeholder of string
        | Poster of string
        | Preload of string
        | RadioGroup of string
        | ReadOnly of bool
        | Rel of string
        | Required of bool
        | Role of string
        | Rows of float
        | RowSpan of float
        | Sandbox of string
        | Scope of string
        | ScrollLeft of float
        | Scrolling of string
        | ScrollTop of float
        | Seamless of bool
        | Selected of bool
        | Shape of string
        | Size of float
        | Sizes of string
        | Span of float
        | SpellCheck of bool
        | Src of string
        | SrcDoc of string
        | SrcSet of string
        | Start of float
        | Step of float
        | Style of obj // TODO CSS Properties DU!
        | TabIndex of float
        | Target of string
        | Title of string
        | Type of string
        | UseMap of string
        | Value of string
        | Width of float
        | Wmode of string
        | AutoCapitalize of bool
        | AutoFocus of bool
        | Property of string
        | ItemProp of string
        | ItemScope of bool
        | ItemType of string





    [<AbstractClass; Sealed>]
    type DOM () =
        static member a ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("a", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member abbr ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("abbr", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member address ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("address", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member area ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("area", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member article ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("article", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member aside ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("aside", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member audio ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("audio", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member b ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("b", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member base' ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("base", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member bdi ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("bdi", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member bdo ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("bdo", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member blockquote ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("blockquote", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member body ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("body", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member br ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("br", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member button ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("button", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member canvas ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("canvas", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member caption ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("caption", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member cite ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("cite", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member code ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("code", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member col ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("col", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member colgroup ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("colgroup", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member datalist ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("datalist", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member dd ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("dd", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member del ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("del", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member details ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("details", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member dfn ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("dfn", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member dialog ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("dialog", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member div ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("div", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member dl ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("dl", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member dt ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("dt", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member em ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("em", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member embed ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("embed", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member fieldset ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("fieldset", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member figcaption ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("figcaption", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member figure ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("figure", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member footer ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("footer", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member form ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("form", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member h1 ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("h1", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member h2 ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("h2", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member h3 ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("h3", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member h4 ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("h4", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member h5 ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("h5", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member h6 ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("h6", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member head ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("head", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member header ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("header", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member hr ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("hr", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member html ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("html", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member i ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("i", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member iframe ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("iframe", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member img ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("img", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member input ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("input", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member ins ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("ins", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member kbd ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("kbd", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member keygen ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("keygen", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member label ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("label", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member legend ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("legend", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member li ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("li", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member link ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("link", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member main ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("main", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member map ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("map", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member mark ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("mark", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member menu ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("menu", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member menuitem ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("menuitem", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member meta ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("meta", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member meter ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("meter", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member nav ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("nav", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member noscript ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("noscript", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member object' ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("object", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member ol ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("ol", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member optgroup ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("optgroup", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member option ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("option", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member output ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("output", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member p ((p' : Attr[]), [<ParamArray>] c) = Globals.createElement ("p", p', c) |> unbox<FractalElement<obj>>
        static member param ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("param", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member pre ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("pre", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member progress ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("progress", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member q ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("q", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member rp ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("rp", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member rt ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("rt", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member ruby ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("ruby", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member s ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("s", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member samp ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("samp", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member script ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("script", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member section ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("section", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member select ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("select", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member small ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("small", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member source ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("source", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member span ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("span", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member strong ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("strong", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member style ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("style", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member sub ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("sub", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member summary ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("summary", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member sup ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("sup", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member table ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("table", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member tbody ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("tbody", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member td ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("td", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member textarea ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("textarea", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member tfoot ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("tfoot", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member th ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("th", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member thead ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("thead", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member time ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("time", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member title ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("title", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member tr ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("tr", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member track ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("track", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member u ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("u", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member ul ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("ul", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member var ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("var", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member video ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("video", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member wbr ((p : Attr[]), [<ParamArray>] c) = Globals.createElement ("wbr", (attrsToObj p), c) |> unbox<FractalElement<obj>>
        static member Nothing = null |> unbox<Component.DOMElement<obj>> 
