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
    public partial class AbstractSimpleItemSet : UserControl
    {
        public event delegateSelectionChanged SelectionChanged;
        protected bool addingRows = false;
        protected int selectedIndex = -1;

        public AbstractSimpleItemSet()
        {
            InitializeComponent();
        }

        /// obsluga zmiany rozmiarow
        private void AbstractSimpleItemSet_SizeChanged(object sender, EventArgs e)
        {
            dgv.Columns[0].Width = dgv.Width - dgv.RowHeadersWidth - 5;
            int buttonWidth = (Width - 12) / 2;
            btnAdd.Width = buttonWidth;
            btnDel.Width = buttonWidth;
            btnDel.Left = buttonWidth + 9;
        }

        protected void deleteSelectedAuthor() 
        {
            if (selectedIndex > -1) 
            {
                dgv.Rows.RemoveAt(selectedIndex);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (addingRows) return;
            if (dgv.SelectedRows.Count > 0) 
            {
                selectedIndex = dgv.SelectedRows[0].Index;
                SelectionChanged((object)this, new SelectionChangedEventArgs(selectedIndex));
                return;
            }
            selectedIndex = -1;
            SelectionChanged((object)this, new SelectionChangedEventArgs(selectedIndex));
        }
        
    }
}
