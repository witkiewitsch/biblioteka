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

    public partial class AuthorsItemSet : AbstractItemSet
    {
        private List<Autor> Authors = null;
        private Autor selectedAuthor = null;
        private bool addingRows = false;
        
        public AuthorsItemSet()
        {
            InitializeComponent();
            // +++ SETUP COLUMNS
            SetupDataGridViewColumns(
                new DataGridViewColumn[] {
                    new DataGridViewTextBoxColumn(),
                    new DataGridViewTextBoxColumn(),
                    new DataGridViewTextBoxColumn(),
                    new DataGridViewTextBoxColumn()
                },
                new double[] { 100, 0.35, 0.50, 0.15 },
                new string[] { "ID", "Imię", "Nazwisko", "Rok urodzenia" }
            );
            // --- SETUP COLUMNS
            Authors = new List<Autor>();
        }

        public Autor SelectedAuthor { get { return selectedAuthor; } }

        private void ClearRows() 
        {
            dgv.Rows.Clear();
        }
        private void ClearData() 
        {
            Authors.Clear();
        }
        private void ClearAll() 
        {
            ClearRows();
            ClearData();
            resetView();
        }

        private void AddData(List<Autor> authors) 
        {
            foreach (Autor a in authors) 
            {
                Authors.Add(a);
            }
        }

        private void DisplayData()
        {
            int firstIndex = CurrentPage * RowsPerPage;
            int lastIndex = CurrentPage * RowsPerPage + RowsPerPage;
            if (lastIndex > Authors.Count) lastIndex = Authors.Count;
            addingRows = true;
            for (int i = 0; i < lastIndex - firstIndex; i++)
            {
                dgv.Rows.Add();
                Autor a = Authors[i + firstIndex];
                dgv.Rows[i].Cells[0].Value = a.id.ToString();
                dgv.Rows[i].Cells[1].Value = a.imie;
                dgv.Rows[i].Cells[2].Value = a.nazwisko;
                dgv.Rows[i].Cells[3].Value = a.rokUrodzenia.ToString();
            }
            addingRows = false;
            dgv.ClearSelection();
            selectedAuthor = null;
        }

        public void AttachNewData(List<Autor> authors) 
        {
            ClearAll();
            AddData(authors);
            if (Authors.Count == 0)
            {
                Pages = 1;
            }
            else
            {
                Pages = (Authors.Count - 1) / RowsPerPage + 1;
            }
            DisplayData();
        }




        private void AuthorsItemSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (addingRows == true) return;
            if (dgv.Rows.Count == 0) return;
            int index = e.SelectedIndex;
            int selectedAuthorID = -1;
            try
            {
                selectedAuthorID = int.Parse(dgv.Rows[index].Cells[0].Value.ToString());
            }
            catch (Exception) { } 

            if (selectedAuthorID != -1) 
            {
                selectedAuthor = Authors.Where(x => x.id == selectedAuthorID).Single();
            }
        }

        private void AuthorsItemSet_SubpageChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearRows();
            DisplayData();
        }

        private void AuthorsItemSet_RowsPerPageChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearRows();
            DisplayData();
        }
        public void RemoveSelectedAuthor() 
        {
            if (dgv.SelectedRows.Count == 0) return;
            Authors.Remove(Authors.Where(x => x.id == SelectedAuthor.id).Single());
            ClearRows();
            DisplayData();
        }
        public void UpdateEditedAuthor(Autor authorsNewData) 
        {
            int index = Authors.FindIndex(x => x.id == selectedAuthor.id);
            Authors[index].imie = authorsNewData.imie;
            Authors[index].nazwisko = authorsNewData.nazwisko;
            Authors[index].rokUrodzenia = authorsNewData.rokUrodzenia;
            ClearRows();
            DisplayData();
        }
    }
}
