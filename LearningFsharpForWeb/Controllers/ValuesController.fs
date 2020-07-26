namespace LearningFsharpForWeb.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging


[<ApiController>]
[<Route("[controller]")>]
type ValuesController(logger: ILogger<ValuesController>)=
    inherit ControllerBase()
    
    [<HttpGet>]
    member __.Get() : string =
        let helloWorld = "Hello World"
        helloWorld

