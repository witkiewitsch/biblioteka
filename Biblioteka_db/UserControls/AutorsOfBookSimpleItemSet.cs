using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_db
{
    public partial class AutorsOfBookSimpleItemSet : AbstractSimpleItemSet
    {
        private List<Autor> authorsList = new List<Autor>();
        private int bookID = 0;
        FormAuthors formAuthors = new FormAuthors();

        public AutorsOfBookSimpleItemSet()
        {
            InitializeComponent();
            dgv.Columns[0].HeaderText = "autorzy książki";
        }
        public List<Autor> AuthorsList 
        {
            get { return authorsList; }
        }

        public void RefreshContent() 
        {
            addingRows = true;
            if (dgv.Rows.Count > 0) dgv.Rows.Clear();
            for (int i = 0; i < authorsList.Count; i++)
            {
                string sBirthYear = "brak";
                if (authorsList[i].rokUrodzenia != null) sBirthYear = authorsList[i].rokUrodzenia.ToString();
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value
                    = authorsList[i].imie
                    + " "
                    + authorsList[i].nazwisko
                    + " ("
                    + sBirthYear
                    + ")";
            }
            addingRows = false;
            dgv.ClearSelection();
        }

        public void LoadAuthorsOfBook(int BookID) 
        {
            bookID = BookID;
            List<Autor> currentAuthors = null;
            using (BibliotekaDataContext db = new BibliotekaDataContext()) 
            {
                List<int> bookAuthorsID = db.KsiazkaAutoras.Where(x => x.ksiazkaID == bookID).Select(x => x.autorID).ToList();
                currentAuthors = db.Autors.Where(x => bookAuthorsID.Contains(x.id)).ToList();
            }
            foreach (Autor author in currentAuthors) authorsList.Add(author);
            RefreshContent();
        }

        private void AutorsOfBookSimpleItemSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (formAuthors.ShowDialog() == DialogResult.OK) 
            {
                if (authorsList.Contains(formAuthors.SelectedAuthor) == true) return;
                authorsList.Add(formAuthors.SelectedAuthor);
                RefreshContent();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;
            authorsList.RemoveAt(selectedIndex);
            dgv.Rows.RemoveAt(selectedIndex);
        }
        


    }
}
