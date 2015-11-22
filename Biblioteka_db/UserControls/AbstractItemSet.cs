using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
    !!! Tej klasy najlepiej nie dotykac.
    Klasa stanowi "silnik layoutu" dla klas potomnych, ktorych instancje sa wlasciwymi kontrolkami do wyswietlania danych tabelarycznych z pojedynczych tabel
*/
namespace Biblioteka_db
{
   
    public /*abstract - temporarly removed for designed*/ partial class AbstractItemSet : UserControl
    {
        public event delegateSelectionChanged SelectionChanged;
        public event delegateSubpageChanged SubpageChanged;
        public event delegateSelectionChanged RowsPerPageChanged;
        
        protected DataGridViewColumn[] columns = null;
        protected double[] columnWidths = null;
        protected string[] columnHeaders = null;
        private int pages = 1;
        private int currentPage = 0;
        private int rowsPerPage = 20;

        public AbstractItemSet()
        {
            InitializeComponent();
            cbRowsPerPage.SelectedIndex = 0;
        }


        /*
         P R O P E R T I E S
         */
        protected int Pages
        {
            get { return pages; }
            set
            {
                pages = value;
                if (currentPage >= pages) currentPage = pages;
            }
        }
        protected int CurrentPage
        {
            get { return currentPage; }
        }
        protected int RowsPerPage
        {
            get { return rowsPerPage; }
        }


        /*
         Funkcja ustawiajaca szerokosc kolumn
         * 
         Jesli szerokosc kolumny jest mniejsza badz rowna 20 dodawana jest do kolumn stalych, czyli ich szerokosc nie zalezy od layoutu
         Szerokosci z przedzialu (1.0, 20.0) sa nieakceptowane poniewaz sa to rozmiary za male
         Wartosci z przedzialu (0.05, 1.0> sa traktowane jako wartosci procentowe.
         Wartosci procentowe okreslaja udzial kolumny w podziale szerokosci DataGridView nieprzydzielonej kolumnom stalym.
         W przypadku bledy uzytkownika, gdy suma wartosci procentowych jest rozna od 1.0, funkcja dokonuje skalowania.
         wartosci ponize 0.05 - czyli poniżej 5% sa nieakceptowane
         !!! Wartosci szerokosci kolumn dynamicznych, wyliczone z udzialu procentowego nie podlegaja sprawdzaniu poniewaz wymagaloby to zablokowania
         zmniejszania okna ponizej dynamicznie wyliczanego minimum.
         !!! Wywolanie tej funkcji w innych funkcjach powinno byc poprzedzane wywolaniem SuspendLayout aby wyeliminowac negatywne wrazenia wizualne
         */
        protected void ResizeDataGridViewColumns()
        {
            int staticWidthSum = 0;
            double dynamicScale = 0.0;

            for (int i = 0; i < columns.Length; i++)
            {
                if (columnWidths[i] >= 20.0)
                {
                    dgv.Columns[i].Width = ((int)columnWidths[i]);
                    staticWidthSum += ((int)columnWidths[i]);
                }
                else if (columnWidths[i] > 1.0)
                {
                    throw new ArgumentOutOfRangeException("columnWidth", "must not be in (1.0, 20.0)");
                }
                else if (columnWidths[i] < 0.05) 
                {
                    throw new ArgumentOutOfRangeException("columnWidth", "must not be less than 0.05");
                }
                else
                {
                    dynamicScale += columnWidths[i];
                }
            }

            /* 1px(border) + vertical scrollbar width ~= 19 */
            double dynamicWidthSum = (dgv.Width - staticWidthSum - 19 - 2 * columns.Length - dgv.RowHeadersWidth) / dynamicScale;

            for (int i = 0; i < columns.Length; i++)
            {
                if (columnWidths[i] <= 1.0)
                {
                    dgv.Columns[i].Width = ((int)Math.Round(dynamicWidthSum * columnWidths[i]));
                    if (dgv.Columns[i].Width < 20) dgv.Columns[i].Width = 20;
                }
            }
        }

        protected void SetupDataGridViewColumns(DataGridViewColumn[] Columns, double[] ColumnWidths, string[] ColumnHeaders)
        {
            if (Columns.Length != ColumnWidths.Length || Columns.Length != ColumnHeaders.Length)
            {
                return;
            }
            if (Columns != null)
            {
                columns = Columns;
                columnWidths = ColumnWidths;
                columnHeaders = ColumnHeaders;
                SuspendLayout();
                dgv.Columns.AddRange(columns);
                ResizeDataGridViewColumns();
                for (int i = 0; i < columnHeaders.Length; i++) dgv.Columns[i].HeaderText = columnHeaders[i];
                ResumeLayout();
            }
        }

        protected void dgv_SizeChanged(object sender, EventArgs e)
        {
            if (columns == null) return;
            SuspendLayout();
            ResizeDataGridViewColumns();
            ResumeLayout();
        }

        /* Koniec obslugi zmiany rozmiaru */




        protected void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) return;
            SelectionChanged((object)this, new SelectionChangedEventArgs(dgv.SelectedRows[0].Index));
        }




        private void updatePageNumberLabel() 
        {
            labHeaderSubpage.Text = "podstrona nr " + (currentPage+1).ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (pages == 1) return;
            if (currentPage > 0)
            {
                currentPage = 0;
                updatePageNumberLabel();
                SubpageChanged((object)this, new SelectionChangedEventArgs(currentPage));
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pages == 1) return;
            if (currentPage > 0)
            {
                currentPage--;
                updatePageNumberLabel();
                SubpageChanged((object)this, new SelectionChangedEventArgs(currentPage));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pages == 1) return;
            if (currentPage < pages-1)
            {
                currentPage++;
                updatePageNumberLabel();
                SubpageChanged((object)this, new SelectionChangedEventArgs(currentPage));
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (pages == 1) return;
            if (currentPage < pages - 1)
            {
                currentPage = pages - 1;
                updatePageNumberLabel();
                SubpageChanged((object)this, new SelectionChangedEventArgs(currentPage));
            }
        }



        private void cbRowsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRowsPerPage.SelectedIndex == -1) return;

            int rpp = int.Parse(cbRowsPerPage.Text);
            if (rpp != rowsPerPage)
            {
                rowsPerPage = rpp;
                RowsPerPageChanged((object)this, new SelectionChangedEventArgs(cbRowsPerPage.SelectedIndex));
            }
        }

        protected void resetView() 
        {
            currentPage=0;
            updatePageNumberLabel();
        }

    }
}
