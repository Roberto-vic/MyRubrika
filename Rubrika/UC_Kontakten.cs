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
    public partial class UC_Kontakten : UserControl
    {
        public UC_Kontakten()
        {
            InitializeComponent();
            dataGridView1.DataSource = DBConnection.Read().Tables[0];
            dataGridView1.Columns.RemoveAt(0);
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];

                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string name = Convert.ToString(selectedRow.Cells["name"].Value);
                string nachname = Convert.ToString(selectedRow.Cells["nachname"].Value);
                string adresse = Convert.ToString(selectedRow.Cells["adresse"].Value);
                string stadt = Convert.ToString(selectedRow.Cells["stadt"].Value);
                string plz = Convert.ToString(selectedRow.Cells["plz"].Value);
                string telefon = Convert.ToString(selectedRow.Cells["telefon"].Value);
                string handy = Convert.ToString(selectedRow.Cells["handy"].Value);
                string email = Convert.ToString(selectedRow.Cells["email"].Value);
                string geburtsdatum = Convert.ToString(selectedRow.Cells["geburtsdatum"].Value);
                string notizen = Convert.ToString(selectedRow.Cells["notizen"].Value);

                Kontakte kontakteUpdate = new Kontakte(id, name, nachname, adresse, stadt, plz, telefon, handy, email, geburtsdatum, notizen);

                UC_Update.kontakteUpdate = kontakteUpdate;

                FormRubrika.Instance.ShowForm(new UC_Update());
            }
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
