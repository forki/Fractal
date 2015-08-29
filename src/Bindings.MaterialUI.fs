namespace FunScript.TypeScript.Mui
type Mixins = interface end
type Utils = interface end
type Styles = interface end
type ThemeManager = interface end
type mui = interface end

namespace Fractal

open FunScript
open FunScript.TypeScript
open FunScript.TypeScript.React

[<AutoOpen>]
module Extensions =

    type Globals with
        [<FunScript.JSEmitInline("(window.mui)")>]
        static member mui with get() : FunScript.TypeScript.Mui.mui = failwith "never"


    type FunScript.TypeScript.Mui.ThemeManager with
        [<FunScript.JSEmitInline("({0}.getCurrentTheme())")>]
        member __.getCurrentTheme() : obj = failwith "never"

    type FunScript.TypeScript.Mui.Styles with

        [<FunScript.JSEmitInline("(new {0}.ThemeManager())")>]
        member __.ThemeManager() : FunScript.TypeScript.Mui.ThemeManager = failwith "never"


    type FunScript.TypeScript.Mui.Mixins with

        [<FunScript.JSEmitInline("({0}.Classable)")>]
        member __.Classable with get() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.ClickAwayable)")>]
        member __.ClickAwayable with get() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.WindowListenable)")>]
        member __.WindowListenable with get() : obj = failwith "never"


    type FunScript.TypeScript.Mui.Utils with

        [<FunScript.JSEmitInline("({0}.CssEvent)")>]
        member __.CssEvent with get() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.Dom)")>]
        member __.Dom with get() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.Events)")>]
        member __.Events with get() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.KeyCode)")>]
        member __.KeyCode with get() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.KeyLine)")>]
        member __.KeyLine with get() : obj = failwith "never"

    type FunScript.TypeScript.Mui.mui with

        [<FunScript.JSEmitInline("({0}.AppBar)")>]
        member __.AppBar with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.AppBar)")>]
        member __.Avatar with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.AppCanvas)")>]
        member __.AppCanvas with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Checkbox)")>]
        member __.Checkbox with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.DatePicker)")>]
        member __.DatePicker with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Dropdown)")>]
        member __.Dropdown with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Dialog)")>]
        member __.Dialog with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.DropDownIcon)")>]
        member __.DropDownIcon with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.DropDownMenu)")>]
        member __.DropDownMenu with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.EnhancedButton)")>]
        member __.EnhancedButton with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.FlatButton)")>]
        member __.FlatButton with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.FloatingActionButton)")>]
        member __.FloatingActionButton with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.IconButton)")>]
        member __.IconButton with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Icon)")>]
        member __.Icon with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Input)")>]
        member __.Input with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.LeftNav)")>]
        member __.LeftNav with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.List)")>]
        member __.List with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.ListItem)")>]
        member __.ListItem with get() : ComponentClass<obj>= failwith "never"

        [<FunScript.JSEmitInline("({0}.MenuItem)")>]
        member __.MenuItem with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Menu)")>]
        member __.Menu with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Mixins)")>]
        member __.Mixins with get() : FunScript.TypeScript.Mui.Mixins = failwith "never"
        [<FunScript.JSEmitInline("({0}.PaperButton)")>]
        member __.PaperButton with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Paper)")>]
        member __.Paper with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Progress)")>]
        member __.Progress with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Slider)")>]
        member __.Slider with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Snackbar)")>]
        member __.Snackbar with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Tabs)")>]
        member __.Tabs with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Tab)")>]
        member __.Tab with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TimePicker)")>]
        member __.TimePicker with get() : ComponentClass<obj>= failwith "never"

        [<FunScript.JSEmitInline("({0}.RadioButton)")>]
        member __.RadioButton with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.RaisedButton)")>]
        member __.RaisedButton with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Ripple)")>]
        member __.Ripple with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Table)")>]
        member __.Table with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TableBody)")>]
        member __.TableBody with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TableFooter)")>]
        member __.TableFooter with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TableHeader)")>]
        member __.TableHeader with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TableHeaderColumn)")>]
        member __.TableHeaderColumn with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TableRow)")>]
        member __.TableRow with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TableRowColumn)")>]
        member __.TableRowColumn with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Toggle)")>]
        member __.Toggle with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.TextField)")>]
        member __.TextField with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Toast)")>]
        member __.Toast with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Toolbar)")>]
        member __.Toolbar with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.ToolbarGroup)")>]
        member __.ToolbarGroup with get() : ComponentClass<obj>= failwith "never"
        [<FunScript.JSEmitInline("({0}.Utils)")>]
        member __.Utils with get() : FunScript.TypeScript.Mui.Utils = failwith "never"
        [<FunScript.JSEmitInline("({0}.Styles)")>]
        member __.Styles with get() : FunScript.TypeScript.Mui.Styles = failwith "never"

    type FunScript.TypeScript.React.ComponentSpec<'P, 'S> with

        [<FunScript.JSEmitInline("({0}.getChildContext())");>]
        member __.getChildContext() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.getChildContext = {1})"); >]
        member __.``getChildContext <-``(func : unit -> obj) : unit = failwith "never"

        [<FunScript.JSEmitInline("({0}.getChildContext = function(){return { muiTheme: ThemeManager.getCurrentTheme() }})");>]
        member internal __.setChildContext() : unit = failwith "never"
        [<FunScript.JSEmitInline("({0}.childContextTypes = { muiTheme: React.PropTypes.object})");>]
        member internal __.setChildContextTypes() : unit = failwith "never"

        [<FunScript.JSEmitInline("({0}.childContextTypes)")>]
        member __.childContextTypes with get() : obj = failwith "never" and set (v : obj) : unit = failwith "never"

    type FunScript.TypeScript.React.Component<'P, 'S> with

        [<FunScript.JSEmitInline("({0}.getValue())");>]
        member __.getValue() : obj = failwith "never"
        [<FunScript.JSEmitInline("({0}.setValue({1}))");>]
        member __.setValue(o: obj) : unit = failwith "never"
