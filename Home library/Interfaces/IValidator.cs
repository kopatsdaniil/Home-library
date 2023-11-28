namespace Home_library.Interfaces;

public interface IValidator<T> where T : class
{
    public (bool, string) Validate(IList<T> users, T user);
}