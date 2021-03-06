﻿using System.Windows;
using System.Windows.Controls;

namespace DnD.Control
{
    /// <summary>
    /// This is a custom DataGrid to use when you need to have Templated Columns and also have AutoGenerated Columns.
    /// </summary>
    /// <remarks>
    /// Source: https://wpftutorial.net/DataGrid.html
    /// </remarks>
    public class CustDataGrid : DataGrid
    {

        public DataTemplateSelector CellTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(CellTemplateSelectorProperty); }
            set { SetValue(CellTemplateSelectorProperty, value); }
        }

        public static readonly DependencyProperty CellTemplateSelectorProperty =
            DependencyProperty.Register("Selector", typeof(DataTemplateSelector), typeof(CustDataGrid),
            new FrameworkPropertyMetadata(null));

        protected override void OnAutoGeneratingColumn(DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Cancel = true;
            Columns.Add(new DataGridTemplateColumn
            {
                Header = e.Column.Header,
                CellTemplateSelector = CellTemplateSelector
            });
        }
    }
}
