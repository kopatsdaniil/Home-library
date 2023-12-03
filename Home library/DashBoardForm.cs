using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Home_library.Implementations;
using Home_library.Interfaces;
using Home_library.Models.Book;
using Microsoft.Extensions.DependencyInjection;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.DataFormats;

namespace Home_library;

public partial class DashboardForm : Form
{
    private readonly IServiceProvider _provider;
    private readonly IManager<Book> _booksManager;
    private readonly BookEditor _bookEditor;

    public DashboardForm(IServiceProvider provider, IManager<Book> booksManager, BookEditor bookEditor)   
    {
        InitializeComponent();

        _provider = provider;
        _booksManager = booksManager;
        _bookEditor = bookEditor;

        RefreshBooksBox();
    }

    private void RefreshBooksBox()
    {
        booksBox.DataSource = _booksManager.Load().Select(x => x.Title).ToList();
    }

    private void AddABookToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var addBook = _provider.GetRequiredService<AddBookForm>();

        if (addBook.ShowDialog() == DialogResult.OK)
        {
            RefreshBooksBox();
        }
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

        BookPicture.ImageLocation = books.ElementAt(booksBox.SelectedIndex).PathBookImg;
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {
        
    }

    private void EditABookToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var books = _booksManager.Load();
        var index = booksBox.SelectedIndex;

        _bookEditor.SetSelectedBook(books[index]);
        _bookEditor.SetIndex(index);

        var editForm = _provider.GetRequiredService<EditBookForm>();
        if (editForm.ShowDialog() == DialogResult.OK)
        {
            RefreshBooksBox();
        }
    }

    private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
}