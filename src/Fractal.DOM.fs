namespace Fractal

open System
open FunScript
open FunScript.TypeScript
open FunScript.TypeScript.React

[<ReflectedDefinition>]
[<AutoOpen>]
module DOM =

    type Attr =
        | OnCopy of (ClipboardEvent -> unit)
        | OnCut of (ClipboardEvent -> unit)
        | OnPaste of (ClipboardEvent -> unit )
        | OnKeyDown of (KeyboardEvent -> unit)
        | OnKeyPress of (KeyboardEvent -> unit)
        | OnKeyUp of (KeyboardEvent -> unit)
        | OnFocus of (FocusEvent -> unit)
        | OnBlur of (FocusEvent -> unit)
        | OnChange of (FormEvent -> unit)
        | OnInput of (FormEvent -> unit)
        | OnSubmit of (FormEvent -> unit)
        | OnClick of (MouseEvent -> unit)
        | OnDoubleClick of (MouseEvent -> unit)
        | OnDrag of (DragEvent -> unit)
        | OnDragEnd of (DragEvent -> unit)
        | OnDragEnter of (DragEvent -> unit)
        | OnDragExit of (DragEvent -> unit)
        | OnDragLeave of (DragEvent -> unit)
        | OnDragOver of (DragEvent -> unit)
        | OnDragStart of (DragEvent -> unit)
        | OnDrop of (DragEvent -> unit)
        | OnMouseDown of (MouseEvent -> unit)
        | OnMouseEnter of (MouseEvent -> unit)
        | OnMouseLeave of (MouseEvent -> unit)
        | OnMouseMove of (MouseEvent -> unit)
        | OnMouseOut of (MouseEvent -> unit)
        | OnMouseOver of (MouseEvent -> unit)
        | OnMouseUp of (MouseEvent -> unit)
        | OnTouchCancel of (TouchEvent -> unit)
        | OnTouchEnd of (TouchEvent -> unit)
        | OnTouchMove of (TouchEvent -> unit)
        | OnTouchStart of (TouchEvent -> unit)
        | OnScroll of (UIEvent -> unit)
        | OnWheel of (WheelEvent -> unit)
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

    let private attrToTuple a =
        match a with
        | OnCopy v -> "onCopy" ==> v
        | OnCut v -> "onCut" ==> v
        | OnPaste v -> "onPaste" ==> v
        | OnKeyDown v -> "onKeyDown" ==> v
        | OnKeyPress v -> "onKeyPress" ==> v
        | OnKeyUp v -> "onKeyUp" ==> v
        | OnFocus v -> "onFocus" ==> v
        | OnBlur v -> "onBlur" ==> v
        | OnChange v -> "onChange" ==> v
        | OnInput v -> "onInput" ==> v
        | OnSubmit v -> "onSubmit" ==> v
        | OnClick v -> "onClick" ==> v
        | OnDoubleClick v -> "onDoubleClick" ==> v
        | OnDrag v -> "onDrag" ==> v
        | OnDragEnd v -> "onDragEnd" ==> v
        | OnDragEnter v -> "onDragEnter" ==> v
        | OnDragExit v -> "onDragExit" ==> v
        | OnDragLeave v -> "onDragLeave" ==> v
        | OnDragOver v -> "onDragOver" ==> v
        | OnDragStart v -> "onDragStart" ==> v
        | OnDrop v -> "onDrop" ==> v
        | OnMouseDown v -> "onMouseDown" ==> v
        | OnMouseEnter v -> "onMouseEnter" ==> v
        | OnMouseLeave v -> "onMouseLeave" ==> v
        | OnMouseMove v -> "onMouseMove" ==> v
        | OnMouseOut v -> "onMouseOut" ==> v
        | OnMouseOver v -> "onMouseOver" ==> v
        | OnMouseUp v -> "onMouseUp" ==> v
        | OnTouchCancel v -> "onTouchCancel" ==> v
        | OnTouchEnd v -> "onTouchEnd" ==> v
        | OnTouchMove v -> "onTouchMove" ==> v
        | OnTouchStart v -> "onTouchStart" ==> v
        | OnScroll v -> "onScroll" ==> v
        | OnWheel v -> "onWheel" ==> v
        | Ref v -> "ref" ==> v
        | Accept v -> "accept" ==> v
        | AcceptCharset v -> "acceptCharset" ==> v
        | AccessKey v -> "accessKey" ==> v
        | Action v -> "action" ==> v
        | AllowFullScreen v -> "allowFullScreen" ==> v
        | AllowTransparency v -> "allowTransparency" ==> v
        | Alt v -> "alt" ==> v
        | Async v -> "async" ==> v
        | AutoComplete v -> "autoComplete" ==> v
        | AutoPlay v -> "autoPlay" ==> v
        | CellPadding v -> "cellPadding" ==> v
        | CellSpacing v -> "cellSpacing" ==> v
        | CharSet v -> "charSet" ==> v
        | Checked v -> "checked" ==> v
        | ClassId v -> "classId" ==> v
        | ClassName v -> "className" ==> v
        | Cols v -> "cols" ==> v
        | ColSpan v -> "colSpan" ==> v
        | Content v -> "content" ==> v
        | ContentEditable v -> "contentEditable" ==> v
        | ContextMenu v -> "contextMenu" ==> v
        | Controls v -> "controls" ==> v
        | Coords v -> "coords" ==> v
        | CrossOrigin v -> "crossOrigin" ==> v
        | Data v -> "data" ==> v
        | DateTime v -> "dateTime" ==> v
        | Defer v -> "defer" ==> v
        | Dir v -> "dir" ==> v
        | Disabled v -> "disabled" ==> v
        | Download v -> "download" ==> v
        | Draggable v -> "draggable" ==> v
        | EncType v -> "encType" ==> v
        | Form v -> "form" ==> v
        | FormNoValidate v -> "formNoValidate" ==> v
        | FrameBorder v -> "frameBorder" ==> v
        | Height v -> "height" ==> v
        | Hidden v -> "hidden" ==> v
        | Href v -> "href" ==> v
        | HrefLang v -> "hrefLang" ==> v
        | HtmlFor v -> "htmlFor" ==> v
        | HttpEquiv v -> "httpEquiv" ==> v
        | Icon v -> "icon" ==> v
        | Id v -> "id" ==> v
        | Label v -> "label" ==> v
        | Lang v -> "lang" ==> v
        | List v -> "list" ==> v
        | Loop v -> "loop" ==> v
        | Manifest v -> "manifest" ==> v
        | Max v -> "max" ==> v
        | MaxLength v -> "maxLength" ==> v
        | Media v -> "media" ==> v
        | MediaGroup v -> "mediaGroup" ==> v
        | Method v -> "method" ==> v
        | Min v -> "min" ==> v
        | Multiple v -> "multiple" ==> v
        | Muted v -> "muted" ==> v
        | Name v -> "name" ==> v
        | NoValidate v -> "noValidate" ==> v
        | Open v -> "open" ==> v
        | Pattern v -> "pattern" ==> v
        | Placeholder v -> "placeholder" ==> v
        | Poster v -> "poster" ==> v
        | Preload v -> "preload" ==> v
        | RadioGroup v -> "radioGroup" ==> v
        | ReadOnly v -> "readOnly" ==> v
        | Rel v -> "rel" ==> v
        | Required v -> "required" ==> v
        | Role v -> "role" ==> v
        | Rows v -> "rows" ==> v
        | RowSpan v -> "rowSpan" ==> v
        | Sandbox v -> "sandbox" ==> v
        | Scope v -> "scope" ==> v
        | ScrollLeft v -> "scrollLeft" ==> v
        | Scrolling v -> "scrolling" ==> v
        | ScrollTop v -> "scrollTop" ==> v
        | Seamless v -> "seamless" ==> v
        | Selected v -> "selected" ==> v
        | Shape v -> "shape" ==> v
        | Size v -> "size" ==> v
        | Sizes v -> "sizes" ==> v
        | Span v -> "span" ==> v
        | SpellCheck v -> "spellCheck" ==> v
        | Src v -> "src" ==> v
        | SrcDoc v -> "srcDoc" ==> v
        | SrcSet v -> "srcSet" ==> v
        | Start v -> "start" ==> v
        | Step v -> "step" ==> v
        | Style v -> "style" ==> v
        | TabIndex v -> "tabIndex" ==> v
        | Target v -> "target" ==> v
        | Title v -> "title" ==> v
        | Type v -> "type" ==> v
        | UseMap v -> "useMap" ==> v
        | Value v -> "value" ==> v
        | Width v -> "width" ==> v
        | Wmode v -> "wmode" ==> v
        | AutoCapitalize v -> "autoCapitalize" ==> v
        | AutoFocus v -> "autoFocus" ==> v
        | Property v -> "property" ==> v
        | ItemProp v -> "itemProp" ==> v
        | ItemScope v -> "itemScope" ==> v
        | ItemType v -> "itemType" ==> v

    let attrsToObj lst =
        lst |> Array.map (attrToTuple) |> obj


    [<AbstractClass; Sealed>]
    type DOM () =
        static member a (p, [<ParamArray>] c) = Globals.createElement ("a", (attrsToObj p), c )
        static member abbr (p, [<ParamArray>] c) = Globals.createElement ("abbr", (attrsToObj p), c )
        static member address (p, [<ParamArray>] c) = Globals.createElement ("address", (attrsToObj p), c )
        static member area (p, [<ParamArray>] c) = Globals.createElement ("area", (attrsToObj p), c )
        static member article (p, [<ParamArray>] c) = Globals.createElement ("article", (attrsToObj p), c )
        static member aside (p, [<ParamArray>] c) = Globals.createElement ("aside", (attrsToObj p), c )
        static member audio (p, [<ParamArray>] c) = Globals.createElement ("audio", (attrsToObj p), c )
        static member b (p, [<ParamArray>] c) = Globals.createElement ("b", (attrsToObj p), c )
        static member base' (p, [<ParamArray>] c) = Globals.createElement ("base", (attrsToObj p), c )
        static member bdi (p, [<ParamArray>] c) = Globals.createElement ("bdi", (attrsToObj p), c )
        static member bdo (p, [<ParamArray>] c) = Globals.createElement ("bdo", (attrsToObj p), c )
        static member blockquote (p, [<ParamArray>] c) = Globals.createElement ("blockquote", (attrsToObj p), c )
        static member body (p, [<ParamArray>] c) = Globals.createElement ("body", (attrsToObj p), c )
        static member br (p, [<ParamArray>] c) = Globals.createElement ("br", (attrsToObj p), c )
        static member button (p, [<ParamArray>] c) = Globals.createElement ("button", (attrsToObj p), c )
        static member canvas (p, [<ParamArray>] c) = Globals.createElement ("canvas", (attrsToObj p), c )
        static member caption (p, [<ParamArray>] c) = Globals.createElement ("caption", (attrsToObj p), c )
        static member cite (p, [<ParamArray>] c) = Globals.createElement ("cite", (attrsToObj p), c )
        static member code (p, [<ParamArray>] c) = Globals.createElement ("code", (attrsToObj p), c )
        static member col (p, [<ParamArray>] c) = Globals.createElement ("col", (attrsToObj p), c )
        static member colgroup (p, [<ParamArray>] c) = Globals.createElement ("colgroup", (attrsToObj p), c )
        static member datalist (p, [<ParamArray>] c) = Globals.createElement ("datalist", (attrsToObj p), c )
        static member dd (p, [<ParamArray>] c) = Globals.createElement ("dd", (attrsToObj p), c )
        static member del (p, [<ParamArray>] c) = Globals.createElement ("del", (attrsToObj p), c )
        static member details (p, [<ParamArray>] c) = Globals.createElement ("details", (attrsToObj p), c )
        static member dfn (p, [<ParamArray>] c) = Globals.createElement ("dfn", (attrsToObj p), c )
        static member dialog (p, [<ParamArray>] c) = Globals.createElement ("dialog", (attrsToObj p), c )
        static member div (p, [<ParamArray>] c) = Globals.createElement ("div", (attrsToObj p), c )
        static member dl (p, [<ParamArray>] c) = Globals.createElement ("dl", (attrsToObj p), c )
        static member dt (p, [<ParamArray>] c) = Globals.createElement ("dt", (attrsToObj p), c )
        static member em (p, [<ParamArray>] c) = Globals.createElement ("em", (attrsToObj p), c )
        static member embed (p, [<ParamArray>] c) = Globals.createElement ("embed", (attrsToObj p), c )
        static member fieldset (p, [<ParamArray>] c) = Globals.createElement ("fieldset", (attrsToObj p), c )
        static member figcaption (p, [<ParamArray>] c) = Globals.createElement ("figcaption", (attrsToObj p), c )
        static member figure (p, [<ParamArray>] c) = Globals.createElement ("figure", (attrsToObj p), c )
        static member footer (p, [<ParamArray>] c) = Globals.createElement ("footer", (attrsToObj p), c )
        static member form (p, [<ParamArray>] c) = Globals.createElement ("form", (attrsToObj p), c )
        static member h1 (p, [<ParamArray>] c) = Globals.createElement ("h1", (attrsToObj p), c )
        static member h2 (p, [<ParamArray>] c) = Globals.createElement ("h2", (attrsToObj p), c )
        static member h3 (p, [<ParamArray>] c) = Globals.createElement ("h3", (attrsToObj p), c )
        static member h4 (p, [<ParamArray>] c) = Globals.createElement ("h4", (attrsToObj p), c )
        static member h5 (p, [<ParamArray>] c) = Globals.createElement ("h5", (attrsToObj p), c )
        static member h6 (p, [<ParamArray>] c) = Globals.createElement ("h6", (attrsToObj p), c )
        static member head (p, [<ParamArray>] c) = Globals.createElement ("head", (attrsToObj p), c )
        static member header (p, [<ParamArray>] c) = Globals.createElement ("header", (attrsToObj p), c )
        static member hr (p, [<ParamArray>] c) = Globals.createElement ("hr", (attrsToObj p), c )
        static member html (p, [<ParamArray>] c) = Globals.createElement ("html", (attrsToObj p), c )
        static member i (p, [<ParamArray>] c) = Globals.createElement ("i", (attrsToObj p), c )
        static member iframe (p, [<ParamArray>] c) = Globals.createElement ("iframe", (attrsToObj p), c )
        static member img (p, [<ParamArray>] c) = Globals.createElement ("img", (attrsToObj p), c )
        static member input (p, [<ParamArray>] c) = Globals.createElement ("input", (attrsToObj p), c )
        static member ins (p, [<ParamArray>] c) = Globals.createElement ("ins", (attrsToObj p), c )
        static member kbd (p, [<ParamArray>] c) = Globals.createElement ("kbd", (attrsToObj p), c )
        static member keygen (p, [<ParamArray>] c) = Globals.createElement ("keygen", (attrsToObj p), c )
        static member label (p, [<ParamArray>] c) = Globals.createElement ("label", (attrsToObj p), c )
        static member legend (p, [<ParamArray>] c) = Globals.createElement ("legend", (attrsToObj p), c )
        static member li (p, [<ParamArray>] c) = Globals.createElement ("li", (attrsToObj p), c )
        static member link (p, [<ParamArray>] c) = Globals.createElement ("link", (attrsToObj p), c )
        static member main (p, [<ParamArray>] c) = Globals.createElement ("main", (attrsToObj p), c )
        static member map (p, [<ParamArray>] c) = Globals.createElement ("map", (attrsToObj p), c )
        static member mark (p, [<ParamArray>] c) = Globals.createElement ("mark", (attrsToObj p), c )
        static member menu (p, [<ParamArray>] c) = Globals.createElement ("menu", (attrsToObj p), c )
        static member menuitem (p, [<ParamArray>] c) = Globals.createElement ("menuitem", (attrsToObj p), c )
        static member meta (p, [<ParamArray>] c) = Globals.createElement ("meta", (attrsToObj p), c )
        static member meter (p, [<ParamArray>] c) = Globals.createElement ("meter", (attrsToObj p), c )
        static member nav (p, [<ParamArray>] c) = Globals.createElement ("nav", (attrsToObj p), c )
        static member noscript (p, [<ParamArray>] c) = Globals.createElement ("noscript", (attrsToObj p), c )
        static member object' (p, [<ParamArray>] c) = Globals.createElement ("object", (attrsToObj p), c )
        static member ol (p, [<ParamArray>] c) = Globals.createElement ("ol", (attrsToObj p), c )
        static member optgroup (p, [<ParamArray>] c) = Globals.createElement ("optgroup", (attrsToObj p), c )
        static member option (p, [<ParamArray>] c) = Globals.createElement ("option", (attrsToObj p), c )
        static member output (p, [<ParamArray>] c) = Globals.createElement ("output", (attrsToObj p), c )
        static member p (p', [<ParamArray>] c) = Globals.createElement ("p", p', c )
        static member param (p, [<ParamArray>] c) = Globals.createElement ("param", (attrsToObj p), c )
        static member pre (p, [<ParamArray>] c) = Globals.createElement ("pre", (attrsToObj p), c )
        static member progress (p, [<ParamArray>] c) = Globals.createElement ("progress", (attrsToObj p), c )
        static member q (p, [<ParamArray>] c) = Globals.createElement ("q", (attrsToObj p), c )
        static member rp (p, [<ParamArray>] c) = Globals.createElement ("rp", (attrsToObj p), c )
        static member rt (p, [<ParamArray>] c) = Globals.createElement ("rt", (attrsToObj p), c )
        static member ruby (p, [<ParamArray>] c) = Globals.createElement ("ruby", (attrsToObj p), c )
        static member s (p, [<ParamArray>] c) = Globals.createElement ("s", (attrsToObj p), c )
        static member samp (p, [<ParamArray>] c) = Globals.createElement ("samp", (attrsToObj p), c )
        static member script (p, [<ParamArray>] c) = Globals.createElement ("script", (attrsToObj p), c )
        static member section (p, [<ParamArray>] c) = Globals.createElement ("section", (attrsToObj p), c )
        static member select (p, [<ParamArray>] c) = Globals.createElement ("select", (attrsToObj p), c )
        static member small (p, [<ParamArray>] c) = Globals.createElement ("small", (attrsToObj p), c )
        static member source (p, [<ParamArray>] c) = Globals.createElement ("source", (attrsToObj p), c )
        static member span (p, [<ParamArray>] c) = Globals.createElement ("span", (attrsToObj p), c )
        static member strong (p, [<ParamArray>] c) = Globals.createElement ("strong", (attrsToObj p), c )
        static member style (p, [<ParamArray>] c) = Globals.createElement ("style", (attrsToObj p), c )
        static member sub (p, [<ParamArray>] c) = Globals.createElement ("sub", (attrsToObj p), c )
        static member summary (p, [<ParamArray>] c) = Globals.createElement ("summary", (attrsToObj p), c )
        static member sup (p, [<ParamArray>] c) = Globals.createElement ("sup", (attrsToObj p), c )
        static member table (p, [<ParamArray>] c) = Globals.createElement ("table", (attrsToObj p), c )
        static member tbody (p, [<ParamArray>] c) = Globals.createElement ("tbody", (attrsToObj p), c )
        static member td (p, [<ParamArray>] c) = Globals.createElement ("td", (attrsToObj p), c )
        static member textarea (p, [<ParamArray>] c) = Globals.createElement ("textarea", (attrsToObj p), c )
        static member tfoot (p, [<ParamArray>] c) = Globals.createElement ("tfoot", (attrsToObj p), c )
        static member th (p, [<ParamArray>] c) = Globals.createElement ("th", (attrsToObj p), c )
        static member thead (p, [<ParamArray>] c) = Globals.createElement ("thead", (attrsToObj p), c )
        static member time (p, [<ParamArray>] c) = Globals.createElement ("time", (attrsToObj p), c )
        static member title (p, [<ParamArray>] c) = Globals.createElement ("title", (attrsToObj p), c )
        static member tr (p, [<ParamArray>] c) = Globals.createElement ("tr", (attrsToObj p), c )
        static member track (p, [<ParamArray>] c) = Globals.createElement ("track", (attrsToObj p), c )
        static member u (p, [<ParamArray>] c) = Globals.createElement ("u", (attrsToObj p), c )
        static member ul (p, [<ParamArray>] c) = Globals.createElement ("ul", (attrsToObj p), c )
        static member var (p, [<ParamArray>] c) = Globals.createElement ("var", (attrsToObj p), c )
        static member video (p, [<ParamArray>] c) = Globals.createElement ("video", (attrsToObj p), c )
        static member wbr (p, [<ParamArray>] c) = Globals.createElement ("wbr", (attrsToObj p), c )
