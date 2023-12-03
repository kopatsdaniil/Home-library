using Home_library.Models.Book;

namespace Home_library.Implementations;

public class BookEditor
{
    private Book selectedBook { get; set; }
    private int Index { get; set; }

    public void SetSelectedBook(Book book)
    {
        selectedBook = book;
    }

    public Book GetSelectedBook()
    {
        return selectedBook;
    }

    public void SetIndex(int index)
    {
        Index = index;
    }

    public int GetIndex()
    {
        return Index;
    }
}
