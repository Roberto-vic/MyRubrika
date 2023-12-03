using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubrika
{
    public class DBConnection
    {

        public static string dbConnection = "Server=localhost; Database=rubrika; User=root; Password=;";

        public static MySqlConnection connection;
        public static MySqlCommand query = null;
        public static DataSet dataSet;
        public static IDataAdapter adapter;


        public static void Connection()
        {
            try
            {
                connection = new MySqlConnection(dbConnection);
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public static void Create(Kontakte nueusKontakt)
        {
            try
            {
                string createQuery = "INSERT INTO kontakte(name, nachname, adresse, stadt, plz, telefon, handy, email, geburtsdatum, notizen, favoriten)" +
                    "VALUES(@name, @nachname, @adresse, @stadt, @plz, @telefon, @handy, @email, @geburtsdatum, @notizen, @favoriten);";

                query = new MySqlCommand(createQuery, connection);

                query.Parameters.AddWithValue("@name", nueusKontakt.Name);
                query.Parameters.AddWithValue("@nachname", nueusKontakt.Nachname);
                query.Parameters.AddWithValue("@adresse", nueusKontakt.Adresse);
                query.Parameters.AddWithValue("@stadt", nueusKontakt.Stadt);
                query.Parameters.AddWithValue("@plz", nueusKontakt.Plz);
                query.Parameters.AddWithValue("@telefon", nueusKontakt.Telefon);
                query.Parameters.AddWithValue("@handy", nueusKontakt.Handy);
                query.Parameters.AddWithValue("@email", nueusKontakt.Email);
                query.Parameters.AddWithValue("@geburtsdatum", nueusKontakt.Geburtsdatum);
                query.Parameters.AddWithValue("@notizen", nueusKontakt.Notizen);
                query.Parameters.AddWithValue("@favoriten", nueusKontakt.Favoriten);

                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public static DataSet Favoriten()
        {
            try
            {
                string favQuery = "SELECT * FROM kontakte WHERE favoriten=1;";

                query = new MySqlCommand(favQuery, connection);
                adapter = new MySqlDataAdapter(query);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        public static DataSet Read()
        {
            try
            {
                string readQuery = "SELECT * FROM kontakte;";
                query = new MySqlCommand(readQuery, connection);
                adapter = new MySqlDataAdapter(query);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public static void Delete(int id)
        {
            string delQuery = "DELETE FROM kontakte WHERE @id=id;";

            query = new MySqlCommand(delQuery, connection);
            query.Parameters.AddWithValue("id", id);
            query.ExecuteNonQuery();
        }

        public static void Update(Kontakte kontakteUpdate)
        {
            string updateQuery = "UPDATE kontakte SET name=@name, nachname=@nachname, adresse=@adresse, stadt=@stadt, plz=@plz, telefon=@telefon, handy=@handy, email=@email, geburtsdatum=@geburtsdatum, notizen=@notizen WHERE id=@id;";

            query = new MySqlCommand(updateQuery, connection);

            query.Parameters.AddWithValue("@id", kontakteUpdate.Id);
            query.Parameters.AddWithValue("@name", kontakteUpdate.Name);
            query.Parameters.AddWithValue("@nachname", kontakteUpdate.Nachname);
            query.Parameters.AddWithValue("@adresse", kontakteUpdate.Adresse);
            query.Parameters.AddWithValue("@stadt", kontakteUpdate.Stadt);
            query.Parameters.AddWithValue("@plz", kontakteUpdate.Plz);
            query.Parameters.AddWithValue("@telefon", kontakteUpdate.Telefon);
            query.Parameters.AddWithValue("@handy", kontakteUpdate.Handy);
            query.Parameters.AddWithValue("@email", kontakteUpdate.Email);
            query.Parameters.AddWithValue("@geburtsdatum", kontakteUpdate.Geburtsdatum);
            query.Parameters.AddWithValue("@notizen", kontakteUpdate.Notizen);

            query.ExecuteNonQuery();
        }
    }
}
