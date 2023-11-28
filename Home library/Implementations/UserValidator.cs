using Home_library.Interfaces;
using Home_library.Models;

namespace Home_library.Implementations;

public class UserValidator : IValidator<User>
{
    public (bool, string) Validate(IList<User> users, User user)
    {
        if (!user.IsValid())
        {
            return (false, "Invalid username or password");
        }

        var foundUser = users.FirstOrDefault(x => x.Username == user.Username);

        if (foundUser != null)
        {
            return (false, "This username has been already taken!");
        }

        return (true, "You have successfully sign up!");
    }
}