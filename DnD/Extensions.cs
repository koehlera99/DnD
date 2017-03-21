using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DnD
{
    public static class Extensions
    {
        /// <summary>
        /// This adds the WinForms Button.PerformClick() Function to button controls.
        /// </summary>
        /// <param name="btn"></param>
        public static void PerformClick(this Button btn)
        {
            btn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }
    }
}
