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
    public partial class FormRubrika : Form
    {
        public static FormRubrika Instance;
        public FormRubrika()
        {
            InitializeComponent();
            Instance = this;
            // dataGridView1.DataSource = DBConnection.Read().Tables[0];
        }

        public void ShowForm(UserControl form)
        {
            try
            {
                form.Dock = DockStyle.Fill;
                form.Show();
                panelTabelle.Controls.Add(form);
                form.BringToFront();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ABOUT \n\n" +
                "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt \n" +
                "ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo \n" +
                "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. \n" +
                "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut \n" +
                "labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo \n" +
                "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.");
        }

        private void CloseStripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string nachname = txtNachname.Text;
            string adresse = txtAdresse.Text;
            string stadt = txtOrt.Text;
            string plz = txtPlz.Text;
            string telefon = txtTelefon.Text;
            string handy = txtHandy.Text;
            string email = txtMail.Text;
            string geburtsdatum = txtDatum.Text;
            string notizen = txtNotizen.Text;
            bool favoriten = chkBoxFav.Checked;

            if (txtName.Text.Length < 2) { MessageBox.Show("Das Vornamefeld darf nicht weniger als 2 Zeichen enthalten"); return; }
            if (txtNachname.Text.Length < 2) { MessageBox.Show("Das Nachnamefeld, darf nicht weniger als 2 Zeichen enthalten"); return; }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, @"^[a-zA-Z' ]+$") == false) { MessageBox.Show("Das Vorname enthält ungültige Zeichen"); return; }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNachname.Text, @"^[a-zA-Z' ]+$") == false) { MessageBox.Show("Das Nachname enthält ungültige Zeichen"); return; }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOrt.Text, @"^[a-zA-Z' ]+$") == false) { MessageBox.Show("Ungültiger Ort Format"); return; }
            if (txtTelefon.Text.Length > 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtTelefon.Text, @"^[0-9()+/ ]+$") == false)
                {
                    MessageBox.Show("Ungültiger Telefon Format");
                    return;
                }
            }
            if (txtHandy.Text.Length > 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtHandy.Text, @"^[0-9()+/ ]+$") == false)
                {
                    MessageBox.Show("Ungültiger Telefon Format");
                    return;
                }
            }
            if (txtMail.Text.Length > 0)
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (System.Text.RegularExpressions.Regex.IsMatch(txtMail.Text, pattern) == false)
                {
                    MessageBox.Show("Ungültige Email Adresse");
                }
            }
            if (txtDatum.Text.Length > 0)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtDatum.Text, @"^\d{2}/\d{2}/\d{4}$"))
                {
                    MessageBox.Show("Falsche DATUM FORMAT, \nbitte die richtige Format \n DD/MM/YYYY \nbenutzen!!!!");
                    return;
                }
            }
            if (chkBoxFav.Checked) { favoriten = true; } else { favoriten = false; }

            Kontakte neuesKontakte = new Kontakte(name, nachname, adresse, stadt, plz, telefon, handy, email, geburtsdatum, notizen, favoriten);
            DBConnection.Create(neuesKontakte);
            Reset();
        }

        private void KontaktenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Kontakten form = new UC_Kontakten();
            ShowForm(form);
        }

        public void Reset()
        {
            foreach (Control control in panelFormular.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtBox = (TextBox)control;
                    if (txtBox.Name.StartsWith("txt"))
                    {
                        txtBox.Text = "";
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnFavoriten_Click(object sender, EventArgs e)
        {
            UC_Favoriten form = new UC_Favoriten();
            ShowForm(form);
        }
    }
}
