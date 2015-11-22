namespace Biblioteka_db
{
    partial class Form1
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
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.booksItemSet1 = new Biblioteka_db.BooksItemSet();
            this.tabAdminUsers = new System.Windows.Forms.TabPage();
            this.tabAdminAuthors = new System.Windows.Forms.TabPage();
            this.dgvAuthors = new Biblioteka_db.AuthorsItemSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabLayout.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.tabAdminAuthors.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayout
            // 
            this.tabLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayout.Controls.Add(this.tabBooks);
            this.tabLayout.Controls.Add(this.tabAdminUsers);
            this.tabLayout.Controls.Add(this.tabAdminAuthors);
            this.tabLayout.Controls.Add(this.tabPage1);
            this.tabLayout.Location = new System.Drawing.Point(12, 12);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(1174, 726);
            this.tabLayout.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.booksItemSet1);
            this.tabBooks.Location = new System.Drawing.Point(4, 25);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(1166, 697);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Ksiązki";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // booksItemSet1
            // 
            this.booksItemSet1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksItemSet1.Location = new System.Drawing.Point(7, 7);
            this.booksItemSet1.Name = "booksItemSet1";
            this.booksItemSet1.Size = new System.Drawing.Size(1153, 684);
            this.booksItemSet1.TabIndex = 0;
            // 
            // tabAdminUsers
            // 
            this.tabAdminUsers.Location = new System.Drawing.Point(4, 25);
            this.tabAdminUsers.Name = "tabAdminUsers";
            this.tabAdminUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminUsers.Size = new System.Drawing.Size(1166, 697);
            this.tabAdminUsers.TabIndex = 1;
            this.tabAdminUsers.Text = "Użytkownicy";
            this.tabAdminUsers.UseVisualStyleBackColor = true;
            // 
            // tabAdminAuthors
            // 
            this.tabAdminAuthors.Controls.Add(this.dgvAuthors);
            this.tabAdminAuthors.Location = new System.Drawing.Point(4, 25);
            this.tabAdminAuthors.Name = "tabAdminAuthors";
            this.tabAdminAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminAuthors.Size = new System.Drawing.Size(1166, 697);
            this.tabAdminAuthors.TabIndex = 2;
            this.tabAdminAuthors.Text = "Autorzy";
            this.tabAdminAuthors.UseVisualStyleBackColor = true;
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.Location = new System.Drawing.Point(7, 7);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.Size = new System.Drawing.Size(1153, 684);
            this.dgvAuthors.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1166, 697);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "TESTOWA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Autorzy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodaj Książkę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "Kategorie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1108, 8);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 25);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "zaloguj";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 750);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tabLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabLayout.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabAdminAuthors.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabAdminUsers;
        private System.Windows.Forms.TabPage tabAdminAuthors;
        private BooksItemSet booksItemSet1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button5;
        private AuthorsItemSet dgvAuthors;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;









    }
}

