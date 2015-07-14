using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WeifenLuo.WinFormsUI.Docking.Helpers
{
    internal static class WinformsHelper
    {
        public static Control FindParent(Control child)
        {
            Control parent = null;
            parent = child.FindForm();
           
            if (parent == null)
            {
                parent = child;
                while (parent != null && !(parent is UserControl))
                {
                    parent = parent.Parent;
                }
            }

            return parent;
        }
    }
}
