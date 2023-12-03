using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrika
{
    public class Kontakte
    {
        private int id;
        private string name;
        private string nachname;
        private string adresse;
        private string stadt;
        private string plz;
        private string telefon;
        private string handy;
        private string email;
        private string geburtsdatum;
        private string notizen;
        private bool favoriten;
        private string id1;


        public Kontakte(int id, string name, string nachname, string adresse, string stadt, string plz, string telefon, string handy, string email, 
                        string geburtsdatum, string notizen, bool favoriten)
        {
            this.id = id;
            this.name = name;
            this.nachname = nachname;
            this.adresse = adresse;
            this.Stadt = stadt;
            this.plz = plz;
            this.telefon = telefon;
            this.handy = handy;
            this.email = email;
            this.geburtsdatum = geburtsdatum;
            this.notizen = notizen;
            this.favoriten = favoriten;
            
        }
        public Kontakte(string name, string nachname, string adresse, string stadt, string plz, string telefon, string handy, string email,
                        string geburtsdatum, string notizen, bool favoriten)
        {
            this.name = name;
            this.nachname = nachname;
            this.adresse = adresse;
            this.Stadt = stadt;
            this.plz = plz;
            this.telefon = telefon;
            this.handy = handy;
            this.email = email;
            this.geburtsdatum = geburtsdatum;
            this.notizen = notizen;
            this.favoriten = favoriten;

        }

        public Kontakte(int id, string name, string nachname, string adresse, string stadt, string plz, string telefon, string handy, string email, string geburtsdatum, string notizen)
        {
            this.id = id;
            this.name = name;
            this.nachname = nachname;
            this.adresse = adresse;
            this.stadt = stadt;
            this.plz = plz;
            this.telefon = telefon;
            this.handy = handy;
            this.email = email;
            this.geburtsdatum = geburtsdatum;
            this.notizen = notizen;
        }

        public string Name { get => name; set => name = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Stadt { get => stadt; set => stadt = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Handy { get => handy; set => handy = value; }
        public string Email { get => email; set => email = value; }
        public string Geburtsdatum { get => geburtsdatum; set => geburtsdatum = value; }
        public string Notizen { get => notizen; set => notizen = value; }
        public bool Favoriten { get => favoriten; set => favoriten = value; }
        public int Id { get => id; set => id = value; }
        public string Id1 { get => id1; set => id1 = value; }
    }
}
