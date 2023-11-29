using Home_library.Models;

namespace Home_library.Interfaces;

public interface IValidator<T> where T : class
{
    public ValidationResult Validate(IList<T> users, T user);
}