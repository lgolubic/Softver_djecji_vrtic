using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers.Repositories
{
    public class ObavijestiRepository
    {
        public static Obavijest GetObavijest(int id)
        {
            Obavijest obavijest = null;
            string sql = $"SELECT * FROM Obavijest WHERE id_obavijest = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                obavijest = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return obavijest;
        }

        public static List<Obavijest> GetObavijesti()
        {
            List<Obavijest> obavijesti = new List<Obavijest>();
            string sql = "SELECT * FROM Obavijest";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Obavijest obavijest = CreateObject(reader);
                obavijesti.Add(obavijest);
            }
            reader.Close();
            DB.CloseConnection();
            return obavijesti;
        }

        private static Obavijest CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_obavijest"].ToString());
            string naziv = reader["Naziv"].ToString();
            string opis = reader["Opis"].ToString();
            DateTime datum = DateTime.Parse(reader["Datum"].ToString());
            string primatelj = reader["Primatelj"].ToString();
            int zaposlenik_id = int.Parse(reader["Zaposlenik_id"].ToString());
            int roditelj_id = int.Parse(reader["Roditelj_id"].ToString());

            var obavijest = new Obavijest
            {
                Id_obavijest = id,
                Naziv = naziv,
                Opis = opis,
                Datum = datum,
                Primatelj = primatelj,
                Zaposlenik_id= zaposlenik_id,
                Roditelj_id= roditelj_id,
            };
            return obavijest;
        }

        public static void DodajObavijest(Obavijest obavijest)
        {
            string sql = @"INSERT INTO Obavijest (Naziv, Opis, Datum, Primatelj, Zaposlenik_id, Roditelj_id)
                   VALUES (@naziv, @opis, @datum, @primatelj, @zaposlenik_id, @roditelj_id)";

            DB.OpenConnection();
            var command = DB.CreateCommand(sql);

            command.Parameters.Add(new SqlParameter("@naziv", System.Data.SqlDbType.NVarChar) { Value = obavijest.Naziv });
            command.Parameters.Add(new SqlParameter("@opis", System.Data.SqlDbType.NVarChar) { Value = obavijest.Opis });
            command.Parameters.Add(new SqlParameter("@datum", System.Data.SqlDbType.DateTime) { Value = obavijest.Datum });
            command.Parameters.Add(new SqlParameter("@primatelj", System.Data.SqlDbType.NVarChar) { Value = obavijest.Primatelj });
            command.Parameters.Add(new SqlParameter("@zaposlenik_id", System.Data.SqlDbType.Int) { Value = obavijest.Zaposlenik_id });
            command.Parameters.Add(new SqlParameter("@roditelj_id", System.Data.SqlDbType.Int) { Value = obavijest.Roditelj_id });

            command.ExecuteNonQuery();
            DB.CloseConnection();
        }
    }
}
