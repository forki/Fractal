namespace FunScript.TypeScript.routie
type AnonymousType441 = interface end

namespace FunScript.TypeScript.routie
type Route = interface end

namespace FunScript.TypeScript.routie
type RouteOptions = interface end

namespace FunScript.TypeScript.routie
type RoutieStatic = interface end

namespace FunScript.TypeScript.routie
type Routie =
        inherit RoutieStatic


namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_routie_0 =


    type Globals with

            [<FunScript.JSEmitInline("(window.routie)"); CompiledName("routie")>]
            static member routie with get() : FunScript.TypeScript.routie.Routie = failwith "never" and set (v : FunScript.TypeScript.routie.Routie) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_routie_1 =


    type FunScript.TypeScript.routie.AnonymousType441 with

            [<FunScript.JSEmitInline("({0}[{1}])"); CompiledName("Item_42")>]
            member __.Item with get(i : string) : FunScript.TypeScript.Function = failwith "never" and set (i : string) (v : FunScript.TypeScript.Function) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_routie_2 =


    type FunScript.TypeScript.routie.Route with

            [<FunScript.JSEmitInline("({0}.constructor({1}, {2}))"); CompiledName("_constructor_1")>]
            member __._constructor(path : string, name : string) : FunScript.TypeScript.routie.Route = failwith "never"
            [<FunScript.JSEmitInline("({0}.constructor = {1})"); CompiledName("_constructor_1Aux")>]
            member __.``_constructor <-``(func : System.Func<string, string, FunScript.TypeScript.routie.Route>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.addHandler({1}))"); CompiledName("addHandler")>]
            member __.addHandler(fn : FunScript.TypeScript.Function) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.addHandler = {1})"); CompiledName("addHandlerAux")>]
            member __.``addHandler <-``(func : System.Func<FunScript.TypeScript.Function, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.removeHandler({1}))"); CompiledName("removeHandler")>]
            member __.removeHandler(fn : FunScript.TypeScript.Function) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.removeHandler = {1})"); CompiledName("removeHandlerAux")>]
            member __.``removeHandler <-``(func : System.Func<FunScript.TypeScript.Function, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.run({1}))"); CompiledName("run")>]
            member __.run(_params : obj) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.run = {1})"); CompiledName("runAux")>]
            member __.``run <-``(func : System.Func<obj, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.match({1}, {2}))"); CompiledName("_match_2")>]
            member __._match(path : string, _params : obj) : bool = failwith "never"
            [<FunScript.JSEmitInline("({0}.match = {1})"); CompiledName("_match_2Aux")>]
            member __.``_match <-``(func : System.Func<string, obj, bool>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.toURL({1}))"); CompiledName("toURL")>]
            member __.toURL(_params : obj) : string = failwith "never"
            [<FunScript.JSEmitInline("({0}.toURL = {1})"); CompiledName("toURLAux")>]
            member __.``toURL <-``(func : System.Func<obj, string>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_routie_3 =


    type FunScript.TypeScript.routie.RouteOptions with

            [<FunScript.JSEmitInline("({0}.silent)"); CompiledName("silent")>]
            member __.silent with get() : bool = failwith "never" and set (v : bool) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_routie_4 =


    type FunScript.TypeScript.routie.Routie with

            [<FunScript.JSEmitInline("({0}({1}))"); CompiledName("Invoke_37")>]
            member __.Invoke(path : string) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_37Aux")>]
            member __.``Invoke <-``(func : System.Func<string, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}, {2}))"); CompiledName("Invoke_38")>]
            member __.Invoke(path : string, fn : FunScript.TypeScript.Function) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_38Aux")>]
            member __.``Invoke <-``(func : System.Func<string, FunScript.TypeScript.Function, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}({1}))"); CompiledName("Invoke_39")>]
            member __.Invoke(routes : FunScript.TypeScript.routie.AnonymousType441) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0} = {1})"); CompiledName("Invoke_39Aux")>]
            member __.``Invoke <-``(func : System.Func<FunScript.TypeScript.routie.AnonymousType441, unit>) : unit = failwith "never"

namespace FunScript.TypeScript

[<AutoOpen>]
module TypeExtensions_routie_5 =


    type FunScript.TypeScript.routie.RoutieStatic with

            [<FunScript.JSEmitInline("({0}.lookup({1}, {2}))"); CompiledName("lookup")>]
            member __.lookup(name : string, fn : FunScript.TypeScript.Function) : string = failwith "never"
            [<FunScript.JSEmitInline("({0}.lookup = {1})"); CompiledName("lookupAux")>]
            member __.``lookup <-``(func : System.Func<string, FunScript.TypeScript.Function, string>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.remove({1}, {2}))"); CompiledName("remove_5")>]
            member __.remove(path : string, fn : FunScript.TypeScript.Function) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.remove = {1})"); CompiledName("remove_5Aux")>]
            member __.``remove <-``(func : System.Func<string, FunScript.TypeScript.Function, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.removeAll())"); CompiledName("removeAll")>]
            member __.removeAll() : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.removeAll = {1})"); CompiledName("removeAllAux")>]
            member __.``removeAll <-``(func : System.Func<unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.navigate({1}, {?2}))"); CompiledName("navigate_3")>]
            member __.navigate(path : string, ?options : FunScript.TypeScript.routie.RouteOptions) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.navigate = {1})"); CompiledName("navigate_3Aux")>]
            member __.``navigate <-``(func : System.Func<string, FunScript.TypeScript.routie.RouteOptions, unit>) : unit = failwith "never"
            [<FunScript.JSEmitInline("({0}.noConflict())"); CompiledName("noConflict")>]
            member __.noConflict() : FunScript.TypeScript.routie.Routie = failwith "never"
            [<FunScript.JSEmitInline("({0}.noConflict = {1})"); CompiledName("noConflictAux")>]
            member __.``noConflict <-``(func : System.Func<FunScript.TypeScript.routie.Routie>) : unit = failwith "never"
