using Home_library.Implementations;
using Home_library.Interfaces;
using Home_library.Models.Book;
using Microsoft.Extensions.DependencyInjection;

namespace Home_library;

public partial class DashboardForm : Form
{
    private readonly BookEditor _bookEditor;
    private readonly List<Book> _booksFound;
    private readonly IManager<Book> _booksManager;
    private readonly IServiceProvider _provider;

    public DashboardForm(IServiceProvider provider, IManager<Book> booksManager, BookEditor bookEditor,
        List<Book> booksFound)
    {
        InitializeComponent();

        _provider = provider;
        _booksManager = booksManager;
        _bookEditor = bookEditor;
        _booksFound = booksFound;

        RefreshBooksBox();
    }

    private void RefreshBooksBox()
    {
        booksBox.DataSource = _booksManager.Load().Select(x => x.Title).ToList();
    }

    private void AddABookToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var addBook = _provider.GetRequiredService<AddBookForm>();

        if (addBook.ShowDialog() == DialogResult.OK) RefreshBooksBox();
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void RemoveABookToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var resultDialog = MessageBox.Show("Are you sure you want to delete selected book?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (resultDialog == DialogResult.Yes)
        {
            var index = booksBox.SelectedIndex;
            var books = _booksManager.Load();

            books.RemoveAt(index);
            _booksManager.Save(books);
            RefreshBooksBox();
        }
    }

    private void BooksBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var books = _booksManager.Load();
        var selectedBook = books.ElementAt(booksBox.SelectedIndex);

        BookPicture.ImageLocation = selectedBook.PathBookImg;
        AuthorData.Text = selectedBook.AuthorFullName();
        TitleData.Text = selectedBook.Title;
        ReleaseDateData.Text = selectedBook.ReleaseDate.ToShortDateString();
        PublisherData.Text = selectedBook.Publisher;
        DescriptionData.Text = selectedBook.Description;
        CategoryData.Text = selectedBook.Category.ToString();
        GenreData.Text = selectedBook.Genre.ToString();
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {
    }

    private void EditABookToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var books = _booksManager.Load();
        var index = booksBox.SelectedIndex;

        _bookEditor.SetSelectedBook(books.ElementAt(index));

        var editForm = _provider.GetRequiredService<EditBookForm>();
        if (editForm.ShowDialog() == DialogResult.OK) RefreshBooksBox();
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        _booksFound.Clear();

        var textToSearch = SearchBox.Text;
        var books = _booksManager.Load();

        if (string.IsNullOrWhiteSpace(textToSearch)) return;

        foreach (var book in books)
            if (book.Search(textToSearch))
                _booksFound.Add(book);

        booksFoundBox.BringToFront();
        booksFoundBox.DataSource = _booksFound.Select(x => x.Title).ToList();
    }

    private void SearchBox_Click(object sender, EventArgs e)
    {
        SearchBox.Clear();
    }

    private void ShowAllBooks_Click(object sender, EventArgs e)
    {
        SearchBox.Clear();
        booksBox.BringToFront();
    }

    private void BooksFoundBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var books = _booksFound;
        var selectedBook = books.ElementAt(booksFoundBox.SelectedIndex);

        BookPicture.ImageLocation = selectedBook.PathBookImg;
        AuthorData.Text = selectedBook.AuthorFullName();
        TitleData.Text = selectedBook.Title;
        ReleaseDateData.Text = selectedBook.ReleaseDate.ToShortDateString();
        PublisherData.Text = selectedBook.Publisher;
        DescriptionData.Text = selectedBook.Description;
        CategoryData.Text = selectedBook.Category.ToString();
        GenreData.Text = selectedBook.Genre.ToString();
    }

    private void GenerateListsOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var makeList = _provider.GetRequiredService<MakeListForm>();
        makeList.Show();
    }
}