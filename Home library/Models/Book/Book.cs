using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Home_library.Models.Book;

[Serializable]
public class Book
{
    public Book(string authorName, string authorSurname, string title, DateTime releaseDate, string publisher,
        string description, string pathBookImg, BookCategory category, BookGenre genre, Guid id)
    {
        AuthorName = authorName;
        AuthorSurname = authorSurname;
        Title = title;
        ReleaseDate = releaseDate;
        Publisher = publisher;
        Description = description;
        PathBookImg = pathBookImg;
        Category = category;
        Genre = genre;
        Id = id;
    }

    public Book()
    {
    }

    [Required(ErrorMessage = "Book must have an author's name")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of the author's name")]
    public string AuthorName { get; set; }

    [Required(ErrorMessage = "Book must have an author's surname")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of the author's surname")]
    public string AuthorSurname { get; set; }

    [Required(ErrorMessage = "Book must have a title")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of the title")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Book must have a date of it's release")]
    [Range(0, 2023)]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "Book must have a picture of it")]
    public string PathBookImg { get; set; }

    [Required(ErrorMessage = "Book must have a publisher")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid length of the publisher")]
    public string Publisher { get; set; }

    [Required(ErrorMessage = "Book must have a description")]
    [StringLength(1000, MinimumLength = 3, ErrorMessage = "Invalid length of the description")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Book must have a category")]
    public BookCategory Category { get; set; }

    [Required(ErrorMessage = "Book must have a genre")]
    public BookGenre Genre { get; set; }

    public Guid Id { get; set; }

    public bool IsValid()
    {
        if (!Regex.IsMatch(AuthorName, @"^[a-zA-Z]+$")) return false;
        if (string.IsNullOrWhiteSpace(AuthorName)) return false;
        if (!Regex.IsMatch(AuthorSurname, @"^[a-zA-Z]+$")) return false;
        if (string.IsNullOrWhiteSpace(AuthorSurname)) return false;
        if (string.IsNullOrWhiteSpace(Title)) return false;
        if (ReleaseDate > DateTime.Now) return false;
        if (string.IsNullOrWhiteSpace(Description)) return false;
        if (string.IsNullOrWhiteSpace(Publisher)) return false;
        if (string.IsNullOrWhiteSpace(PathBookImg)) return false;

        return true;
    }

    public string AuthorFullName()
    {
        return AuthorName + ' ' + AuthorSurname;
    }

    public bool Search(string searchString)
    {
        searchString = searchString.ToLower();

        if (AuthorName.ToLower().Contains(searchString) || AuthorSurname.ToLower().Contains(searchString) ||
            Title.ToLower().Contains(searchString) ||
            Publisher.ToLower().Contains(searchString) || Description.ToLower().Contains(searchString) ||
            Category.ToString().ToLower().Contains(searchString) || Genre.ToString().ToLower().Contains(searchString))
            return true;

        return false;
    }
}