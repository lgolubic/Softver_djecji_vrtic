using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiny_Explorers.Models;

namespace Tiny_Explorers.Repositories
{
    public class EvidencijeDolaskaRepository
    {
        public static EvidencijaDolaska GetEvidencija(int id)
        {
            EvidencijaDolaska evidencija = null;
            string sql = $"SELECT * FROM Evidencija_dolaska WHERE id_evidencija = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                evidencija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return evidencija;
        }

        public static List<EvidencijaDolaska> GetEvidencije()
        {
            List<EvidencijaDolaska> evidencije = new List<EvidencijaDolaska>();
            string sql = "SELECT * FROM Evidencija_dolaska";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                EvidencijaDolaska evidencija = CreateObject(reader);
                evidencije.Add(evidencija);
            }
            reader.Close();
            DB.CloseConnection();
            return evidencije;
        }

        private static EvidencijaDolaska CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_evidencija"].ToString());
            DateTime datum = DateTime.Parse(reader["Datum"].ToString());
            string prisutan = reader["Prisutan"].ToString();
            string razlog_izostanka = reader["Razlog_izostanka"].ToString();
            int skupina_id = int.Parse(reader["Skupina_id"].ToString());
            int dijete_id = int.Parse(reader["Dijete_id"].ToString());

            var evidencija = new EvidencijaDolaska
            {
                Id_evidencija = id,
                Datum = datum,
                Prisutan = prisutan,
                Razlog_izostanka = razlog_izostanka,
                Skupina_id = skupina_id,
                Dijete_id = dijete_id,
            };
            return evidencija;
        }
        public static void SpremiEvidenciju(EvidencijaDolaska evidencija)
        {
            string sql = "INSERT INTO Evidencija_dolaska (Datum, Prisutan, Razlog_izostanka, Skupina_id, Dijete_id) " +
                         "VALUES (@Datum, @Prisutan, @Razlog_izostanka, @Skupina_id, @Dijete_id)";

            DB.OpenConnection();
            var command = DB.CreateCommand(sql);

            command.Parameters.Add(new SqlParameter("@Datum", System.Data.SqlDbType.Date) { Value = evidencija.Datum });
            command.Parameters.Add(new SqlParameter("@Prisutan", System.Data.SqlDbType.NVarChar) { Value = evidencija.Prisutan });
            command.Parameters.Add(new SqlParameter("@Razlog_izostanka", System.Data.SqlDbType.NVarChar) { Value = evidencija.Razlog_izostanka });
            command.Parameters.Add(new SqlParameter("@Skupina_id", System.Data.SqlDbType.Int) { Value = evidencija.Skupina_id });
            command.Parameters.Add(new SqlParameter("@Dijete_id", System.Data.SqlDbType.Int) { Value = evidencija.Dijete_id });

            command.ExecuteNonQuery();
            DB.CloseConnection();
        }


    }
}