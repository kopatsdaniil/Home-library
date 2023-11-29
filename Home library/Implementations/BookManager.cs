using System.Xml.Serialization;
using Home_library.Interfaces;
using Home_library.Models.Book;

namespace Home_library.Implementations;

public class BookManager : IManager<Book>
{
    private const string FILENAME = "books.xml";

    public void Save(IList<Book> books)
    {
        var serializer = new XmlSerializer(typeof(List<Book>));

        using var stream = File.Create(FILENAME);
        serializer.Serialize(stream, books);
    }

    public IList<Book> Load()
    {
        var serializer = new XmlSerializer(typeof(List<Book>));

        using var stream = File.OpenRead(FILENAME);
        return (List<Book>)serializer.Deserialize(stream);
    }
}