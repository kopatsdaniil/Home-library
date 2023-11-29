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


        booksBox.DataSource = _booksManager.Load().Select(x => x.Title).ToList();
    }

    private void AddABookToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var addBook = _provider.GetRequiredService<AddBookForm>();
        addBook.Show();
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void RemoveABookToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void booksBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}