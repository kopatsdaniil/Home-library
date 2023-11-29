using System.ComponentModel.DataAnnotations;

namespace Home_library.Models;

[Serializable]
public class User
{
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public User()
    {
    }

    [Required(ErrorMessage = "User must have a username")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "User must have a password")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of password")]
    public string Password { get; set; }

    public bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(Username)) return false;
        if (string.IsNullOrWhiteSpace(Password)) return false;

        return true;
    }
}