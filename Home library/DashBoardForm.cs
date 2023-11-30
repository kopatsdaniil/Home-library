using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Home_library.Interfaces;
using Home_library.Models.Book;
using Microsoft.Extensions.DependencyInjection;

namespace Home_library;

public partial class DashboardForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly IManager<Book> _booksManager;

    public DashboardForm(IServiceProvider provider, IManager<Book> booksManager)
    {
        InitializeComponent();

        _provider = provider;
        _booksManager = booksManager;

        RefreshBooksBox();
    }

    public void RefreshBooksBox()
    {
        booksBox.DataSource = _booksManager.Load().Select(x => x.Title).ToList();
    }

    private void AddABookToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var addBook = _provider.GetRequiredService<AddBookForm>();
        addBook.Show();

        booksBox.DataSource = _booksManager.Load().Select(x => x.Title).ToList();
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

        var index = booksBox.SelectedIndex;

        BookPicture.ImageLocation = books.ElementAt(index).PathBookImg;
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {

    }
}