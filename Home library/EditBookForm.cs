using Home_library.Implementations;
using Home_library.Interfaces;
using Home_library.Models.Book;

namespace Home_library;

public partial class EditBookForm : Form
{
    private readonly BookEditor _bookEditor;
    private readonly IManager<Book> _bookManager;
    private readonly IValidator<Book> _bookValidator;
    private readonly Guid _id;

    public EditBookForm(IManager<Book> bookManager, IValidator<Book> bookValidator, BookEditor bookEditor)
    {
        InitializeComponent();

        CategoryData.DataSource = Enum.GetValues(typeof(BookCategory));
        GenreData.DataSource = Enum.GetValues(typeof(BookGenre));

        _bookManager = bookManager;
        _bookValidator = bookValidator;
        _bookEditor = bookEditor;

        var selectedBook = _bookEditor.GetSelectedBook();
        _id = selectedBook.Id;

        AuthorNameData.Text = selectedBook.AuthorName;
        AuthorSurnameData.Text = selectedBook.AuthorSurname;
        TitleData.Text = selectedBook.Title;
        ReleaseDateData.Value = selectedBook.ReleaseDate;
        PublisherData.Text = selectedBook.Publisher;
        DescriptionData.Text = selectedBook.Description;
        BookImageData.Text = selectedBook.PathBookImg;
        CategoryData.SelectedIndex = (int)selectedBook.Category;
        GenreData.SelectedIndex = (int)selectedBook.Genre;
    }

    private void UploadImageButton_Click(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog();
        var result = dialog.ShowDialog();

        if (result == DialogResult.OK)
        {
            BookImageData.Text = dialog.FileName;
            InfoLabel.SendToBack();
            BookImageBox.ImageLocation = BookImageData.Text;
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var bookToEdit = new Book(AuthorNameData.Text, AuthorSurnameData.Text, TitleData.Text, ReleaseDateData.Value,
            PublisherData.Text, DescriptionData.Text, BookImageData.Text, (BookCategory)CategoryData.SelectedIndex,
            (BookGenre)GenreData.SelectedIndex, Guid.NewGuid());

        var books = _bookManager.Load();
        var validationResult = _bookValidator.Validate(books, bookToEdit);

        MessageBox.Text = validationResult.Message;
        if (!validationResult.Success) return;

        var oldBook = books.First(x => x.Id == _id);
        books.Insert(books.IndexOf(oldBook), bookToEdit);
        books.Remove(oldBook);

        _bookManager.Save(books);
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}