namespace Fractal

open System
open FunScript
open FunScript.TypeScript
open FunScript.TypeScript.React

[<ReflectedDefinition>]
[<AutoOpen>]
module MaterialDOM =

    type AppBarProps =
        | Attr of DOM.Attr
        | IconClassNameLeft of string
        | IconClassNameRight of string
        | IconElementLeft of Element
        | IconElementRight of Element
        | IconStyleRight of string
        | ShowMenuIconButton of bool
        | Title of string
        | ZDepth of float
        | OnLeftIconButtonTouchTap of (Component.SyntheticEvent -> unit)
        | OnRightIconButtonTouchTap of (Component.SyntheticEvent -> unit)

    type AvatarProps =
        | Attr of DOM.Attr
        | Icon of Element
        | BackgroundColor of string
        | Color of string
        | Size of float
        | Src of string

    type FlatButtonProps =
        | Attr of DOM.Attr
        | ContainerElement of string
        | Disabled of bool
        | HoverColor of string
        | Label of string
        | Children of Component.DOMElement<obj>
        | LabelStyle of obj //TODO CSS DSL
        | LinkButton of bool
        | Primary of bool
        | Secondary of bool
        | RippleColor of string

    type RaisedButtonProps =
        | Attr of DOM.Attr
        | ContainerElement of string
        | Disabled of bool
        | FullWidth of bool
        | Label of string
        | Children of Component.DOMElement<obj>
        | LabelStyle of obj //TODO CSS DSL
        | LinkButton of bool
        | Primary of bool
        | Secondary of bool
        | BackgroundColor of string
        | LabelColor of string
        | DisabledBackgroundColor of string
        | DisabledLabelColor of string

    type FloatingActionButtonProps =
        | Attr of DOM.Attr
        | ContainerElement of string
        | Disabled of bool
        | IconClassName of string
        | IconStyle of obj //TODO CSS DSL
        | LinkButton of bool
        | Primary of bool
        | Secondary of bool

    type DatePickerProps =
        | Attr of DOM.Attr
        | AutoOK of bool
        | DefaultDate of DateTime
        | FormatDate of (DateTime -> string)
        | HideToolbarYearChange of bool
        | MaxDate of DateTime
        | MinDate of DateTime
        | Mode of string
        | ShouldDisableDate of (DateTime -> bool)
        | ShowYearSelector of bool
        | TextFieldStyle of obj //TODO CSS DSL

    type DialogProps =
        | Attr of DOM.Attr
        | Actions of Component.DOMElement<obj> []
        | ActionFocus of string
        | ContentClassName of string
        | ContentInnerStyle of obj //TODO CSS DSL
        | ContentStyle of obj //TODO CSS DSL
        | Modal of bool
        | OpenImmediately of bool
        | Title of string
        | AutoDetectWindowHeight of bool
        | AutoScrollBodyContent of bool
        | OnDismiss of (unit -> unit)
        | OnShow of (unit -> unit)

    type DropdownProps =
        | Attr of DOM.Attr
        | AutoWidth of bool
        | MenuItems of obj []
        | MenuItemStyle of obj [] // TODO CSS DSL
        | SelectedIndex of float

    type IconProps =
        | Attr of DOM.Attr
        | Color of string
        | HoverColor of string

    type LeftNavProps =
        | Attr of DOM.Attr
        | Docked of bool
        | Header of Element
        | MenuItems of obj []
        | OpenRight of bool
        | SelectedIndex of float
        | OnChange of (Component.SyntheticEvent -> float -> obj -> unit)
        | OnNavOpen of (unit -> unit)
        | OnNavClose of (unit -> unit)

    type ListProps =
        | Attr of DOM.Attr
        | InsetSubheader of bool
        | Subheader of string
        | ShubheaderStyle of obj //TODO CSS DSL

    type ListItemProps =
        | Attr of DOM.Attr
        | AutoGenerateNestedIndicator of bool
        | Disabled of bool
        | InsetChildreb of bool
        | LeftAvatar of Component.DOMElement<obj>
        | LeftCheckbox of Component.DOMElement<obj>
        | LeftIcon of Component.DOMElement<obj>
        | NestedLevel of float
        | Open of bool
        | PrimaryText of string
        | RightAvatar of Component.DOMElement<obj>
        | RightIcon of Component.DOMElement<obj>
        | RightIconButton of Component.DOMElement<obj>
        | RightToggle of Component.DOMElement<obj>
        | SecondaryText of string
        | SecondaryTextLines of float
        | OnKeyboardFocus of (Component.SyntheticEvent -> bool -> unit)
        | OnTouchStart of (Component.SyntheticEvent -> unit)

    type MenuProps =
        | Attr of DOM.Attr
        | AutoWidth of bool
        | Desktop of bool
        | ListStyle of obj //TODO CSS DSL
        | MaxHeight of float
        | Multilpe of bool
        | OpenDirection of string
        | Value of string
        | Width of float
        | ZDepth of float

    type MenuItemProps =
        | Attr of DOM.Attr
        | Checked of bool
        | Desktop of bool
        | Disabled of bool
        | InnerDivStyle of obj //TODO CSS DSL
        | InsetChildren of bool
        | LeftIcon of Component.DOMElement<obj>
        | PrimaryText of string
        | RightIcon of Component.DOMElement<obj>
        | SecondaryText of string
        | Value of string
        | OnEscKeyDown of (Component.SyntheticEvent -> unit)
        | OnItemTouchTap of (Component.SyntheticEvent -> obj -> unit)
        | OnChange of (Component.SyntheticEvent -> obj -> unit)

    type PaperProps =
        | Attr of DOM.Attr
        | Circle of bool
        | Rounded of bool
        | ZDepth of float
        | TransitionEnabled of bool

    type ProgressProps =
        | Attr of DOM.Attr
        | Mode of string
        | Value of float
        | Max of float
        | Min of float
        | Size of float

    type SliderProps =
        | Attr of DOM.Attr
        | Name of string
        | DefaultValue of float
        | Description of string
        | Disabled of bool
        | Error of string
        | Max of float
        | Min of float
        | Required of bool
        | Step of float
        | Value of float
        | OnBlur of (Component.SyntheticEvent -> unit)
        | OnChange of (Component.SyntheticEvent -> float -> unit)
        | OnDragStart of (Component.SyntheticEvent -> obj -> unit)
        | OnDragStop of (Component.SyntheticEvent -> obj -> unit)
        | OnFocus of (Component.SyntheticEvent -> unit)

    type CheckboxProps =
        | Attr of DOM.Attr
        | CheckedIcon of Component.DOMElement<obj>
        | DefaultChecked of bool
        | IconStyle of obj //TODO CSS DSL
        | Label of string
        | LabelStyle of obj //TODO CSS DSL
        | LabelPosition of string
        | UnCheckedIcon of Component.DOMElement<obj>
        | OnCheck of (Component.SyntheticEvent -> unit)
        | Value of obj

    type SnackbarProps =
        | Attr of DOM.Attr
        | Action of string
        | AutoHideDuration of float
        | Mesage of string
        | OpenOnMount of bool
        | OnActionTouchTap of (Component.SyntheticEvent -> unit)

    type TabsProps =
        | Attr of DOM.Attr
        | InitialSelectedIndex of float
        | InkBarStyle of obj //TOOD CSS DSL
        | TabItemContainerStyle of obj //TOOD CSS DSL
        | ContentContainerStyle of obj //TOD CSS DSL
        | TabWidth of float
        | OnChange of (float -> obj -> unit)

    type TabProps =
        | Attr of DOM.Attr
        | Label of string
        | Route of string
        | OnActive of (obj -> unit)

    //TODO TABLES PROPS

    type TextFieldProps =
        | Attr of DOM.Attr
        | ErrorStyle of obj //TODO CSS DSL
        | ErrorText of string
        | FloatingLabelText of string
        | FullWidth of bool
        | HintText of string
        | DefaultValue of string
        | MultiLine of bool
        | OnEnterKeyDown of (unit -> unit)
        | Type of string
        | OnBlur of (Component.SyntheticEvent -> unit)
        | OnChange of (Component.SyntheticEvent -> unit)
        | OnFocus of (Component.SyntheticEvent -> unit)

    type TimePickerProps =
        | Attr of DOM.Attr 
        | DefaultTime of DateTime
        | Format of string

    [<AbstractClass; Sealed>]
    type Material()=
        static member AppBar ((p : AppBarProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.AppBar, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Avatar ((p : AvatarProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Avatar, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member FlatButton ((p : FlatButtonProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.FlatButton, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member RaisedButton ((p : RaisedButtonProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.RaisedButton, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member FloatingActionButton ((p : FloatingActionButtonProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.FloatingActionButton, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member DatePicker ((p : DatePickerProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.DatePicker, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Dialog ((p : DialogProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Dialog, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Dropdown ((p : DropdownProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Dropdown, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Icon ((p : IconProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Icon, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member LeftNav ((p : LeftNavProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.LeftNav, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member List ((p : ListProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.List, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member ListItem ((p : ListItemProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.ListItem, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Menu ((p : MenuProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Menu, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member MenuItem ((p : MenuItemProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.MenuItem, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Paper ((p : PaperProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Paper, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Progress ((p : ProgressProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Progress, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Slider ((p : SliderProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Slider, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Checkbox ((p : CheckboxProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Checkbox, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Snackbar ((p : SnackbarProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Snackbar, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Tabs ((p : TabsProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Tabs, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Tab ((p : TabProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Tab, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member TextField ((p : TextFieldProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.TextField, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member TimePicker ((p : TimePickerProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.TimePicker, (attrsToObj p), c ) |> unbox<FractalElement<obj>>
        static member Nothing = null |> unbox<FractalElement<obj>>
