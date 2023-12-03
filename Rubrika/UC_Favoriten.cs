using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubrika
{
    public partial class UC_Favoriten : UserControl
    {
        public UC_Favoriten()
        {
            InitializeComponent();
            dataGridView1.DataSource = DBConnection.Favoriten().Tables[0];
            dataGridView1.Columns.RemoveAt(0);

        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];

                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                DBConnection.Delete(id);

                dataGridView1.DataSource = DBConnection.Read().Tables[0];
            }
        }
    }
}
