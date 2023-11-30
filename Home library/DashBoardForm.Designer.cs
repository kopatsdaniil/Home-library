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
            this.SearchByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublishmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateListsOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksBox = new System.Windows.Forms.ListBox();
            this.BookPicture = new System.Windows.Forms.PictureBox();
            this.BookLabel = new System.Windows.Forms.Label();
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
            this.SearchByToolStripMenuItem,
            this.GenerateListsOfBooksToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.OperationsList.Location = new System.Drawing.Point(0, 0);
            this.OperationsList.Name = "OperationsList";
            this.OperationsList.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.OperationsList.Size = new System.Drawing.Size(1050, 60);
            this.OperationsList.TabIndex = 0;
            // 
            // AddABookToolStripMenuItem
            // 
            this.AddABookToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.AddABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddABookToolStripMenuItem.Image")));
            this.AddABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddABookToolStripMenuItem.Name = "AddABookToolStripMenuItem";
            this.AddABookToolStripMenuItem.Size = new System.Drawing.Size(151, 54);
            this.AddABookToolStripMenuItem.Text = "Add a book";
            this.AddABookToolStripMenuItem.Click += new System.EventHandler(this.AddABookToolStripMenuItem_Click);
            // 
            // RemoveABookToolStripMenuItem
            // 
            this.RemoveABookToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.RemoveABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveABookToolStripMenuItem.Image")));
            this.RemoveABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveABookToolStripMenuItem.Name = "RemoveABookToolStripMenuItem";
            this.RemoveABookToolStripMenuItem.Size = new System.Drawing.Size(177, 54);
            this.RemoveABookToolStripMenuItem.Text = "Remove a book";
            this.RemoveABookToolStripMenuItem.Click += new System.EventHandler(this.RemoveABookToolStripMenuItem_Click);
            // 
            // EditABookToolStripMenuItem
            // 
            this.EditABookToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.EditABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditABookToolStripMenuItem.Image")));
            this.EditABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditABookToolStripMenuItem.Name = "EditABookToolStripMenuItem";
            this.EditABookToolStripMenuItem.Size = new System.Drawing.Size(149, 54);
            this.EditABookToolStripMenuItem.Text = "Edit a book";
            // 
            // SearchByToolStripMenuItem
            // 
            this.SearchByToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.SearchByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorToolStripMenuItem,
            this.TitleToolStripMenuItem,
            this.PublishmentToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.GenreToolStripMenuItem});
            this.SearchByToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SearchByToolStripMenuItem.Image")));
            this.SearchByToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchByToolStripMenuItem.Name = "SearchByToolStripMenuItem";
            this.SearchByToolStripMenuItem.Size = new System.Drawing.Size(137, 54);
            this.SearchByToolStripMenuItem.Text = "Search by";
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.AuthorToolStripMenuItem.Text = "Author";
            // 
            // TitleToolStripMenuItem
            // 
            this.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem";
            this.TitleToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.TitleToolStripMenuItem.Text = "Title";
            // 
            // PublishmentToolStripMenuItem
            // 
            this.PublishmentToolStripMenuItem.Name = "PublishmentToolStripMenuItem";
            this.PublishmentToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.PublishmentToolStripMenuItem.Text = "Publishment";
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.CategoryToolStripMenuItem.Text = "Category";
            // 
            // GenreToolStripMenuItem
            // 
            this.GenreToolStripMenuItem.Name = "GenreToolStripMenuItem";
            this.GenreToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.GenreToolStripMenuItem.Text = "Genre";
            // 
            // GenerateListsOfBooksToolStripMenuItem
            // 
            this.GenerateListsOfBooksToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.GenerateListsOfBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GenerateListsOfBooksToolStripMenuItem.Image")));
            this.GenerateListsOfBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GenerateListsOfBooksToolStripMenuItem.Name = "GenerateListsOfBooksToolStripMenuItem";
            this.GenerateListsOfBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 54);
            this.GenerateListsOfBooksToolStripMenuItem.Text = "Generate lists of books";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(67, 54);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // booksBox
            // 
            this.booksBox.BackColor = System.Drawing.Color.SlateGray;
            this.booksBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksBox.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.booksBox.FormattingEnabled = true;
            this.booksBox.ItemHeight = 22;
            this.booksBox.Location = new System.Drawing.Point(12, 96);
            this.booksBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.booksBox.Name = "booksBox";
            this.booksBox.Size = new System.Drawing.Size(321, 528);
            this.booksBox.TabIndex = 1;
            this.booksBox.SelectedIndexChanged += new System.EventHandler(this.BooksBox_SelectedIndexChanged);
            // 
            // BookPicture
            // 
            this.BookPicture.Location = new System.Drawing.Point(371, 96);
            this.BookPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookPicture.Name = "BookPicture";
            this.BookPicture.Size = new System.Drawing.Size(191, 288);
            this.BookPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPicture.TabIndex = 2;
            this.BookPicture.TabStop = false;
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Location = new System.Drawing.Point(371, 406);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(46, 20);
            this.BookLabel.TabIndex = 3;
            this.BookLabel.Text = "Book:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.BookPicture);
            this.Controls.Add(this.booksBox);
            this.Controls.Add(this.OperationsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.OperationsList;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem SearchByToolStripMenuItem;
        private ToolStripMenuItem AuthorToolStripMenuItem;
        private ToolStripMenuItem TitleToolStripMenuItem;
        private ToolStripMenuItem PublishmentToolStripMenuItem;
        private ToolStripMenuItem CategoryToolStripMenuItem;
        private ToolStripMenuItem GenreToolStripMenuItem;
        private ToolStripMenuItem GenerateListsOfBooksToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ListBox booksBox;
        private PictureBox BookPicture;
        private Label BookLabel;
    }
}