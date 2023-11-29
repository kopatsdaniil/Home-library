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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddABookToolStripMenuItem,
            this.RemoveABookToolStripMenuItem,
            this.EditABookToolStripMenuItem,
            this.SearchByToolStripMenuItem,
            this.GenerateListsOfBooksToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 58);
            this.menuStrip1.TabIndex = 0;
            // 
            // AddABookToolStripMenuItem
            // 
            this.AddABookToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.AddABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddABookToolStripMenuItem.Image")));
            this.AddABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddABookToolStripMenuItem.Name = "AddABookToolStripMenuItem";
            this.AddABookToolStripMenuItem.Size = new System.Drawing.Size(130, 54);
            this.AddABookToolStripMenuItem.Text = "Add a book";
            this.AddABookToolStripMenuItem.Click += new System.EventHandler(this.AddABookToolStripMenuItem_Click);
            // 
            // RemoveABookToolStripMenuItem
            // 
            this.RemoveABookToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.RemoveABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveABookToolStripMenuItem.Image")));
            this.RemoveABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveABookToolStripMenuItem.Name = "RemoveABookToolStripMenuItem";
            this.RemoveABookToolStripMenuItem.Size = new System.Drawing.Size(151, 54);
            this.RemoveABookToolStripMenuItem.Text = "Remove a book";
            this.RemoveABookToolStripMenuItem.Click += new System.EventHandler(this.RemoveABookToolStripMenuItem_Click);
            // 
            // EditABookToolStripMenuItem
            // 
            this.EditABookToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.EditABookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditABookToolStripMenuItem.Image")));
            this.EditABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditABookToolStripMenuItem.Name = "EditABookToolStripMenuItem";
            this.EditABookToolStripMenuItem.Size = new System.Drawing.Size(128, 54);
            this.EditABookToolStripMenuItem.Text = "Edit a book";
            // 
            // SearchByToolStripMenuItem
            // 
            this.SearchByToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.SearchByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorToolStripMenuItem,
            this.TitleToolStripMenuItem,
            this.PublishmentToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.GenreToolStripMenuItem});
            this.SearchByToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SearchByToolStripMenuItem.Image")));
            this.SearchByToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchByToolStripMenuItem.Name = "SearchByToolStripMenuItem";
            this.SearchByToolStripMenuItem.Size = new System.Drawing.Size(120, 54);
            this.SearchByToolStripMenuItem.Text = "Search by";
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.AuthorToolStripMenuItem.Text = "Author";
            // 
            // TitleToolStripMenuItem
            // 
            this.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem";
            this.TitleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.TitleToolStripMenuItem.Text = "Title";
            // 
            // PublishmentToolStripMenuItem
            // 
            this.PublishmentToolStripMenuItem.Name = "PublishmentToolStripMenuItem";
            this.PublishmentToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.PublishmentToolStripMenuItem.Text = "Publishment";
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.CategoryToolStripMenuItem.Text = "Category";
            // 
            // GenreToolStripMenuItem
            // 
            this.GenreToolStripMenuItem.Name = "GenreToolStripMenuItem";
            this.GenreToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.GenreToolStripMenuItem.Text = "Genre";
            // 
            // GenerateListsOfBooksToolStripMenuItem
            // 
            this.GenerateListsOfBooksToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.GenerateListsOfBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GenerateListsOfBooksToolStripMenuItem.Image")));
            this.GenerateListsOfBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GenerateListsOfBooksToolStripMenuItem.Name = "GenerateListsOfBooksToolStripMenuItem";
            this.GenerateListsOfBooksToolStripMenuItem.Size = new System.Drawing.Size(188, 54);
            this.GenerateListsOfBooksToolStripMenuItem.Text = "Generate lists of books";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(54, 54);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // booksBox
            // 
            this.booksBox.FormattingEnabled = true;
            this.booksBox.ItemHeight = 15;
            this.booksBox.Location = new System.Drawing.Point(12, 137);
            this.booksBox.Name = "booksBox";
            this.booksBox.Size = new System.Drawing.Size(198, 409);
            this.booksBox.TabIndex = 1;
            this.booksBox.SelectedIndexChanged += new System.EventHandler(this.booksBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(325, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 216);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(915, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.booksBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
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
        private PictureBox pictureBox1;
        private Label label1;
    }
}