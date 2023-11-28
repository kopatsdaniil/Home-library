namespace Home_library.Interfaces;

public interface IManager<T> where T : class
{
    public void Save(IList<T> entities);

    public IList<T> Load(string filename);
}