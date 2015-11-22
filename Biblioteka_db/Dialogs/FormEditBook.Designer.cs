namespace Biblioteka_db
{
    partial class FormEditBook
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
            this.gbNewBookData = new System.Windows.Forms.GroupBox();
            this.btnNewBookAddPicture = new System.Windows.Forms.Button();
            this.tbNewBookDescription = new System.Windows.Forms.TextBox();
            this.pbNewBookPicture = new System.Windows.Forms.PictureBox();
            this.tbNewBookReleaseYear = new System.Windows.Forms.TextBox();
            this.tbNewBookTitle = new System.Windows.Forms.TextBox();
            this.labHeaderPicture = new System.Windows.Forms.Label();
            this.labHeaderDescription = new System.Windows.Forms.Label();
            this.labHeaderReleaseYear = new System.Windows.Forms.Label();
            this.labHeaderTitle = new System.Windows.Forms.Label();
            this.bookCategories = new Biblioteka_db.CategoriesOfBookSimpleItemSet();
            this.bookAuthors = new Biblioteka_db.AutorsOfBookSimpleItemSet();
            this.gbNewBookData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewBookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewBookData
            // 
            this.gbNewBookData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewBookData.Controls.Add(this.btnNewBookAddPicture);
            this.gbNewBookData.Controls.Add(this.tbNewBookDescription);
            this.gbNewBookData.Controls.Add(this.pbNewBookPicture);
            this.gbNewBookData.Controls.Add(this.tbNewBookReleaseYear);
            this.gbNewBookData.Controls.Add(this.tbNewBookTitle);
            this.gbNewBookData.Controls.Add(this.labHeaderPicture);
            this.gbNewBookData.Controls.Add(this.labHeaderDescription);
            this.gbNewBookData.Controls.Add(this.labHeaderReleaseYear);
            this.gbNewBookData.Controls.Add(this.labHeaderTitle);
            this.gbNewBookData.Location = new System.Drawing.Point(12, 12);
            this.gbNewBookData.Name = "gbNewBookData";
            this.gbNewBookData.Size = new System.Drawing.Size(973, 446);
            this.gbNewBookData.TabIndex = 0;
            this.gbNewBookData.TabStop = false;
            this.gbNewBookData.Text = "Dane książki";
            // 
            // btnNewBookAddPicture
            // 
            this.btnNewBookAddPicture.Location = new System.Drawing.Point(9, 414);
            this.btnNewBookAddPicture.Name = "btnNewBookAddPicture";
            this.btnNewBookAddPicture.Size = new System.Drawing.Size(212, 26);
            this.btnNewBookAddPicture.TabIndex = 8;
            this.btnNewBookAddPicture.Text = "wybierz ilustrację";
            this.btnNewBookAddPicture.UseVisualStyleBackColor = true;
            // 
            // tbNewBookDescription
            // 
            this.tbNewBookDescription.Location = new System.Drawing.Point(237, 77);
            this.tbNewBookDescription.Multiline = true;
            this.tbNewBookDescription.Name = "tbNewBookDescription";
            this.tbNewBookDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNewBookDescription.Size = new System.Drawing.Size(730, 363);
            this.tbNewBookDescription.TabIndex = 7;
            this.tbNewBookDescription.TextChanged += new System.EventHandler(this.tbNewBookDescription_TextChanged);
            // 
            // pbNewBookPicture
            // 
            this.pbNewBookPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNewBookPicture.Location = new System.Drawing.Point(9, 109);
            this.pbNewBookPicture.Name = "pbNewBookPicture";
            this.pbNewBookPicture.Size = new System.Drawing.Size(212, 299);
            this.pbNewBookPicture.TabIndex = 6;
            this.pbNewBookPicture.TabStop = false;
            // 
            // tbNewBookReleaseYear
            // 
            this.tbNewBookReleaseYear.Location = new System.Drawing.Point(154, 49);
            this.tbNewBookReleaseYear.MaxLength = 4;
            this.tbNewBookReleaseYear.Name = "tbNewBookReleaseYear";
            this.tbNewBookReleaseYear.Size = new System.Drawing.Size(50, 22);
            this.tbNewBookReleaseYear.TabIndex = 5;
            this.tbNewBookReleaseYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNewBookReleaseYear.TextChanged += new System.EventHandler(this.tbNewBookReleaseYear_TextChanged);
            // 
            // tbNewBookTitle
            // 
            this.tbNewBookTitle.Location = new System.Drawing.Point(154, 21);
            this.tbNewBookTitle.Name = "tbNewBookTitle";
            this.tbNewBookTitle.Size = new System.Drawing.Size(813, 22);
            this.tbNewBookTitle.TabIndex = 4;
            this.tbNewBookTitle.TextChanged += new System.EventHandler(this.tbNewBookTitle_TextChanged);
            // 
            // labHeaderPicture
            // 
            this.labHeaderPicture.AutoSize = true;
            this.labHeaderPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderPicture.Location = new System.Drawing.Point(6, 80);
            this.labHeaderPicture.Name = "labHeaderPicture";
            this.labHeaderPicture.Size = new System.Drawing.Size(74, 17);
            this.labHeaderPicture.TabIndex = 3;
            this.labHeaderPicture.Text = "Ilustracja";
            // 
            // labHeaderDescription
            // 
            this.labHeaderDescription.AutoSize = true;
            this.labHeaderDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderDescription.Location = new System.Drawing.Point(234, 52);
            this.labHeaderDescription.Name = "labHeaderDescription";
            this.labHeaderDescription.Size = new System.Drawing.Size(122, 17);
            this.labHeaderDescription.TabIndex = 2;
            this.labHeaderDescription.Text = "Opis zawartości";
            // 
            // labHeaderReleaseYear
            // 
            this.labHeaderReleaseYear.AutoSize = true;
            this.labHeaderReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderReleaseYear.Location = new System.Drawing.Point(6, 52);
            this.labHeaderReleaseYear.Name = "labHeaderReleaseYear";
            this.labHeaderReleaseYear.Size = new System.Drawing.Size(99, 17);
            this.labHeaderReleaseYear.TabIndex = 1;
            this.labHeaderReleaseYear.Text = "Rok wydania";
            // 
            // labHeaderTitle
            // 
            this.labHeaderTitle.AutoSize = true;
            this.labHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderTitle.Location = new System.Drawing.Point(6, 24);
            this.labHeaderTitle.Name = "labHeaderTitle";
            this.labHeaderTitle.Size = new System.Drawing.Size(44, 17);
            this.labHeaderTitle.TabIndex = 0;
            this.labHeaderTitle.Text = "Tytuł";
            // 
            // bookCategories
            // 
            this.bookCategories.Location = new System.Drawing.Point(608, 464);
            this.bookCategories.MaximumSize = new System.Drawing.Size(1000, 600);
            this.bookCategories.MinimumSize = new System.Drawing.Size(318, 153);
            this.bookCategories.Name = "bookCategories";
            this.bookCategories.Size = new System.Drawing.Size(377, 185);
            this.bookCategories.TabIndex = 4;
            // 
            // bookAuthors
            // 
            this.bookAuthors.Location = new System.Drawing.Point(12, 464);
            this.bookAuthors.MaximumSize = new System.Drawing.Size(1000, 600);
            this.bookAuthors.MinimumSize = new System.Drawing.Size(318, 153);
            this.bookAuthors.Name = "bookAuthors";
            this.bookAuthors.Size = new System.Drawing.Size(590, 185);
            this.bookAuthors.TabIndex = 3;
            // 
            // FormEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 783);
            this.Controls.Add(this.bookCategories);
            this.Controls.Add(this.bookAuthors);
            this.Controls.Add(this.gbNewBookData);
            this.Name = "FormEditBook";
            this.Text = "Edycja książki";
            this.Load += new System.EventHandler(this.FormNewBook_Load);
            this.gbNewBookData.ResumeLayout(false);
            this.gbNewBookData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewBookPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewBookData;
        private System.Windows.Forms.Label labHeaderTitle;
        private System.Windows.Forms.Label labHeaderReleaseYear;
        private System.Windows.Forms.Label labHeaderDescription;
        private System.Windows.Forms.Label labHeaderPicture;
        private System.Windows.Forms.TextBox tbNewBookTitle;
        private System.Windows.Forms.TextBox tbNewBookReleaseYear;
        private System.Windows.Forms.PictureBox pbNewBookPicture;
        private System.Windows.Forms.TextBox tbNewBookDescription;
        private System.Windows.Forms.Button btnNewBookAddPicture;
        private AutorsOfBookSimpleItemSet bookAuthors;
        private CategoriesOfBookSimpleItemSet bookCategories;
    }
}