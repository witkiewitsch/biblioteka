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
    public partial class BooksItemSet : AbstractItemSet
    {
        public BooksItemSet()
        {
            InitializeComponent();
            // +++ SETUP COLUMNS
            SetupDataGridViewColumns(
                new DataGridViewColumn[] {
                    new DataGridViewTextBoxColumn(),
                    new DataGridViewTextBoxColumn(),
                    new DataGridViewTextBoxColumn()
                },
                new double[] { 100, 0.65, 0.35 },
                new string[] { "ID", "Tytuł", "Autor" }
            );
            // --- SETUP COLUMNS
        }
    }
}
