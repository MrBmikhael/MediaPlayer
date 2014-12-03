using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    class ListViewItemSort : IComparer
    {
        private int colIndex;
        private SortOrder order;

        public ListViewItemSort()
        { }

        public ListViewItemSort(int column, SortOrder order)
        {
            colIndex = column;
            this.order = order;
        }

        public int Compare(object a, object b)
        {
            int ret = -1;

            ret = String.Compare(((ListViewItem)a).SubItems[colIndex].Text, ((ListViewItem)b).SubItems[colIndex].Text);

            if (order == SortOrder.Descending)
                ret *= -1;

            return ret;
        }
    }
}
