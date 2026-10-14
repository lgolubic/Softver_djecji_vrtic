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
    public class RacuniRepository
    {
        public static Racun GetRacun(int id)
        {
            Racun racun = null;
            string sql = $"SELECT * FROM Racun WHERE id_racun = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                racun = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return racun;
        }

        public static List<Racun> GetRacuni()
        {
            List<Racun> racuni = new List<Racun>();
            string sql = @"
               SELECT r.*, 
               roditelj.Ime + ' ' + roditelj.Prezime AS RoditeljImePrezime,
               dijete.Ime + ' ' + dijete.Prezime AS DijeteImePrezime
               FROM Racun r
               LEFT JOIN Roditelj roditelj ON r.Roditelj_id = roditelj.Id_roditelj
               LEFT JOIN Dijete dijete ON r.Dijete_id = dijete.Id_dijete";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Racun racun = CreateObject(reader);
                racuni.Add(racun);
            }
            reader.Close();
            DB.CloseConnection();
            return racuni;
        }


        private static Racun CreateObject(SqlDataReader reader)
        {
            var racun = new Racun
            {
                Id_racun = int.Parse(reader["Id_racun"].ToString()),
                Mjesec = reader["Mjesec"].ToString(),
                Skupina = reader["Skupina"].ToString(),
                Izostanci = int.Parse(reader["Izostanci"].ToString()),
                Sati_boravka = int.Parse(reader["Sati_boravka"].ToString()),
                Roditelj_id = int.Parse(reader["Roditelj_id"].ToString()),
                Dijete_s_teskocama = reader["Dijete_s_teskocama"].ToString(),

                
                Osnovna_cijena = decimal.Parse(reader["Osnovna_cijena"].ToString()),
                Izostanci_cijena = decimal.Parse(reader["Izostanci_cijena"].ToString()),
                Ukupna_cijena = decimal.Parse(reader["Ukupna_cijena"].ToString()),

                Dijete_id = int.Parse(reader["Dijete_id"].ToString()),
                ImePrezimeRoditelja = reader["RoditeljImePrezime"]?.ToString(),
                ImePrezimeDjeteta = reader["DijeteImePrezime"]?.ToString()
            };
            return racun;
        }



    }
}
