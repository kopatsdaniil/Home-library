namespace Home_library.Models;

public class ValidationResult
{
    public ValidationResult(bool success, string message)
    {
        Message = message;
        Success = success;
    }

    public string Message { get; set; }

    public bool Success { get; set; }
}