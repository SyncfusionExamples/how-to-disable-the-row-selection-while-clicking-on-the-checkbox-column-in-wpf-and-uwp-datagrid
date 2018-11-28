using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SfDataGridDemo
{
    public class CustomGridSelectionController : GridSelectionController
    {
        public CustomGridSelectionController(SfDataGrid dataGrid) : base(dataGrid)
        {

        }

        protected override void ProcessPointerPressed(MouseButtonEventArgs args, RowColumnIndex rowColumnIndex)
        {
            var columnIndex = this.DataGrid.ResolveToGridVisibleColumnIndex(rowColumnIndex.ColumnIndex);
            var column = this.DataGrid.Columns[columnIndex];
            if (column is GridCheckBoxColumn)
                return;
            base.ProcessPointerPressed(args, rowColumnIndex);
        }
    }
}
