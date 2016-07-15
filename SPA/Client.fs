namespace SPA

open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.Html

[<JavaScript>]
module Client =

    let Main =
        JQuery
            .Of("#main")
            .Html("<h1>Hello world<h1/>")
        