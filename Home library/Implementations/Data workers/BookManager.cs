using System.Xml;
using System.Xml.Serialization;
using Home_library.Interfaces;
using Home_library.Models.Book;

namespace Home_library.Implementations;

public class BookManager : IManager<Book>
{
    private const string Filepath = @"C:\Users\kopot\source\repos\Home library\Home library\Implementations\Data workers\Data\books.xml";

    public void Save(IList<Book> books)
    {
        var xmlWriterSettings = new XmlWriterSettings { Indent = true };
        var serializer = new XmlSerializer(typeof(List<Book>));

        using var writer = XmlWriter.Create(Filepath, xmlWriterSettings);
        serializer.Serialize(writer, books);
    }

    public IList<Book> Load()
    {
        var serializer = new XmlSerializer(typeof(List<Book>));

        using var stream = File.OpenRead(Filepath);
        return (List<Book>)serializer.Deserialize(stream);
    }
}