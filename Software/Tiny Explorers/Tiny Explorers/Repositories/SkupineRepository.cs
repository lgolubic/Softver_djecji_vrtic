using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Tiny_Explorers.Models;

namespace Tiny_Explorers.Repositories
{
    public class SkupineRepository
    {
        public List<Skupina> DohvatiSveSkupine()
        {
            List<Skupina> lista = new List<Skupina>();
            string sql = "SELECT * FROM Skupina";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                lista.Add(CreateObject(reader));
            }
            reader.Close();
            DB.CloseConnection();
            return lista;
        }

       
        public int GetNextIdSkupina()
        {
            int maxId = 0;
            string sql = "SELECT ISNULL(MAX(id_skupina), 0) FROM Skupina";
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

        public void DodajSkupinu(Skupina novaSkupina)
        {
           
            int noviId = GetNextIdSkupina();
            novaSkupina.Id_skupina = noviId;

            string sql = $"INSERT INTO Skupina (id_skupina, naziv, dobni_raspon, max_kapacitet, broj_upisanih) " +
                         $"VALUES ({novaSkupina.Id_skupina}, '{novaSkupina.Naziv}', '{novaSkupina.DobniRaspon}', {novaSkupina.MaxKapacitet}, {novaSkupina.BrojUpisanih})";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void AzurirajSkupinu(Skupina skupina)
        {
            string sql = $"UPDATE Skupina SET " +
                         $"naziv = '{skupina.Naziv}', " +
                         $"dobni_raspon = '{skupina.DobniRaspon}', " +
                         $"max_kapacitet = {skupina.MaxKapacitet}, " +
                         $"broj_upisanih = {skupina.BrojUpisanih} " +
                         $"WHERE id_skupina = {skupina.Id_skupina}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void ObrisiSkupinu(int idSkupina)
        {
            string sql = $"DELETE FROM Skupina WHERE id_skupina = {idSkupina}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public Skupina GetSkupina(int idSkupina)
        {
            Skupina skupina = null;
            string sql = $"SELECT * FROM Skupina WHERE id_skupina = {idSkupina}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                skupina = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return skupina;
        }

        private Skupina CreateObject(SqlDataReader reader)
        {
            return new Skupina
            {
                Id_skupina = Convert.ToInt32(reader["id_skupina"]),
                Naziv = reader["naziv"].ToString(),
                DobniRaspon = reader["dobni_raspon"].ToString(),
                MaxKapacitet = Convert.ToInt32(reader["max_kapacitet"]),
                BrojUpisanih = Convert.ToInt32(reader["broj_upisanih"])
            };
        }
    }
}
