using Home_library.Implementations;
using Home_library.Interfaces;
using Home_library.Models.Book;

namespace Home_library;

public partial class MakeListForm : Form
{
    private readonly IManager<Book> _bookManager;

    public MakeListForm(IManager<Book> bookManager)
    {
        InitializeComponent();

        _bookManager = bookManager;

        var books = _bookManager.Load();

        AuthorData.DataSource = books.Select(x => x.AuthorSurname).Distinct().ToList();
        PublisherData.DataSource = books.Select(x => x.Publisher).Distinct().ToList();
        CategoryData.DataSource = Enum.GetValues(typeof(BookCategory));
        GenreData.DataSource = Enum.GetValues(typeof(BookGenre));
        ReleaseYearData.DataSource = Enumerable.Range(0, 2024).Reverse().ToList();

        AuthorData.SelectedIndex = PublisherData.SelectedIndex = CategoryData.SelectedIndex =
            GenreData.SelectedIndex = ReleaseYearData.SelectedIndex = -1;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var books = _bookManager.Load();

        var selectedAuthor = AuthorData.SelectedItem?.ToString();
        var selectedPublisher = PublisherData.SelectedItem?.ToString();
        var selectedCategory = CategoryData.SelectedIndex > -1 ? CategoryData.SelectedItem.ToString() : string.Empty;
        var selectedGenre = GenreData.SelectedIndex > -1 ? GenreData.SelectedItem.ToString() : string.Empty;
        var selectedYear = ReleaseYearData.SelectedIndex > -1
            ? Convert.ToInt16(ReleaseYearData.SelectedItem.ToString())
            : -1;

        var filteredBooks = books.Where(x =>
            (string.IsNullOrWhiteSpace(selectedAuthor) || x.AuthorSurname == selectedAuthor) &&
            (string.IsNullOrWhiteSpace(selectedPublisher) || x.Publisher == selectedPublisher) &&
            (string.IsNullOrWhiteSpace(selectedCategory) || x.Category.ToString() == selectedCategory) &&
            (string.IsNullOrWhiteSpace(selectedGenre) || x.Genre.ToString() == selectedGenre) &&
            (selectedYear == -1 || x.ReleaseDate.Year.ToString() == selectedYear.ToString())).ToList();

        if (filteredBooks.Count == 0)
        {
            MessageBox.Text = "There are no such books!";
        }
        else
        {
            MessageBox.Text = "List created successfully!";
            BookListFormer.SaveDataToFile(filteredBooks);
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}