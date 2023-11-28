using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Home_library;

[Serializable]
public class User
{
    [Required(ErrorMessage = "User must have a username")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "User must have a password")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of password")]
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public User() { }

    public bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(Username)) return false;
        if (string.IsNullOrWhiteSpace(Password)) return false;

        return true;
    }

    public static void SaveUsers(List<User> users)
    {
        var serializer = new XmlSerializer(typeof(List<User>));
        using var stream = File.Create("users.xml");
        serializer.Serialize(stream, users);
    }

    public static List<User> LoadUsers()
    {
        var serializer = new XmlSerializer(typeof(List<User>));

        using var stream = File.OpenRead("users.xml");
        return (List<User>)serializer.Deserialize(stream);
    }
}