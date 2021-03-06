using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.CommonPresenter
{
    public static class DataGridViewStyle
    {
        public static void StyleDatagridview(DataGridView dataGrid)
        {
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(199, 198, 207);
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGrid.BackgroundColor = Color.FromArgb(247, 247, 247);
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //optional
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Sakkal Majalla", 13, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 91, 150);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid.RowTemplate.Height = 39;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGrid.RowsDefaultCellStyle.Font = new Font("Sakkal Majalla", 13, FontStyle.Bold);
            dataGrid.GridColor = Color.Black;
        }
    }
}
