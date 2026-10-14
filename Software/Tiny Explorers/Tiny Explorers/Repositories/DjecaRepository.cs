using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Tiny_Explorers.Models;

namespace Tiny_Explorers.Repositories
{
    public class DjecaRepository
    {
        public static Dijete GetDijete(int id)
        {
            Dijete dijete = null;
            string sql = $"SELECT * FROM Dijete WHERE id_dijete = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                dijete = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return dijete;
        }

        public static List<Dijete> GetDjeca()
        {
            List<Dijete> djeca = new List<Dijete>();
            string sql = @"
               SELECT d.*, 
               r.Ime + ' ' + r.Prezime AS RoditeljIme, 
               r.Email AS EmailRoditelja,
               r.Telefon AS TelefonRoditelja,
               s.Naziv AS SkupinaNaziv 
               FROM Dijete d
               LEFT JOIN Roditelj r ON d.Roditelj_id = r.Id_roditelj
               LEFT JOIN Skupina s ON d.Skupina_id = s.Id_skupina";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Dijete dijete = CreateObject(reader);
                djeca.Add(dijete);
            }
            reader.Close();
            DB.CloseConnection();
            return djeca;
        }

        public static int GetNextDijeteId()
        {
            int nextId = 1;
            string sql = "SELECT ISNULL(MAX(Id_dijete), 0) + 1 FROM Dijete";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.Read())
            {
                nextId = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            DB.CloseConnection();

            return nextId;
        }




        public static List<Dijete> GetDjecaWithParameters(string ime, string prezime)
        {
            List<Dijete> djeca = new List<Dijete>();
            List<string> uvjeti = new List<string>();

            if (!string.IsNullOrWhiteSpace(ime))
                uvjeti.Add($"d.Ime LIKE N'%{ime}%'");

            if (!string.IsNullOrWhiteSpace(prezime))
                uvjeti.Add($"d.Prezime LIKE N'%{prezime}%'");

            string sql = @"
               SELECT d.*, 
               r.Ime + ' ' + r.Prezime AS RoditeljIme, 
               r.Email AS EmailRoditelja,
               r.Telefon AS TelefonRoditelja,
               s.Naziv AS SkupinaNaziv 
               FROM Dijete d
               LEFT JOIN Roditelj r ON d.Roditelj_id = r.Id_roditelj
               LEFT JOIN Skupina s ON d.Skupina_id = s.Id_skupina";

            if (uvjeti.Count > 0)
                sql += " WHERE " + string.Join(" AND ", uvjeti);

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Dijete dijete = CreateObject(reader);
                djeca.Add(dijete);
            }
            reader.Close();
            DB.CloseConnection();
            return djeca;
        }

        public static List<Dijete> GetDjecaBySkupina(int skupinaId)
        {
            List<Dijete> djeca = new List<Dijete>();
            string sql = $@"
            SELECT d.*, 
             r.Ime + ' ' + r.Prezime AS RoditeljIme, 
             r.Email AS EmailRoditelja,
             r.Telefon AS TelefonRoditelja,
             s.Naziv AS SkupinaNaziv 
            FROM Dijete d
            LEFT JOIN Roditelj r ON d.Roditelj_id = r.Id_roditelj
            LEFT JOIN Skupina s ON d.Skupina_id = s.Id_skupina
            WHERE d.Skupina_id = {skupinaId}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Dijete dijete = CreateObject(reader);
                djeca.Add(dijete);
            }

            reader.Close();
            DB.CloseConnection();

            return djeca;
        }
        public static void AddDijete(Dijete dijete)
        {
            string sql = $@"
                INSERT INTO Dijete (Id_dijete, Ime, Prezime, Oib, Datum_rodenja, Alergije, Dijete_s_teskocama, Napomena, Roditelj_id, Skupina_id)
                VALUES ({dijete.Id_dijete},N'{dijete.Ime}', N'{dijete.Prezime}', '{dijete.Oib}', '{dijete.Datum_rodenja:yyyy-MM-dd}', 
                        N'{dijete.Alergije}', N'{dijete.Dijete_s_teskocama}', N'{dijete.Napomena}', {dijete.Roditelj_id}, {dijete.Skupina_id})";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void AzurirajDijete(Dijete dijete)
        {
            string sql = $@"
                UPDATE Dijete SET 
                    Ime = N'{dijete.Ime}',
                    Prezime = N'{dijete.Prezime}',
                    Oib = '{dijete.Oib}',
                    Datum_rodenja = '{dijete.Datum_rodenja:yyyy-MM-dd}',
                    Alergije = N'{dijete.Alergije}',
                    Dijete_s_teskocama = N'{dijete.Dijete_s_teskocama}',
                    Napomena = N'{dijete.Napomena}',
                    Roditelj_id = {dijete.Roditelj_id},
                    Skupina_id = {dijete.Skupina_id}
                WHERE Id_dijete = {dijete.Id_dijete}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void ObrisiDijete(int idDijete)
        {
            string sql = $"DELETE FROM Dijete WHERE Id_dijete = {idDijete}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Dijete CreateObject(SqlDataReader reader)
        {
            var dijete = new Dijete
            {
                Id_dijete = int.Parse(reader["Id_dijete"].ToString()),
                Ime = reader["Ime"].ToString(),
                Prezime = reader["Prezime"].ToString(),
                Oib = reader["Oib"].ToString(),
                Datum_rodenja = DateTime.Parse(reader["Datum_rodenja"].ToString()),
                Alergije = reader["Alergije"].ToString(),
                Dijete_s_teskocama = reader["Dijete_s_teskocama"].ToString(),
                Napomena = reader["Napomena"].ToString(),
                Roditelj_id = int.Parse(reader["Roditelj_id"].ToString()),
                Skupina_id = int.Parse(reader["Skupina_id"].ToString()),
                ImeRoditelja = reader["RoditeljIme"]?.ToString(),
                NazivSkupine = reader["SkupinaNaziv"]?.ToString(),
                EmailRoditelja = reader["EmailRoditelja"]?.ToString(),
                TelefonRoditelja = reader["TelefonRoditelja"]?.ToString()

            };

            return dijete;
        }
    }
}
