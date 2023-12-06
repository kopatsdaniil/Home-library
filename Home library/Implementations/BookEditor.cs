using Home_library.Models.Book;

namespace Home_library.Implementations;

public class BookEditor
{
    private Book? SelectedBook { get; set; }

    public void SetSelectedBook(Book book)
    {
        SelectedBook = book;
    }

    public Book? GetSelectedBook()
    {
        return SelectedBook;
    }
}