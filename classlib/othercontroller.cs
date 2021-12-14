namespace classlib;
using Microsoft.AspNetCore.Mvc;
[Route("classlib/other")]
[ApiController]
public class othercontroller : ControllerBase
{
    [HttpGet]
    public string GetString(){
        return "hi";
    }
}