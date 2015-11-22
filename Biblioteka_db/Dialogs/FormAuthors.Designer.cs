namespace Biblioteka_db
{
    partial class FormAuthors
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
            this.components = new System.ComponentModel.Container();
            this.gbSearchAuthors = new System.Windows.Forms.GroupBox();
            this.cbBirthYearAcceptNull = new System.Windows.Forms.CheckBox();
            this.btnSearchAuthors = new System.Windows.Forms.Button();
            this.labHeaderBetweenYears = new System.Windows.Forms.Label();
            this.tbBirthYearHighBound = new System.Windows.Forms.TextBox();
            this.cbBirthYearFilter = new System.Windows.Forms.CheckBox();
            this.tbBirthYearLowBound = new System.Windows.Forms.TextBox();
            this.cbMatchAlign = new System.Windows.Forms.ComboBox();
            this.cbMatchInAttribute = new System.Windows.Forms.ComboBox();
            this.labHeaderSearchedName = new System.Windows.Forms.Label();
            this.tbAuthorNameInfix = new System.Windows.Forms.TextBox();
            this.EPAuthors = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbHeaderActions = new System.Windows.Forms.GroupBox();
            this.btnEditSelectedAuthor = new System.Windows.Forms.Button();
            this.btnDeleteSelectedAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.dgvAuthors = new Biblioteka_db.AuthorsItemSet();
            this.gbSearchAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPAuthors)).BeginInit();
            this.gbHeaderActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchAuthors
            // 
            this.gbSearchAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchAuthors.Controls.Add(this.cbBirthYearAcceptNull);
            this.gbSearchAuthors.Controls.Add(this.btnSearchAuthors);
            this.gbSearchAuthors.Controls.Add(this.labHeaderBetweenYears);
            this.gbSearchAuthors.Controls.Add(this.tbBirthYearHighBound);
            this.gbSearchAuthors.Controls.Add(this.cbBirthYearFilter);
            this.gbSearchAuthors.Controls.Add(this.tbBirthYearLowBound);
            this.gbSearchAuthors.Controls.Add(this.cbMatchAlign);
            this.gbSearchAuthors.Controls.Add(this.cbMatchInAttribute);
            this.gbSearchAuthors.Controls.Add(this.labHeaderSearchedName);
            this.gbSearchAuthors.Controls.Add(this.tbAuthorNameInfix);
            this.gbSearchAuthors.Location = new System.Drawing.Point(12, 12);
            this.gbSearchAuthors.Name = "gbSearchAuthors";
            this.gbSearchAuthors.Size = new System.Drawing.Size(928, 83);
            this.gbSearchAuthors.TabIndex = 0;
            this.gbSearchAuthors.TabStop = false;
            this.gbSearchAuthors.Text = "Wyszykiwanie autorów";
            // 
            // cbBirthYearAcceptNull
            // 
            this.cbBirthYearAcceptNull.AutoSize = true;
            this.cbBirthYearAcceptNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbBirthYearAcceptNull.Location = new System.Drawing.Point(517, 53);
            this.cbBirthYearAcceptNull.Name = "cbBirthYearAcceptNull";
            this.cbBirthYearAcceptNull.Size = new System.Drawing.Size(192, 21);
            this.cbBirthYearAcceptNull.TabIndex = 7;
            this.cbBirthYearAcceptNull.Text = "uzględnij nieokreślony";
            this.cbBirthYearAcceptNull.UseVisualStyleBackColor = true;
            // 
            // btnSearchAuthors
            // 
            this.btnSearchAuthors.Location = new System.Drawing.Point(746, 50);
            this.btnSearchAuthors.Name = "btnSearchAuthors";
            this.btnSearchAuthors.Size = new System.Drawing.Size(176, 26);
            this.btnSearchAuthors.TabIndex = 1;
            this.btnSearchAuthors.Text = "szukaj autorów";
            this.btnSearchAuthors.UseVisualStyleBackColor = true;
            this.btnSearchAuthors.Click += new System.EventHandler(this.btnSearchAuthors_Click);
            // 
            // labHeaderBetweenYears
            // 
            this.labHeaderBetweenYears.AutoSize = true;
            this.labHeaderBetweenYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderBetweenYears.Location = new System.Drawing.Point(359, 54);
            this.labHeaderBetweenYears.Name = "labHeaderBetweenYears";
            this.labHeaderBetweenYears.Size = new System.Drawing.Size(26, 17);
            this.labHeaderBetweenYears.TabIndex = 8;
            this.labHeaderBetweenYears.Text = "do";
            // 
            // tbBirthYearHighBound
            // 
            this.tbBirthYearHighBound.Location = new System.Drawing.Point(392, 51);
            this.tbBirthYearHighBound.MaxLength = 4;
            this.tbBirthYearHighBound.Name = "tbBirthYearHighBound";
            this.tbBirthYearHighBound.Size = new System.Drawing.Size(69, 22);
            this.tbBirthYearHighBound.TabIndex = 6;
            this.tbBirthYearHighBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBirthYearHighBound.TextChanged += new System.EventHandler(this.tbBirthYearHighBound_TextChanged);
            // 
            // cbBirthYearFilter
            // 
            this.cbBirthYearFilter.AutoSize = true;
            this.cbBirthYearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbBirthYearFilter.Location = new System.Drawing.Point(9, 53);
            this.cbBirthYearFilter.Name = "cbBirthYearFilter";
            this.cbBirthYearFilter.Size = new System.Drawing.Size(220, 21);
            this.cbBirthYearFilter.TabIndex = 4;
            this.cbBirthYearFilter.Text = "ogranicz rok urodzenia od";
            this.cbBirthYearFilter.UseVisualStyleBackColor = true;
            // 
            // tbBirthYearLowBound
            // 
            this.tbBirthYearLowBound.Location = new System.Drawing.Point(235, 51);
            this.tbBirthYearLowBound.MaxLength = 4;
            this.tbBirthYearLowBound.Name = "tbBirthYearLowBound";
            this.tbBirthYearLowBound.Size = new System.Drawing.Size(69, 22);
            this.tbBirthYearLowBound.TabIndex = 5;
            this.tbBirthYearLowBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBirthYearLowBound.TextChanged += new System.EventHandler(this.tbBirthYearLowBound_TextChanged);
            // 
            // cbMatchAlign
            // 
            this.cbMatchAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatchAlign.FormattingEnabled = true;
            this.cbMatchAlign.Items.AddRange(new object[] {
            "zawiera",
            "zaczyna się od",
            "kończy się na"});
            this.cbMatchAlign.Location = new System.Drawing.Point(383, 21);
            this.cbMatchAlign.Name = "cbMatchAlign";
            this.cbMatchAlign.Size = new System.Drawing.Size(159, 24);
            this.cbMatchAlign.TabIndex = 3;
            // 
            // cbMatchInAttribute
            // 
            this.cbMatchInAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatchInAttribute.FormattingEnabled = true;
            this.cbMatchInAttribute.Items.AddRange(new object[] {
            "nazwisko",
            "imię i nazwisko",
            "imię"});
            this.cbMatchInAttribute.Location = new System.Drawing.Point(201, 21);
            this.cbMatchInAttribute.Name = "cbMatchInAttribute";
            this.cbMatchInAttribute.Size = new System.Drawing.Size(159, 24);
            this.cbMatchInAttribute.TabIndex = 2;
            // 
            // labHeaderSearchedName
            // 
            this.labHeaderSearchedName.AutoSize = true;
            this.labHeaderSearchedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderSearchedName.Location = new System.Drawing.Point(6, 24);
            this.labHeaderSearchedName.Name = "labHeaderSearchedName";
            this.labHeaderSearchedName.Size = new System.Drawing.Size(177, 17);
            this.labHeaderSearchedName.TabIndex = 1;
            this.labHeaderSearchedName.Text = "Pokaż autorów, których";
            // 
            // tbAuthorNameInfix
            // 
            this.tbAuthorNameInfix.Location = new System.Drawing.Point(579, 22);
            this.tbAuthorNameInfix.Name = "tbAuthorNameInfix";
            this.tbAuthorNameInfix.Size = new System.Drawing.Size(343, 22);
            this.tbAuthorNameInfix.TabIndex = 0;
            this.tbAuthorNameInfix.TextChanged += new System.EventHandler(this.tbAuthorNameInfix_TextChanged);
            // 
            // EPAuthors
            // 
            this.EPAuthors.ContainerControl = this;
            // 
            // gbHeaderActions
            // 
            this.gbHeaderActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeaderActions.Controls.Add(this.btnEditSelectedAuthor);
            this.gbHeaderActions.Controls.Add(this.btnDeleteSelectedAuthor);
            this.gbHeaderActions.Controls.Add(this.btnAddAuthor);
            this.gbHeaderActions.Location = new System.Drawing.Point(12, 607);
            this.gbHeaderActions.Name = "gbHeaderActions";
            this.gbHeaderActions.Size = new System.Drawing.Size(928, 53);
            this.gbHeaderActions.TabIndex = 9;
            this.gbHeaderActions.TabStop = false;
            this.gbHeaderActions.Text = "Akcje";
            // 
            // btnEditSelectedAuthor
            // 
            this.btnEditSelectedAuthor.Location = new System.Drawing.Point(620, 21);
            this.btnEditSelectedAuthor.Name = "btnEditSelectedAuthor";
            this.btnEditSelectedAuthor.Size = new System.Drawing.Size(301, 26);
            this.btnEditSelectedAuthor.TabIndex = 11;
            this.btnEditSelectedAuthor.Text = "edytuj wybranego autora";
            this.btnEditSelectedAuthor.UseVisualStyleBackColor = true;
            this.btnEditSelectedAuthor.Click += new System.EventHandler(this.btnEditSelectedAuthor_Click);
            // 
            // btnDeleteSelectedAuthor
            // 
            this.btnDeleteSelectedAuthor.Location = new System.Drawing.Point(313, 21);
            this.btnDeleteSelectedAuthor.Name = "btnDeleteSelectedAuthor";
            this.btnDeleteSelectedAuthor.Size = new System.Drawing.Size(301, 26);
            this.btnDeleteSelectedAuthor.TabIndex = 10;
            this.btnDeleteSelectedAuthor.Text = "usuń wybranego autora";
            this.btnDeleteSelectedAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedAuthor.Click += new System.EventHandler(this.btnDeleteSelectedAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(6, 21);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(301, 26);
            this.btnAddAuthor.TabIndex = 9;
            this.btnAddAuthor.Text = "dodaj nowego autora";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOK.Enabled = false;
            this.ButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOK.Location = new System.Drawing.Point(12, 676);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(461, 35);
            this.ButtonOK.TabIndex = 12;
            this.ButtonOK.Text = "Wybierz";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonClose.Location = new System.Drawing.Point(479, 676);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(461, 35);
            this.ButtonClose.TabIndex = 13;
            this.ButtonClose.Text = "Zamknij";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuthors.Location = new System.Drawing.Point(12, 101);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.Size = new System.Drawing.Size(928, 500);
            this.dgvAuthors.TabIndex = 8;
            this.dgvAuthors.SelectionChanged += new Biblioteka_db.delegateSelectionChanged(this.dgvAuthors_SelectionChanged);
            this.dgvAuthors.SubpageChanged += new Biblioteka_db.delegateSubpageChanged(this.dgvAuthors_SubpageChanged);
            this.dgvAuthors.RowsPerPageChanged += new Biblioteka_db.delegateSelectionChanged(this.dgvAuthors_RowsPerPageChanged);
            // 
            // FormAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 725);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.gbHeaderActions);
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.gbSearchAuthors);
            this.MaximumSize = new System.Drawing.Size(1940, 1570);
            this.MinimumSize = new System.Drawing.Size(970, 770);
            this.Name = "FormAuthors";
            this.Text = "Autorzy";
            this.Load += new System.EventHandler(this.FormAuthors_Load);
            this.gbSearchAuthors.ResumeLayout(false);
            this.gbSearchAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPAuthors)).EndInit();
            this.gbHeaderActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchAuthors;
        private System.Windows.Forms.Label labHeaderSearchedName;
        private System.Windows.Forms.TextBox tbAuthorNameInfix;
        private System.Windows.Forms.ComboBox cbMatchInAttribute;
        private System.Windows.Forms.ComboBox cbMatchAlign;
        private System.Windows.Forms.TextBox tbBirthYearLowBound;
        private System.Windows.Forms.CheckBox cbBirthYearFilter;
        private System.Windows.Forms.TextBox tbBirthYearHighBound;
        private System.Windows.Forms.Label labHeaderBetweenYears;
        private System.Windows.Forms.CheckBox cbBirthYearAcceptNull;
        private System.Windows.Forms.Button btnSearchAuthors;
        private AuthorsItemSet dgvAuthors;
        private System.Windows.Forms.ErrorProvider EPAuthors;
        private System.Windows.Forms.GroupBox gbHeaderActions;
        private System.Windows.Forms.Button btnEditSelectedAuthor;
        private System.Windows.Forms.Button btnDeleteSelectedAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonOK;

    }
}