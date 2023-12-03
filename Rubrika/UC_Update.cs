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
    public partial class UC_Update : UserControl
    {
        public static Kontakte kontakteUpdate;

        public UC_Update()
        {
            InitializeComponent();

            if (kontakteUpdate != null)
            {
                int id = Convert.ToInt32(kontakteUpdate.Id);
                txtName.Text = kontakteUpdate.Name;
                txtNachname.Text = kontakteUpdate.Nachname;
                txtAdresse.Text = kontakteUpdate.Adresse;
                txtOrt.Text = kontakteUpdate.Stadt;
                txtPlz.Text = kontakteUpdate.Plz;
                txtTelefon.Text = kontakteUpdate.Telefon;
                txtHandy.Text = kontakteUpdate.Handy;
                txtMail.Text = kontakteUpdate.Email;
                txtDatum.Text = kontakteUpdate.Geburtsdatum;
                txtNotizen.Text = kontakteUpdate.Notizen;

                BtnUppdate.Click += (sender, e) => BtnUppdate_Click(sender, e, this);
            }
        }

        private void BtnUppdate_Click(object sender, EventArgs e, UC_Update ucUpdate)
        {
            kontakteUpdate.Name = ucUpdate.txtName.Text;
            kontakteUpdate.Nachname = ucUpdate.txtNachname.Text;
            kontakteUpdate.Adresse = ucUpdate.txtAdresse.Text;
            kontakteUpdate.Stadt = ucUpdate.txtOrt.Text;
            kontakteUpdate.Plz = ucUpdate.txtPlz.Text;
            kontakteUpdate.Telefon = ucUpdate.txtTelefon.Text;
            kontakteUpdate.Handy = ucUpdate.txtHandy.Text;
            kontakteUpdate.Email = ucUpdate.txtMail.Text;
            kontakteUpdate.Geburtsdatum = ucUpdate.txtDatum.Text;
            kontakteUpdate.Notizen = ucUpdate.txtNotizen.Text;

            DBConnection.Update(kontakteUpdate);
        }
    }
}
