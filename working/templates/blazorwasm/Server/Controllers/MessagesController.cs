using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers;

[ApiController]
[Route("api/messages")]
public class MessagesController : ControllerBase
{
    [HttpGet("main")]
    public Message GetMainMessage() => new("A clean canvas for a Blazor app");
}
