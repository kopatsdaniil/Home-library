using System.Xml;
using System.Xml.Serialization;
using Home_library.Interfaces;
using Home_library.Models;

namespace Home_library.Implementations;

public class UserManager : IManager<User>
{
    private const string Filepath = @"C:\Users\kopot\source\repos\Home library\Home library\Implementations\Data workers\Data\users.xml";

    public IList<User> Load()
    {
        var serializer = new XmlSerializer(typeof(List<User>));

        using var stream = File.OpenRead(Filepath);
        return (List<User>)serializer.Deserialize(stream);
    }

    public void Save(IList<User> entities)
    {
        var xmlWriterSettings = new XmlWriterSettings { Indent = true };
        var serializer = new XmlSerializer(typeof(List<User>));

        using var writer = XmlWriter.Create(Filepath, xmlWriterSettings);
        serializer.Serialize(writer, entities);
    }
}