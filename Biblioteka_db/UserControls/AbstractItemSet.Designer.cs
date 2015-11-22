namespace Biblioteka_db
{
    partial class AbstractItemSet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.labHeaderSubpage = new System.Windows.Forms.Label();
            this.labHeaderRowsPerPage = new System.Windows.Forms.Label();
            this.cbRowsPerPage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv.ColumnHeadersHeight = 25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(4, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.ShowCellErrors = false;
            this.dgv.ShowCellToolTips = false;
            this.dgv.ShowEditingIcon = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(696, 525);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.SizeChanged += new System.EventHandler(this.dgv_SizeChanged);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Location = new System.Drawing.Point(242, 535);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.TabStop = false;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLast.Location = new System.Drawing.Point(283, 535);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 23);
            this.btnLast.TabIndex = 2;
            this.btnLast.TabStop = false;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFirst.Location = new System.Drawing.Point(4, 535);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(35, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.TabStop = false;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrev.Location = new System.Drawing.Point(45, 535);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.TabStop = false;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // labHeaderSubpage
            // 
            this.labHeaderSubpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labHeaderSubpage.AutoSize = true;
            this.labHeaderSubpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHeaderSubpage.Location = new System.Drawing.Point(86, 538);
            this.labHeaderSubpage.MaximumSize = new System.Drawing.Size(150, 17);
            this.labHeaderSubpage.MinimumSize = new System.Drawing.Size(150, 17);
            this.labHeaderSubpage.Name = "labHeaderSubpage";
            this.labHeaderSubpage.Size = new System.Drawing.Size(150, 17);
            this.labHeaderSubpage.TabIndex = 4;
            this.labHeaderSubpage.Text = "podstrona nr 1";
            this.labHeaderSubpage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHeaderRowsPerPage
            // 
            this.labHeaderRowsPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labHeaderRowsPerPage.AutoSize = true;
            this.labHeaderRowsPerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHeaderRowsPerPage.Location = new System.Drawing.Point(468, 538);
            this.labHeaderRowsPerPage.MaximumSize = new System.Drawing.Size(150, 17);
            this.labHeaderRowsPerPage.MinimumSize = new System.Drawing.Size(150, 17);
            this.labHeaderRowsPerPage.Name = "labHeaderRowsPerPage";
            this.labHeaderRowsPerPage.Size = new System.Drawing.Size(150, 17);
            this.labHeaderRowsPerPage.TabIndex = 5;
            this.labHeaderRowsPerPage.Text = "wyników na stronę:";
            this.labHeaderRowsPerPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRowsPerPage
            // 
            this.cbRowsPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRowsPerPage.DisplayMember = "0";
            this.cbRowsPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRowsPerPage.FormattingEnabled = true;
            this.cbRowsPerPage.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "50",
            "100",
            "200"});
            this.cbRowsPerPage.Location = new System.Drawing.Point(624, 535);
            this.cbRowsPerPage.Name = "cbRowsPerPage";
            this.cbRowsPerPage.Size = new System.Drawing.Size(76, 24);
            this.cbRowsPerPage.TabIndex = 6;
            this.cbRowsPerPage.TabStop = false;
            this.cbRowsPerPage.SelectedIndexChanged += new System.EventHandler(this.cbRowsPerPage_SelectedIndexChanged);
            // 
            // AbstractItemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbRowsPerPage);
            this.Controls.Add(this.labHeaderRowsPerPage);
            this.Controls.Add(this.labHeaderSubpage);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgv);
            this.Name = "AbstractItemSet";
            this.Size = new System.Drawing.Size(703, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label labHeaderSubpage;
        private System.Windows.Forms.Label labHeaderRowsPerPage;
        private System.Windows.Forms.ComboBox cbRowsPerPage;
    }
}
