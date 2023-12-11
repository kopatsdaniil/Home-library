using Home_library.Interfaces;
using Home_library.Models.Book;

namespace Home_library;

public partial class AddBookForm : Form
{
    private readonly IManager<Book> _bookManager;
    private readonly IValidator<Book> _bookValidator;

    public AddBookForm(IManager<Book> bookManager, IValidator<Book> bookValidator)
    {
        InitializeComponent();

        CategoryData.DataSource = Enum.GetValues(typeof(BookCategory));
        GenreData.DataSource = Enum.GetValues(typeof(BookGenre));

        _bookManager = bookManager;
        _bookValidator = bookValidator;
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
        var newBook = new Book(AuthorNameData.Text, AuthorSurnameData.Text, TitleData.Text, ReleaseDateData.Value,
            PublisherData.Text, DescriptionData.Text, BookImageData.Text, (BookCategory)CategoryData.SelectedIndex,
            (BookGenre)GenreData.SelectedIndex, Guid.NewGuid());

        var books = _bookManager.Load();

        var validationResult = _bookValidator.Validate(books, newBook);

        MessageBox.Text = validationResult.Message;
        if (!validationResult.Success) return;

        books.Add(newBook);
        _bookManager.Save(books);
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}