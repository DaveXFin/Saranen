using Microsoft.AspNetCore.Mvc;

namespace ToDoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MySimpleApiController : ControllerBase
{
    // Use route to define and execute a specific method

    // returns hello string
    [Route("hello")]
    public string SayHello()
    {
        return "Hello World from a ASP.NET C# web API application.";
    }


    // returns the current system time
    [Route("time")]
    public DateTime CurrentTime()
    {
        return DateTime.Now;
    }
    

    [Route("numbers")]
    public List<int> NumbersList()
    {
        return new() {1,4,56,34,35,6,7,3};
    }
}