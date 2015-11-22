using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_db
{
    public delegate void delegateSelectionChanged(object sender, SelectionChangedEventArgs e);
    public delegate void delegateSubpageChanged(object sender, SelectionChangedEventArgs e);

    public class SelectionChangedEventArgs : EventArgs
    {
        private int selectedIndex = -1;
        public SelectionChangedEventArgs(int index)
        {
            selectedIndex = index;
        }
        public int SelectedIndex
        {
            get { return selectedIndex; }
        }
    }
}
