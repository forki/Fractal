namespace Fractal

open System
open FunScript
open FunScript.TypeScript
open FunScript.TypeScript.React

[<ReflectedDefinition>]
[<AutoOpen>]
module MaterialDOM =

    type AppBarProps =
        | Ref of string
        | ClassName of string
        | IconClassNameLeft of string
        | IconClassNameRight of string
        | IconElementLeft of Element
        | IconElementRight of Element
        | IconStyleRight of string
        | Style of obj //TODO CSS DSL
        | ShowMenuIconButton of bool
        | Title of string
        | ZDepth of float
        | OnLeftIconButtonTouchTap of (SyntheticEvent -> unit)
        | OnRightIconButtonTouchTap of (SyntheticEvent -> unit)

    type AvatarProps =
        | Ref of string
        | ClassName of string
        | Icon of Element
        | BackgroundColor of string
        | Color of string
        | Size of float
        | Src of string
        | Style of obj //TODO CSS DSL

    type FlatButtonProps =
        | Ref of string
        | ClassName of string
        | ContainerElement of string
        | Disabled of bool
        | HoverColor of string
        | Label of string
        | Children of DOMElement<obj>
        | LabelStyle of obj //TODO CSS DSL
        | LinkButon of bool
        | Primary of bool
        | Secondary of bool
        | RippleColor of string
        | Style of obj //TODO CSS DSL
        | OnMouseDown of (SyntheticEvent -> unit)

    type RaisedButtonProps =
        | Ref of string
        | ClassName of string
        | ContainerElement of string
        | Disabled of bool
        | FullWidth of bool
        | Label of string
        | Children of DOMElement<obj>
        | LabelStyle of obj //TODO CSS DSL
        | LinkButon of bool
        | Primary of bool
        | Secondary of bool
        | BackgroundColor of string
        | LabelColor of string
        | DisabledBackgroundColor of string
        | DisabledLabelColor of string
        | Style of obj //TODO CSS DSL
        | OnMouseDown of (SyntheticEvent -> unit)

    type FloatingActionButtonProps =
        | Ref of string
        | ClassName of string
        | ContainerElement of string
        | Disabled of bool
        | IconClassName of string
        | IconStyle of obj //TODO CSS DSL
        | LinkButon of bool
        | Primary of bool
        | Secondary of bool
        | Style of obj //TODO CSS DSL
        | OnMouseDown of (SyntheticEvent -> unit)

    type DatePickerProps =
        | Ref of string
        | ClassName of string
        | AutoOK of bool
        | DefaultDate of DateTime
        | FormatDate of (DateTime -> string)
        | HideToolbarYearChange of bool
        | MaxDate of DateTime
        | MinDate of DateTime
        | Mode of string
        | ShouldDisableDate of (DateTime -> bool)
        | ShowYearSelector of bool
        | Style of obj //TODO CSS DSL
        | TextFieldStyle of obj //TODO CSS DSL

    type DialogProps =
        | Ref of string
        | ClassName of string
        | Actions of DOMElement<obj> []
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
        | Ref of string
        | ClassName of string
        | AutoWidth of bool
        | MenuItems of obj []
        | MenuItemStyle of obj [] // TODO CSS DSL
        | SelectedIndex of float
        | Style of obj // TODO CSS DSL

    type IconProps =
        | Ref of string
        | ClassName of string
        | Color of string
        | HoverColor of string

    type LeftNavProps =
        | Ref of string
        | ClassName of string
        | Docked of bool
        | Header of Element
        | MenuItems of obj []
        | OpenRight of bool
        | SelectedIndex of float
        | Style of obj //TODO CSS DSL
        | OnChange of (SyntheticEvent -> float -> obj -> unit)
        | OnNavOpen of (unit -> unit)
        | OnNavClose of (unit -> unit)

    type ListProps =
        | Ref of string
        | ClassName of string
        | InsetSubheader of bool
        | Subheader of string
        | ShubheaderStyle of obj //TODO CSS DSL

    type ListItemProps =
        | Ref of string
        | ClassName of string
        | AutoGenerateNestedIndicator of bool
        | Disabled of bool
        | InsetChildreb of bool
        | LeftAvatar of DOMElement<obj>
        | LeftCheckbox of DOMElement<obj>
        | LeftIcon of DOMElement<obj>
        | NestedLevel of float
        | Open of bool
        | PrimaryText of string
        | RightAvatar of DOMElement<obj>
        | RightIcon of DOMElement<obj>
        | RightIconButton of DOMElement<obj>
        | RightToggle of DOMElement<obj>
        | SecondaryText of string
        | SecondaryTextLines of float
        | OnKeyboardFocus of (SyntheticEvent -> bool -> unit)
        | OnMouseOut of (SyntaxError -> unit)
        | OnTouchStart of (SyntaxError -> unit)

    type MenuProps =
        | Ref of string
        | ClassName of string
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
        | Ref of string
        | ClassName of string
        | Checked of bool
        | Desktop of bool
        | Disabled of bool
        | InnerDivStyle of obj //TODO CSS DSL
        | InsetChildren of bool
        | LeftIcon of DOMElement<obj>
        | PrimaryText of string
        | RightIcon of DOMElement<obj>
        | SecondaryText of string
        | Value of string
        | OnEscKeyDown of (SyntheticEvent -> unit)
        | OnItemTouchTap of (SyntheticEvent -> obj -> unit)
        | OnChange of (SyntheticEvent -> obj -> unit)

    type PaperProps =
        | Ref of string
        | ClassName of string
        | Circle of bool
        | Rounded of bool
        | Style of obj //TODO CSS DSL
        | ZDepth of float
        | TransitionEnabled of bool

    type ProgressProps =
        | Ref of string
        | ClassName of string
        | Mode of string
        | Value of float
        | Max of float
        | Min of float
        | Size of float

    type SliderProps =
        | Ref of string
        | ClassName of string
        | Name of string
        | DefaultValue of float
        | Description of string
        | Disabled of bool
        | Error of string
        | Max of float
        | Min of float
        | Required of bool
        | Step of float
        | Style of obj // TODO CSS DSL
        | Value of float
        | OnBlur of (SyntheticEvent -> unit)
        | OnChange of (SyntheticEvent -> float -> unit)
        | OnDragStart of (SyntheticEvent -> obj -> unit)
        | OnDragStop of (SyntheticEvent -> obj -> unit)
        | OnFocus of (SyntheticEvent -> unit)

    type CheckboxProps =
        | Ref of string
        | ClassName of string
        | CheckedIcon of DOMElement<obj>
        | DefaultChecked of bool
        | IconStyle of obj //TODO CSS DSL
        | Label of string
        | LabelStyle of obj //TODO CSS DSL
        | LabelPosition of string
        | Style of obj //TODO CSS DSL
        | UnCheckedIcon of DOMElement<obj>
        | OnCheck of (SyntheticEvent -> unit)
        | Value of obj

    type SnackbarProps =
        | Ref of string
        | ClassName of string
        | Action of string
        | AutoHideDuration of float
        | Mesage of string
        | OpenOnMount of bool
        | Style of obj //TODO CSS DSL
        | OnActionTouchTap of (SyntheticEvent -> unit)

    type TabsProps =
        | Ref of string
        | ClassName of string
        | InitialSelectedIndex of float
        | InkBarStyle of obj //TOOD CSS DSL
        | Style of obj //TODO CSS DSL
        | TabItemContainerStyle of obj //TOOD CSS DSL
        | ContentContainerStyle of obj //TOD CSS DSL
        | TabWidth of float
        | OnChange of (float -> obj -> unit)

    type TabProps =
        | Ref of string
        | ClassName of string
        | Label of string
        | Route of string
        | OnActive of (obj -> unit)

    //TODO TABLES PROPS

    type TextFieldProps =
        | Ref of string
        | ClassName of string
        | ErrorStyle of obj //TODO CSS DSL
        | ErrorText of string
        | FloatingLabelText of string
        | FullWidth of bool
        | HintText of string
        | DefaultValue of string
        | MultiLine of bool
        | OnEnterKeyDown of (unit -> unit)
        | Style of obj //TODO CSS DSL
        | Type of string
        | OnBlur of (SyntheticEvent -> unit)
        | OnChange of (SyntheticEvent -> unit)
        | OnFocus of (SyntheticEvent -> unit)

    type TimePickerProps =
        | Ref of string
        | ClassName of string
        | DefaultTime of DateTime
        | Format of string

    [<AbstractClass; Sealed>]
    type Material()=
        static member AppBar ((p : AppBarProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.AppBar, (attrsToObj p), c )
        static member Avatar ((p : AvatarProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Avatar, (attrsToObj p), c )
        static member FlatButton ((p : FlatButtonProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.FlatButton, (attrsToObj p), c )
        static member RaisedButton ((p : RaisedButtonProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.RaisedButton, (attrsToObj p), c )
        static member FloatingActionButton ((p : FloatingActionButtonProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.FloatingActionButton, (attrsToObj p), c )
        static member DatePicker ((p : DatePickerProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.DatePicker, (attrsToObj p), c )
        static member Dialog ((p : DialogProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Dialog, (attrsToObj p), c )
        static member Dropdown ((p : DropdownProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Dropdown, (attrsToObj p), c )
        static member Icon ((p : IconProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Icon, (attrsToObj p), c )
        static member LeftNav ((p : LeftNavProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.LeftNav, (attrsToObj p), c )
        static member List ((p : ListProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.List, (attrsToObj p), c )
        static member ListItem ((p : ListItemProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.ListItem, (attrsToObj p), c )
        static member Menu ((p : MenuProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Menu, (attrsToObj p), c )
        static member MenuItem ((p : MenuItemProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.MenuItem, (attrsToObj p), c )
        static member Paper ((p : PaperProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Paper, (attrsToObj p), c )
        static member Progress ((p : ProgressProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Progress, (attrsToObj p), c )
        static member Slider ((p : SliderProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Slider, (attrsToObj p), c )
        static member Checkbox ((p : CheckboxProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Checkbox, (attrsToObj p), c )
        static member Snackbar ((p : SnackbarProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Snackbar, (attrsToObj p), c )
        static member Tabs ((p : TabsProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Tabs, (attrsToObj p), c )
        static member Tab ((p : TabProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.Tab, (attrsToObj p), c )
        static member TextField ((p : TextFieldProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.TextField, (attrsToObj p), c )
        static member TimePicker ((p : TimePickerProps[]), [<ParamArray>] c) = Globals.createElement (Globals.mui.TimePicker, (attrsToObj p), c )
        static member Nothing = null |> unbox<ReactElement<obj>>
