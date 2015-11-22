using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace Biblioteka_db
{
    public partial class Form1 : Form
    {

        private FormAuthors formAuthors = new FormAuthors();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            FormLogin flogin = new FormLogin();
//            flogin.ShowDialog();
            List<Autor> authors = (new BibliotekaDataContext()).Autors.OrderBy(x => x.id).ToList();
            dgvAuthors.AttachNewData(authors);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormEditBook formNewBook = new FormEditBook();
            formNewBook.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formAuthors.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories();
            if (formCategories.ShowDialog() == DialogResult.OK) 
            {
                MessageBox.Show("Wybrana kategoria: " + formCategories.SelectedCategoryName + "[" + formCategories.SelectedCategoryID.ToString() + "]");
            }
        }

    }
}
