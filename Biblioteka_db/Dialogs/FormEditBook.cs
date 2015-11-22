using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_db
{
    public partial class FormEditBook : Form
    {
        private int bookID = 0;
        public FormEditBook()
        {
            InitializeComponent();
            /** temporary **/
            bookID = 1;
        }

        private void LoadNewBookMode() 
        {

        }
        private void LoadEditBookMode() 
        {
            using (BibliotekaDataContext db = new BibliotekaDataContext())
            {
                List<Autor> a = db.Autors.ToList();
                bookAuthors.LoadAuthorsOfBook(bookID);

                List<Kategoria> k = db.Kategorias.Where(x => x.kategoriaNadrzednaID == null).ToList();
                bookCategories.SetCategories(k);
            }
        }
        private void FormNewBook_Load(object sender, EventArgs e)
        {
            LoadEditBookMode();
        }

        private void tbNewBookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNewBookReleaseYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNewBookDescription_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
