using Home_library.Interfaces;
using Home_library.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Serialization;
using User = Home_library.Models.User;

namespace Home_library.Implementations;

public class UserManager : IManager<User>
{
    public IList<User> Load(string filename)
    {
        var serializer = new XmlSerializer(typeof(List<User>));

        using var stream = File.OpenRead(filename);
        return (List<User>)serializer.Deserialize(stream);
    }

    public void Save(IList<User> entities)
    {
        var serializer = new XmlSerializer(typeof(List<User>));

        using var stream = File.Create("users.xml");
        serializer.Serialize(stream, entities);
    }
}