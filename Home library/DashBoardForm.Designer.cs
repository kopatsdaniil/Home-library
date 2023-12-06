namespace Home_library
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.OperationsList = new System.Windows.Forms.MenuStrip();
            this.AddABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateListsOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksBox = new System.Windows.Forms.ListBox();
            this.BookPicture = new System.Windows.Forms.PictureBox();
            this.BookLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AuthorData = new System.Windows.Forms.TextBox();
            this.TitleData = new System.Windows.Forms.TextBox();
            this.ReleaseDateData = new System.Windows.Forms.TextBox();
            this.PublisherData = new System.Windows.Forms.TextBox();
            this.DescriptionData = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.CategoryData = new System.Windows.Forms.TextBox();
            this.GenreData = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowAllBooks = new System.Windows.Forms.Button();
            this.booksFoundBox = new System.Windows.Forms.ListBox();
            this.OperationsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsList
            // 
            this.OperationsList.BackColor = System.Drawing.Color.SlateGray;
            this.OperationsList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OperationsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddABookToolStripMenuItem,
            this.RemoveABookToolStripMenuItem,
            this.EditABookToolStripMenuItem,
            this.GenerateListsOfBooksToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.OperationsList.Location = new System.Drawing.Point(0, 0);
            this.OperationsList.Name = "OperationsList";
            this.OperationsList.Size = new System.Drawing.Size(919, 58);
            this.OperationsList.TabIndex = 0;
            // 
            // AddABookToolStripMenuItem
            // 
            this.AddABookToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.AddABookToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddABookToolStripMenuItem.Image")));
            this.AddABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddABookToolStripMenuItem.Name = "AddABookToolStripMenuItem";
            this.AddABookToolStripMenuItem.Size = new System.Drawing.Size(124, 54);
            this.AddABookToolStripMenuItem.Text = "Add a book";
            this.AddABookToolStripMenuItem.Click += new System.EventHandler(this.AddABookToolStripMenuItem_Click);
            // 
            // RemoveABookToolStripMenuItem
            // 
            this.RemoveABookToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.RemoveABookToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveABookToolStripMenuItem.Image")));
            this.RemoveABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveABookToolStripMenuItem.Name = "RemoveABookToolStripMenuItem";
            this.RemoveABookToolStripMenuItem.Size = new System.Drawing.Size(146, 54);
            this.RemoveABookToolStripMenuItem.Text = "Remove a book";
            this.RemoveABookToolStripMenuItem.Click += new System.EventHandler(this.RemoveABookToolStripMenuItem_Click);
            // 
            // EditABookToolStripMenuItem
            // 
            this.EditABookToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.EditABookToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditABookToolStripMenuItem.Image")));
            this.EditABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditABookToolStripMenuItem.Name = "EditABookToolStripMenuItem";
            this.EditABookToolStripMenuItem.Size = new System.Drawing.Size(124, 54);
            this.EditABookToolStripMenuItem.Text = "Edit a book";
            this.EditABookToolStripMenuItem.Click += new System.EventHandler(this.EditABookToolStripMenuItem_Click);
            // 
            // GenerateListsOfBooksToolStripMenuItem
            // 
            this.GenerateListsOfBooksToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.GenerateListsOfBooksToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateListsOfBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GenerateListsOfBooksToolStripMenuItem.Image")));
            this.GenerateListsOfBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GenerateListsOfBooksToolStripMenuItem.Name = "GenerateListsOfBooksToolStripMenuItem";
            this.GenerateListsOfBooksToolStripMenuItem.Size = new System.Drawing.Size(183, 54);
            this.GenerateListsOfBooksToolStripMenuItem.Text = "Generate lists of books";
            this.GenerateListsOfBooksToolStripMenuItem.Click += new System.EventHandler(this.GenerateListsOfBooksToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(58, 54);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // booksBox
            // 
            this.booksBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(79)))));
            this.booksBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booksBox.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.booksBox.FormattingEnabled = true;
            this.booksBox.ItemHeight = 17;
            this.booksBox.Location = new System.Drawing.Point(10, 106);
            this.booksBox.Name = "booksBox";
            this.booksBox.Size = new System.Drawing.Size(281, 342);
            this.booksBox.TabIndex = 1;
            this.booksBox.SelectedIndexChanged += new System.EventHandler(this.BooksBox_SelectedIndexChanged);
            // 
            // BookPicture
            // 
            this.BookPicture.Location = new System.Drawing.Point(325, 106);
            this.BookPicture.Name = "BookPicture";
            this.BookPicture.Size = new System.Drawing.Size(167, 216);
            this.BookPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPicture.TabIndex = 2;
            this.BookPicture.TabStop = false;
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookLabel.Location = new System.Drawing.Point(325, 358);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(35, 14);
            this.BookLabel.TabIndex = 3;
            this.BookLabel.Text = "Book:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorLabel.Location = new System.Drawing.Point(325, 334);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(43, 14);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateLabel.Location = new System.Drawing.Point(325, 384);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(74, 14);
            this.ReleaseDateLabel.TabIndex = 5;
            this.ReleaseDateLabel.Text = "Release date:";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PublisherLabel.Location = new System.Drawing.Point(325, 409);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(55, 14);
            this.PublisherLabel.TabIndex = 6;
            this.PublisherLabel.Text = "Publisher:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(325, 434);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(66, 14);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // AuthorData
            // 
            this.AuthorData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AuthorData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorData.Location = new System.Drawing.Point(419, 331);
            this.AuthorData.Name = "AuthorData";
            this.AuthorData.Size = new System.Drawing.Size(242, 25);
            this.AuthorData.TabIndex = 8;
            // 
            // TitleData
            // 
            this.TitleData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TitleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleData.Location = new System.Drawing.Point(419, 356);
            this.TitleData.Name = "TitleData";
            this.TitleData.Size = new System.Drawing.Size(242, 25);
            this.TitleData.TabIndex = 9;
            // 
            // ReleaseDateData
            // 
            this.ReleaseDateData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ReleaseDateData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReleaseDateData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateData.Location = new System.Drawing.Point(419, 381);
            this.ReleaseDateData.Name = "ReleaseDateData";
            this.ReleaseDateData.Size = new System.Drawing.Size(242, 25);
            this.ReleaseDateData.TabIndex = 10;
            // 
            // PublisherData
            // 
            this.PublisherData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PublisherData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PublisherData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PublisherData.Location = new System.Drawing.Point(419, 406);
            this.PublisherData.Name = "PublisherData";
            this.PublisherData.Size = new System.Drawing.Size(242, 25);
            this.PublisherData.TabIndex = 11;
            // 
            // DescriptionData
            // 
            this.DescriptionData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DescriptionData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionData.Location = new System.Drawing.Point(419, 431);
            this.DescriptionData.Multiline = true;
            this.DescriptionData.Name = "DescriptionData";
            this.DescriptionData.Size = new System.Drawing.Size(242, 34);
            this.DescriptionData.TabIndex = 12;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(325, 469);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(54, 14);
            this.CategoryLabel.TabIndex = 13;
            this.CategoryLabel.Text = "Category:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenreLabel.Location = new System.Drawing.Point(325, 494);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(40, 14);
            this.GenreLabel.TabIndex = 14;
            this.GenreLabel.Text = "Genre:";
            // 
            // CategoryData
            // 
            this.CategoryData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CategoryData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryData.Location = new System.Drawing.Point(419, 465);
            this.CategoryData.Name = "CategoryData";
            this.CategoryData.Size = new System.Drawing.Size(242, 25);
            this.CategoryData.TabIndex = 15;
            // 
            // GenreData
            // 
            this.GenreData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GenreData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenreData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenreData.Location = new System.Drawing.Point(419, 490);
            this.GenreData.Name = "GenreData";
            this.GenreData.Size = new System.Drawing.Size(242, 25);
            this.GenreData.TabIndex = 16;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(79)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.Location = new System.Drawing.Point(10, 73);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.Size = new System.Drawing.Size(281, 20);
            this.SearchBox.TabIndex = 17;
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(297, 75);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(18, 15);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowAllBooks
            // 
            this.ShowAllBooks.FlatAppearance.BorderSize = 2;
            this.ShowAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllBooks.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowAllBooks.Location = new System.Drawing.Point(10, 458);
            this.ShowAllBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowAllBooks.Name = "ShowAllBooks";
            this.ShowAllBooks.Size = new System.Drawing.Size(88, 22);
            this.ShowAllBooks.TabIndex = 19;
            this.ShowAllBooks.Text = "Show all books";
            this.ShowAllBooks.UseVisualStyleBackColor = true;
            this.ShowAllBooks.Click += new System.EventHandler(this.ShowAllBooks_Click);
            // 
            // booksFoundBox
            // 
            this.booksFoundBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(79)))));
            this.booksFoundBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booksFoundBox.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.booksFoundBox.FormattingEnabled = true;
            this.booksFoundBox.ItemHeight = 17;
            this.booksFoundBox.Location = new System.Drawing.Point(10, 106);
            this.booksFoundBox.Name = "booksFoundBox";
            this.booksFoundBox.Size = new System.Drawing.Size(281, 342);
            this.booksFoundBox.TabIndex = 20;
            this.booksFoundBox.SelectedIndexChanged += new System.EventHandler(this.BooksFoundBox_SelectedIndexChanged);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(919, 614);
            this.Controls.Add(this.ShowAllBooks);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.GenreData);
            this.Controls.Add(this.CategoryData);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.DescriptionData);
            this.Controls.Add(this.PublisherData);
            this.Controls.Add(this.ReleaseDateData);
            this.Controls.Add(this.TitleData);
            this.Controls.Add(this.AuthorData);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.BookPicture);
            this.Controls.Add(this.OperationsList);
            this.Controls.Add(this.booksBox);
            this.Controls.Add(this.booksFoundBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.OperationsList;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.OperationsList.ResumeLayout(false);
            this.OperationsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip OperationsList;
        private ToolStripMenuItem AddABookToolStripMenuItem;
        private ToolStripMenuItem RemoveABookToolStripMenuItem;
        private ToolStripMenuItem EditABookToolStripMenuItem;
        private ToolStripMenuItem GenerateListsOfBooksToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ListBox booksBox;
        private PictureBox BookPicture;
        private Label BookLabel;
        private Label AuthorLabel;
        private Label ReleaseDateLabel;
        private Label PublisherLabel;
        private Label DescriptionLabel;
        private TextBox AuthorData;
        private TextBox TitleData;
        private TextBox ReleaseDateData;
        private TextBox PublisherData;
        private TextBox DescriptionData;
        private Label CategoryLabel;
        private Label GenreLabel;
        private TextBox CategoryData;
        private TextBox GenreData;
        private TextBox SearchBox;
        private Button SearchButton;
        private Button ShowAllBooks;
        private ListBox booksFoundBox;
    }
}