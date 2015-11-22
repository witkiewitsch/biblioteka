namespace Biblioteka_db
{
    partial class FormEditAuthor
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
            this.labHeaderFirstname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.labHeaderSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.labHeaderBirthYear = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.EPNewAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EPNewAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // labHeaderFirstname
            // 
            this.labHeaderFirstname.AutoSize = true;
            this.labHeaderFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderFirstname.Location = new System.Drawing.Point(12, 15);
            this.labHeaderFirstname.Name = "labHeaderFirstname";
            this.labHeaderFirstname.Size = new System.Drawing.Size(37, 17);
            this.labHeaderFirstname.TabIndex = 0;
            this.labHeaderFirstname.Text = "Imię";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(165, 12);
            this.tbFirstname.MaxLength = 30;
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(454, 22);
            this.tbFirstname.TabIndex = 1;
            this.tbFirstname.TextChanged += new System.EventHandler(this.tbFirstname_TextChanged);
            // 
            // labHeaderSurname
            // 
            this.labHeaderSurname.AutoSize = true;
            this.labHeaderSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderSurname.Location = new System.Drawing.Point(12, 43);
            this.labHeaderSurname.Name = "labHeaderSurname";
            this.labHeaderSurname.Size = new System.Drawing.Size(75, 17);
            this.labHeaderSurname.TabIndex = 2;
            this.labHeaderSurname.Text = "Nazwisko";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(165, 40);
            this.tbSurname.MaxLength = 70;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(454, 22);
            this.tbSurname.TabIndex = 3;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.Location = new System.Drawing.Point(165, 68);
            this.tbBirthYear.MaxLength = 70;
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(55, 22);
            this.tbBirthYear.TabIndex = 4;
            this.tbBirthYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBirthYear.TextChanged += new System.EventHandler(this.tbBirthYear_TextChanged);
            // 
            // labHeaderBirthYear
            // 
            this.labHeaderBirthYear.AutoSize = true;
            this.labHeaderBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labHeaderBirthYear.Location = new System.Drawing.Point(12, 71);
            this.labHeaderBirthYear.Name = "labHeaderBirthYear";
            this.labHeaderBirthYear.Size = new System.Drawing.Size(113, 17);
            this.labHeaderBirthYear.TabIndex = 5;
            this.labHeaderBirthYear.Text = "Rok urodzenia";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdd.Location = new System.Drawing.Point(15, 106);
            this.ButtonAdd.MaximumSize = new System.Drawing.Size(299, 35);
            this.ButtonAdd.MinimumSize = new System.Drawing.Size(299, 35);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(299, 35);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "Dodaj";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancel.Location = new System.Drawing.Point(320, 106);
            this.ButtonCancel.MaximumSize = new System.Drawing.Size(299, 35);
            this.ButtonCancel.MinimumSize = new System.Drawing.Size(299, 35);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(299, 35);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Anuluj";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // EPNewAuthor
            // 
            this.EPNewAuthor.ContainerControl = this;
            // 
            // FormEditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 151);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labHeaderBirthYear);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.labHeaderSurname);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.labHeaderFirstname);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(649, 196);
            this.MinimumSize = new System.Drawing.Size(649, 196);
            this.Name = "FormEditAuthor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Nowy autor";
            this.Load += new System.EventHandler(this.FormEditAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPNewAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHeaderFirstname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label labHeaderSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbBirthYear;
        private System.Windows.Forms.Label labHeaderBirthYear;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ErrorProvider EPNewAuthor;
    }
}