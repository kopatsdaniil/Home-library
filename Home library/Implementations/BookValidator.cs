using Home_library.Interfaces;
using Home_library.Models;
using Home_library.Models.Book;

namespace Home_library.Implementations;

public class BookValidator : IValidator<Book>
{
    public ValidationResult Validate(IList<Book> books, Book book)
    {
        if (!book.IsValid()) return new ValidationResult(false, "Invalid book data!");

        var bookFound = books.FirstOrDefault(x => x.AuthorSurname == book.AuthorSurname && x.Title == book.Title);

        if (bookFound != null) return new ValidationResult(true, "This book is already exists");

        return new ValidationResult(true, "Book has been created!");
    }
}