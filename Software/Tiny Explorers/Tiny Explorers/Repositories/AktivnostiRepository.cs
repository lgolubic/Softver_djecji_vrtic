using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Tiny_Explorers.Models;

namespace Tiny_Explorers.Repositories
{
    public static class AktivnostiRepository
    {
        public static Plan_aktivnosti GetAktivnost(int id)
        {
            Plan_aktivnosti aktivnost = null;
            string sql = $@"
                SELECT pa.*, s.Naziv AS NazivSkupine
                FROM Plan_aktivnosti pa
                LEFT JOIN Skupina s ON pa.Skupina_id = s.Id_skupina
                WHERE pa.Id_plan = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                aktivnost = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return aktivnost;
        }


        public static List<Plan_aktivnosti> GetAktivnosti()
        {
            List<Plan_aktivnosti> aktivnosti = new List<Plan_aktivnosti>();
            string sql = @"
                SELECT pa.*, s.Naziv AS NazivSkupine
                FROM Plan_aktivnosti pa
                LEFT JOIN Skupina s ON pa.Skupina_id = s.Id_skupina";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Plan_aktivnosti aktivnost = CreateObject(reader);
                aktivnosti.Add(aktivnost);
            }
            reader.Close();
            DB.CloseConnection();
            return aktivnosti;
        }

        private static Plan_aktivnosti CreateObject(SqlDataReader reader)
        {
            int id_plan = int.Parse(reader["Id_plan"].ToString());
            string naziv = reader["Naziv"].ToString();
            DateTime datum = DateTime.Parse(reader["Datum"].ToString());
            string opis = reader["Opis"].ToString();
            string komentar = reader["Komentar"].ToString();
            string materijal = reader["Materijal"].ToString();
            string realizirano = reader["Realizirano"].ToString();
            int skupina_id = int.Parse(reader["Skupina_id"].ToString());

            string nazivSkupine = reader["NazivSkupine"] == DBNull.Value ? "" : reader["NazivSkupine"].ToString();

            var plan_aktivnosti = new Plan_aktivnosti
            {
                Id_plan = id_plan,
                Naziv = naziv,
                Datum = datum,
                Opis = opis,
                Komentar = komentar,
                Materijal = materijal,
                Realizirano = realizirano,
                Skupina_id = skupina_id,
                NazivSkupine = nazivSkupine  
            };
            return plan_aktivnosti;
        }

        private static string EscapeStringForSql(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            return s.Replace("'", "''");
        }

        public static void DodajAktivnost(Plan_aktivnosti aktivnost)
        {
            aktivnost.Id_plan = GetNextId();

            string sql = $@"
            INSERT INTO Plan_aktivnosti 
            (Id_plan, Datum, Naziv, Opis, Komentar, Materijal, Realizirano, Skupina_id)
            VALUES 
            ({aktivnost.Id_plan}, '{aktivnost.Datum:yyyy-MM-dd}', 
            N'{EscapeStringForSql(aktivnost.Naziv)}', 
            N'{EscapeStringForSql(aktivnost.Opis)}', 
            N'{EscapeStringForSql(aktivnost.Komentar)}', 
            N'{EscapeStringForSql(aktivnost.Materijal)}', 
            N'{EscapeStringForSql(aktivnost.Realizirano)}', 
        {aktivnost.Skupina_id})";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        
        public static void AzurirajAktivnost(Plan_aktivnosti aktivnost)
        {
            string sql = $@"
                UPDATE Plan_aktivnosti SET 
                Datum = '{aktivnost.Datum:yyyy-MM-dd}',
                Naziv = N'{EscapeStringForSql(aktivnost.Naziv)}',
                Opis = N'{EscapeStringForSql(aktivnost.Opis)}',
                Komentar = N'{EscapeStringForSql(aktivnost.Komentar)}',
                Materijal = N'{EscapeStringForSql(aktivnost.Materijal)}',
                Realizirano = N'{EscapeStringForSql(aktivnost.Realizirano)}',
                Skupina_id = {aktivnost.Skupina_id}
            WHERE Id_plan = {aktivnost.Id_plan}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        
        public static void ObrisiAktivnost(int id)
        {
            string sql = $"DELETE FROM Plan_aktivnosti WHERE Id_plan = {id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

       
        public static int GetNextId()
        {
            int maxId = 0;
            string sql = "SELECT ISNULL(MAX(Id_plan), 0) FROM Plan_aktivnosti";

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
    }
}
