// Mark A Ramirez
// 10/25/2022
// Say Hello - Endpoint
// will say hi
// peer reviewed by: Jacob Dekok - The code looks great and is organized. 
// The program runs as intended



using Microsoft.AspNetCore.Mvc;

namespace RamirezM_Say_Hello_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{

    [HttpGet]
    [Route("Hello/{name}")]

    public string  hello(string name)
    {
        return $"hello {name} ok bye";
    }

}
