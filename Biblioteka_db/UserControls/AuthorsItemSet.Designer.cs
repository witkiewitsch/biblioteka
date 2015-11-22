namespace Biblioteka_db
{
    partial class AuthorsItemSet
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
            this.SuspendLayout();
            // 
            // AuthorsItemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AuthorsItemSet";
            this.SelectionChanged += new Biblioteka_db.delegateSelectionChanged(this.AuthorsItemSet_SelectionChanged);
            this.SubpageChanged += new Biblioteka_db.delegateSubpageChanged(this.AuthorsItemSet_SubpageChanged);
            this.RowsPerPageChanged += new Biblioteka_db.delegateSelectionChanged(this.AuthorsItemSet_RowsPerPageChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
