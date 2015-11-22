namespace Biblioteka_db
{
    partial class FormCategories
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
            this.gbNewCategory = new System.Windows.Forms.GroupBox();
            this.btnAddNewRootCategory = new System.Windows.Forms.Button();
            this.labHeaderNewCategoryName = new System.Windows.Forms.Label();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.tbNewCategoryName = new System.Windows.Forms.TextBox();
            this.gpDeleteSelectedCategory = new System.Windows.Forms.GroupBox();
            this.cbSubCatsDecision = new System.Windows.Forms.ComboBox();
            this.labHeaderSubCatsDecision = new System.Windows.Forms.Label();
            this.btnDeleteSelectedCategory = new System.Windows.Forms.Button();
            this.labSelectedCategoryName = new System.Windows.Forms.Label();
            this.labHeaderSelectedCategory = new System.Windows.Forms.Label();
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.EPCategories = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRenameSelectedCategory = new System.Windows.Forms.GroupBox();
            this.labNewName = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btnRenameSelectedCategory = new System.Windows.Forms.Button();
            this.gbNewCategory.SuspendLayout();
            this.gpDeleteSelectedCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPCategories)).BeginInit();
            this.gbRenameSelectedCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewCategory
            // 
            this.gbNewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewCategory.Controls.Add(this.btnAddNewRootCategory);
            this.gbNewCategory.Controls.Add(this.labHeaderNewCategoryName);
            this.gbNewCategory.Controls.Add(this.btnAddNewCategory);
            this.gbNewCategory.Controls.Add(this.tbNewCategoryName);
            this.gbNewCategory.Location = new System.Drawing.Point(12, 546);
            this.gbNewCategory.MaximumSize = new System.Drawing.Size(1166, 85);
            this.gbNewCategory.MinimumSize = new System.Drawing.Size(583, 85);
            this.gbNewCategory.Name = "gbNewCategory";
            this.gbNewCategory.Size = new System.Drawing.Size(583, 85);
            this.gbNewCategory.TabIndex = 3;
            this.gbNewCategory.TabStop = false;
            this.gbNewCategory.Text = "Dodaj kategorię";
            // 
            // btnAddNewRootCategory
            // 
            this.btnAddNewRootCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewRootCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewRootCategory.Location = new System.Drawing.Point(295, 49);
            this.btnAddNewRootCategory.Name = "btnAddNewRootCategory";
            this.btnAddNewRootCategory.Size = new System.Drawing.Size(281, 26);
            this.btnAddNewRootCategory.TabIndex = 5;
            this.btnAddNewRootCategory.Text = "Dodaj kategorię główną";
            this.btnAddNewRootCategory.UseVisualStyleBackColor = true;
            this.btnAddNewRootCategory.Click += new System.EventHandler(this.btnAddNewRootCategory_Click);
            // 
            // labHeaderNewCategoryName
            // 
            this.labHeaderNewCategoryName.AutoSize = true;
            this.labHeaderNewCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHeaderNewCategoryName.Location = new System.Drawing.Point(6, 24);
            this.labHeaderNewCategoryName.Name = "labHeaderNewCategoryName";
            this.labHeaderNewCategoryName.Size = new System.Drawing.Size(169, 17);
            this.labHeaderNewCategoryName.TabIndex = 10;
            this.labHeaderNewCategoryName.Text = "Nazwa nowej kategorii";
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewCategory.Location = new System.Drawing.Point(9, 49);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(281, 26);
            this.btnAddNewCategory.TabIndex = 4;
            this.btnAddNewCategory.Text = "Dodaj podkategorię";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // tbNewCategoryName
            // 
            this.tbNewCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewCategoryName.Location = new System.Drawing.Point(222, 21);
            this.tbNewCategoryName.Name = "tbNewCategoryName";
            this.tbNewCategoryName.Size = new System.Drawing.Size(355, 22);
            this.tbNewCategoryName.TabIndex = 3;
            this.tbNewCategoryName.TextChanged += new System.EventHandler(this.tbNewCategoryName_TextChanged);
            // 
            // gpDeleteSelectedCategory
            // 
            this.gpDeleteSelectedCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDeleteSelectedCategory.Controls.Add(this.cbSubCatsDecision);
            this.gpDeleteSelectedCategory.Controls.Add(this.labHeaderSubCatsDecision);
            this.gpDeleteSelectedCategory.Controls.Add(this.btnDeleteSelectedCategory);
            this.gpDeleteSelectedCategory.Location = new System.Drawing.Point(12, 637);
            this.gpDeleteSelectedCategory.MaximumSize = new System.Drawing.Size(1166, 53);
            this.gpDeleteSelectedCategory.MinimumSize = new System.Drawing.Size(583, 53);
            this.gpDeleteSelectedCategory.Name = "gpDeleteSelectedCategory";
            this.gpDeleteSelectedCategory.Size = new System.Drawing.Size(583, 53);
            this.gpDeleteSelectedCategory.TabIndex = 6;
            this.gpDeleteSelectedCategory.TabStop = false;
            this.gpDeleteSelectedCategory.Text = "Usuń zaznaczoną kategorię";
            // 
            // cbSubCatsDecision
            // 
            this.cbSubCatsDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubCatsDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCatsDecision.FormattingEnabled = true;
            this.cbSubCatsDecision.Items.AddRange(new object[] {
            "przenieś do nadrzędnej",
            "usuń"});
            this.cbSubCatsDecision.Location = new System.Drawing.Point(295, 21);
            this.cbSubCatsDecision.Name = "cbSubCatsDecision";
            this.cbSubCatsDecision.Size = new System.Drawing.Size(281, 24);
            this.cbSubCatsDecision.TabIndex = 7;
            // 
            // labHeaderSubCatsDecision
            // 
            this.labHeaderSubCatsDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labHeaderSubCatsDecision.AutoSize = true;
            this.labHeaderSubCatsDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHeaderSubCatsDecision.Location = new System.Drawing.Point(138, 24);
            this.labHeaderSubCatsDecision.Name = "labHeaderSubCatsDecision";
            this.labHeaderSubCatsDecision.Size = new System.Drawing.Size(104, 17);
            this.labHeaderSubCatsDecision.TabIndex = 10;
            this.labHeaderSubCatsDecision.Text = "Podkategorie";
            // 
            // btnDeleteSelectedCategory
            // 
            this.btnDeleteSelectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteSelectedCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteSelectedCategory.Location = new System.Drawing.Point(9, 21);
            this.btnDeleteSelectedCategory.Name = "btnDeleteSelectedCategory";
            this.btnDeleteSelectedCategory.Size = new System.Drawing.Size(108, 26);
            this.btnDeleteSelectedCategory.TabIndex = 6;
            this.btnDeleteSelectedCategory.Text = "Usuń";
            this.btnDeleteSelectedCategory.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedCategory.Click += new System.EventHandler(this.btnDeleteSelectedCategory_Click);
            // 
            // labSelectedCategoryName
            // 
            this.labSelectedCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSelectedCategoryName.AutoSize = true;
            this.labSelectedCategoryName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labSelectedCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labSelectedCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSelectedCategoryName.Location = new System.Drawing.Point(240, 9);
            this.labSelectedCategoryName.MaximumSize = new System.Drawing.Size(460, 19);
            this.labSelectedCategoryName.MinimumSize = new System.Drawing.Size(355, 19);
            this.labSelectedCategoryName.Name = "labSelectedCategoryName";
            this.labSelectedCategoryName.Size = new System.Drawing.Size(355, 19);
            this.labSelectedCategoryName.TabIndex = 10;
            // 
            // labHeaderSelectedCategory
            // 
            this.labHeaderSelectedCategory.AutoSize = true;
            this.labHeaderSelectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHeaderSelectedCategory.Location = new System.Drawing.Point(12, 9);
            this.labHeaderSelectedCategory.Name = "labHeaderSelectedCategory";
            this.labHeaderSelectedCategory.Size = new System.Drawing.Size(150, 17);
            this.labHeaderSelectedCategory.TabIndex = 10;
            this.labHeaderSelectedCategory.Text = "Wybrana kategoria:";
            // 
            // tvCategories
            // 
            this.tvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvCategories.Location = new System.Drawing.Point(12, 40);
            this.tvCategories.MaximumSize = new System.Drawing.Size(1166, 1000);
            this.tvCategories.MinimumSize = new System.Drawing.Size(583, 500);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.Size = new System.Drawing.Size(583, 500);
            this.tvCategories.TabIndex = 0;
            this.tvCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategories_AfterSelect);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOK.Location = new System.Drawing.Point(12, 763);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(289, 35);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancel.Location = new System.Drawing.Point(307, 763);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(289, 35);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Anuluj";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // EPCategories
            // 
            this.EPCategories.ContainerControl = this;
            // 
            // gbRenameSelectedCategory
            // 
            this.gbRenameSelectedCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRenameSelectedCategory.Controls.Add(this.labNewName);
            this.gbRenameSelectedCategory.Controls.Add(this.tbNewName);
            this.gbRenameSelectedCategory.Controls.Add(this.btnRenameSelectedCategory);
            this.gbRenameSelectedCategory.Location = new System.Drawing.Point(12, 696);
            this.gbRenameSelectedCategory.MaximumSize = new System.Drawing.Size(1166, 53);
            this.gbRenameSelectedCategory.MinimumSize = new System.Drawing.Size(583, 53);
            this.gbRenameSelectedCategory.Name = "gbRenameSelectedCategory";
            this.gbRenameSelectedCategory.Size = new System.Drawing.Size(583, 53);
            this.gbRenameSelectedCategory.TabIndex = 8;
            this.gbRenameSelectedCategory.TabStop = false;
            this.gbRenameSelectedCategory.Text = "Zmień nazwę zaznaczonej kategorii";
            // 
            // labNewName
            // 
            this.labNewName.AutoSize = true;
            this.labNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labNewName.Location = new System.Drawing.Point(6, 26);
            this.labNewName.Name = "labNewName";
            this.labNewName.Size = new System.Drawing.Size(97, 17);
            this.labNewName.TabIndex = 10;
            this.labNewName.Text = "Nowa nazwa";
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(141, 23);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(321, 22);
            this.tbNewName.TabIndex = 8;
            this.tbNewName.TextChanged += new System.EventHandler(this.tbNewName_TextChanged);
            // 
            // btnRenameSelectedCategory
            // 
            this.btnRenameSelectedCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenameSelectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRenameSelectedCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRenameSelectedCategory.Location = new System.Drawing.Point(469, 21);
            this.btnRenameSelectedCategory.Name = "btnRenameSelectedCategory";
            this.btnRenameSelectedCategory.Size = new System.Drawing.Size(108, 26);
            this.btnRenameSelectedCategory.TabIndex = 9;
            this.btnRenameSelectedCategory.Text = "Zmień nazwę";
            this.btnRenameSelectedCategory.UseVisualStyleBackColor = true;
            this.btnRenameSelectedCategory.Click += new System.EventHandler(this.btnRenameSelectedCategory_Click);
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 810);
            this.Controls.Add(this.gbRenameSelectedCategory);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.labSelectedCategoryName);
            this.Controls.Add(this.tvCategories);
            this.Controls.Add(this.labHeaderSelectedCategory);
            this.Controls.Add(this.gpDeleteSelectedCategory);
            this.Controls.Add(this.gbNewCategory);
            this.MaximumSize = new System.Drawing.Size(1208, 1350);
            this.MinimumSize = new System.Drawing.Size(625, 855);
            this.Name = "FormCategories";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Kategorie";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            this.gbNewCategory.ResumeLayout(false);
            this.gbNewCategory.PerformLayout();
            this.gpDeleteSelectedCategory.ResumeLayout(false);
            this.gpDeleteSelectedCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPCategories)).EndInit();
            this.gbRenameSelectedCategory.ResumeLayout(false);
            this.gbRenameSelectedCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewCategory;
        private System.Windows.Forms.TextBox tbNewCategoryName;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnAddNewRootCategory;
        private System.Windows.Forms.Label labHeaderNewCategoryName;
        private System.Windows.Forms.GroupBox gpDeleteSelectedCategory;
        private System.Windows.Forms.Button btnDeleteSelectedCategory;
        private System.Windows.Forms.Label labSelectedCategoryName;
        private System.Windows.Forms.Label labHeaderSelectedCategory;
        private System.Windows.Forms.Label labHeaderSubCatsDecision;
        private System.Windows.Forms.ComboBox cbSubCatsDecision;
        private System.Windows.Forms.TreeView tvCategories;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ErrorProvider EPCategories;
        private System.Windows.Forms.GroupBox gbRenameSelectedCategory;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Button btnRenameSelectedCategory;
        private System.Windows.Forms.Label labNewName;
    }
}