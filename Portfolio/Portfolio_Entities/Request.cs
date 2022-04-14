namespace Portfolio_Entities;

public class Request
{
    public Guid RequestId { get; set; } 
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public  string Message { get; set; }
}