using System.Xml;
using System.Xml.Serialization;
using Home_library.Models.Book;

namespace Home_library.Implementations;

public class BookListFormer
{
    private const string Filepath = @"C:\Users\kopot\source\repos\Home library\Home library\Data\ListOfBooks.xml";

    public static void SaveDataToFile(List<Book> books)
    {
        if (!File.Exists(Filepath))
        {
            File.Create(Filepath);

            var xmlWriterSettings = new XmlWriterSettings { Indent = true };
            var serializer = new XmlSerializer(typeof(List<Book>));

            using var writer = XmlWriter.Create(Filepath, xmlWriterSettings);
            serializer.Serialize(writer, books);
        }
        else if (File.Exists(Filepath))
        {
            var xmlWriterSettings = new XmlWriterSettings { Indent = true };
            var serializer = new XmlSerializer(typeof(List<Book>));

            using var writer = XmlWriter.Create(Filepath, xmlWriterSettings);
            serializer.Serialize(writer, books);
        }
    }
}