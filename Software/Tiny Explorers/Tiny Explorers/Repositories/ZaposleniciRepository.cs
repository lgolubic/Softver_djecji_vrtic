using DBLayer;
using Tiny_Explorers.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tiny_Explorers.Repositories
{
    public class ZaposleniciRepository
    {
        public static Zaposlenik GetZaposlenik(string Korisnicko_ime)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE korisnicko_ime = '{Korisnicko_ime}'";
            return FetchZaposlenik(sql);
        }

        public static Zaposlenik GetZaposlenik(int Id_zaposlenik)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE id_zaposlenik = {Id_zaposlenik}";
            return FetchZaposlenik(sql);
        }
        private static Zaposlenik FetchZaposlenik(string sql)
        {

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_zaposlenik"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string korisnicko_ime = reader["Korisnicko_ime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string uloga = reader["Uloga"].ToString();
            string email = reader["Email"].ToString();
            var zaposlenik = new Zaposlenik
            {
                Id_zaposlenik = id,
                Ime = ime,
                Prezime = prezime,
                Korisnicko_ime = korisnicko_ime,
                Lozinka = lozinka,
                Uloga = uloga,
                Email = email
            };
            return zaposlenik;
        }

        public List<Zaposlenik> DohvatiSveZaposlenike()
        {
            List<Zaposlenik> lista = new List<Zaposlenik>();

            string sql = "SELECT * FROM Zaposlenik";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zaposlenik zaposlenik = new Zaposlenik
                {
                    Id_zaposlenik = int.Parse(reader["Id_zaposlenik"].ToString()),
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString(),
                    Korisnicko_ime = reader["Korisnicko_ime"].ToString(),
                    Lozinka = reader["Lozinka"].ToString(),
                    Uloga = reader["Uloga"].ToString(),
                    Email = reader["Email"].ToString()
                };

                lista.Add(zaposlenik);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;
        }

        public int GetNextIdZaposlenik()
        {
            int maxId = 0;
            string sql = "SELECT ISNULL(MAX(id_zaposlenik), 0) FROM Zaposlenik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.Read())
            {
                maxId = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            DB.CloseConnection();
            return maxId + 1;
        }

        public void DodajZaposlenika(Zaposlenik noviZaposlenik)
        {
            int noviId = GetNextIdZaposlenik();
            noviZaposlenik.Id_zaposlenik = noviId;

            string sql = $"INSERT INTO Zaposlenik (id_zaposlenik, ime, prezime, korisnicko_ime, lozinka, uloga, email) " +
                         $"VALUES ({noviZaposlenik.Id_zaposlenik}, '{noviZaposlenik.Ime}', '{noviZaposlenik.Prezime}', " +
                         $"'{noviZaposlenik.Korisnicko_ime}', '{noviZaposlenik.Lozinka}', '{noviZaposlenik.Uloga}', '{noviZaposlenik.Email}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void UrediZaposlenika(Zaposlenik zaposlenik)
        {
            string sql = $"UPDATE Zaposlenik SET " +
                         $"ime = '{zaposlenik.Ime}', " +
                         $"prezime = '{zaposlenik.Prezime}', " +
                         $"korisnicko_ime = '{zaposlenik.Korisnicko_ime}', " +
                         $"lozinka = '{zaposlenik.Lozinka}', " +
                         $"uloga = '{zaposlenik.Uloga}', " +
                         $"email = '{zaposlenik.Email}' " +
                         $"WHERE id_zaposlenik = {zaposlenik.Id_zaposlenik}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void ObrisiZaposlenika(int idZaposlenik)
        {
            string sql = $"DELETE FROM Zaposlenik WHERE id_zaposlenik = {idZaposlenik}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}

    


