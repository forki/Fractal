namespace Fractal

type RouterNode = {
    name : string
    path : string
    children : RouterNode[]
}

type Router = interface end

[<AutoOpen>]
module TypeExtensions_routie_0 =


    type Router with

        [<FunScript.JSEmitInline("(new Router5({0}))")>]
        static member Create(routes : RouterNode[]) : Router = failwith "never"
        [<FunScript.JSEmitInline("(new Router5({0}))")>]
        static member Create(route : RouterNode) : Router = failwith "never"

        [<FunScript.JSEmitInline("({0}.setOption({1},{2}))")>]
        member __.setOption(opt : string, value : obj) : Router = failwith "never"
        [<FunScript.JSEmitInline("({0}.add({1}))")>]
        member __.add(routes : RouterNode[]) : Router = failwith "never"
        [<FunScript.JSEmitInline("({0}.add({1}))")>]
        member __.add(route : RouterNode) : Router = failwith "never"
        [<FunScript.JSEmitInline("({0}.start())")>]
        member __.start() : Router = failwith "never"
        [<FunScript.JSEmitInline("({0}.stop())")>]
        member __.stop() : Router = failwith "never"
        [<FunScript.JSEmitInline("({0}.addRouteListener({1},{2}))")>]
        member __.addRouteListener(path : string, cb : obj * obj -> unit) : Router = failwith "never"
        [<FunScript.JSEmitInline("({0}.canActivate({1},{2}))")>]
        member __.canActivate(path : string, cb : obj * obj * (unit -> unit) -> unit) : Router = failwith "never"
        [<FunScript.JSEmitInline("({0}.navigate({1}))")>]
        member __.navigate(path : string) : Router = failwith "never"
