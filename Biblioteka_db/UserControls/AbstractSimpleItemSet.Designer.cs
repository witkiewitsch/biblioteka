namespace Biblioteka_db
{
    partial class AbstractSimpleItemSet
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.contentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentColumn});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(3, 3);
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
            this.dgv.Size = new System.Drawing.Size(312, 175);
            this.dgv.TabIndex = 1;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(3, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(162, 184);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 26);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "usuń zaznaczony";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // contentColumn
            // 
            this.contentColumn.HeaderText = "";
            this.contentColumn.Name = "contentColumn";
            this.contentColumn.ReadOnly = true;
            this.contentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AbstractSimpleItemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(318, 153);
            this.Name = "AbstractSimpleItemSet";
            this.Size = new System.Drawing.Size(318, 213);
            this.SizeChanged += new System.EventHandler(this.AbstractSimpleItemSet_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgv;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentColumn;
    }
}
