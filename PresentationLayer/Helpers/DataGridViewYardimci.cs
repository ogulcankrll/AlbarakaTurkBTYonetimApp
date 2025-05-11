using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Helpers
{
    public static class DataGridViewYardimci
    {
        public static void SatirRenklendir(DataGridView grid)
        {
            grid.RowPrePaint += (s, e) =>
            {
                Color renk1 = Color.LightGray;
                Color renk2 = Color.White;

                
                if (e.RowIndex % 2 == 0)
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = renk1;
                }
                else
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = renk2;
                }
            };
        }
    }
}
