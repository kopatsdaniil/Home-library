using System.Xml.Serialization;
using Home_library.Interfaces;
using Home_library.Models;

namespace Home_library.Implementations;

public class UserManager : IManager<User>
{
    private const string FILENAME = "users.xml";

    public IList<User> Load()
    {
        var serializer = new XmlSerializer(typeof(List<User>));

        using var stream = File.OpenRead(FILENAME);
        return (List<User>)serializer.Deserialize(stream);
    }

    public void Save(IList<User> entities)
    {
        var serializer = new XmlSerializer(typeof(List<User>));

        using var stream = File.Create(FILENAME);
        serializer.Serialize(stream, entities);
    }
}