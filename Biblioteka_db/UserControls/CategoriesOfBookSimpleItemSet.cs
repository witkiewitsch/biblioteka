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
    public partial class CategoriesOfBookSimpleItemSet : AbstractSimpleItemSet
    {
        public CategoriesOfBookSimpleItemSet()
        {
            InitializeComponent();
            dgv.Columns[0].HeaderText = "kategorie książki";
        }

        public void SetCategories(List<Kategoria> categoriesList)
        {
            addingRows = true;
            for (int i = 0; i < categoriesList.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = categoriesList[i].nazwa;
            }
            addingRows = false;
        }

        private void CategoriesOfBookSimpleItemSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
