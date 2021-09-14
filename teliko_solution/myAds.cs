using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class myAds : Form
    {
        public myAds()
        {
            InitializeComponent();
            myFavoritesGV.DataSource = this.user_FavoriteViewTableAdapter.GetData("trosquitJ4");

        }
        private void myFavoritesGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.deleteImage.Width;
                var h = Properties.Resources.deleteImage.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.deleteImage, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void myFavoriteTab_Click(object sender, EventArgs e)
        {

        }

        private void myAdsTab_Click(object sender, EventArgs e)
        {

        }

        private void myFavoritesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                {
                    //var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    // label2.Text = id.ToString();
                    //ar test = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    //int User_id = 3;

                   
                        myFavoritesGV.Rows.Remove(myFavoritesGV.Rows[e.RowIndex]);
                    
                }
            }
        }
    }
}
