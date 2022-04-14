using Microsoft.AspNetCore.Mvc;
using Portfolio_Misc.Services.EmailServices;

namespace Portfolio.Controllers;

public class ContactController : Controller
{
    private readonly IEmailServices _emailService;
    private readonly EmailConfiguration _emailConfiguration;

    public ContactController(IEmailServices emailService, EmailConfiguration emailConfiguration)
    {
        _emailService = emailService;
        _emailConfiguration = emailConfiguration;
    }

    [HttpGet]
    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Send(string nameContact, string emailContact, string subjectContact, string messageContact)
    {
        var message = new Message(new[] {_emailConfiguration.From}, $"Contact from:{subjectContact}",
            $"Name:{nameContact}\nEmail:{emailContact}\n\n{messageContact}");
        _emailService.SendEmail(message);
        return Ok("sent successfully");
    }
}