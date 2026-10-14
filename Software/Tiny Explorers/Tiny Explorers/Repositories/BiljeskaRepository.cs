using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Tiny_Explorers.Models;
using DBLayer;

namespace Tiny_Explorers.Repositories
{
    public class BiljeskaRepository
    {
        public List<Biljeska> GetAll()
        {
            var list = new List<Biljeska>();
            DB.OpenConnection();

            var reader = DB.GetDataReader("SELECT * FROM Biljeska");

            while (reader.Read())
            {
                list.Add(MapReaderToBiljeska(reader));
            }

            reader.Close();
            DB.CloseConnection();

            return list;
        }

        public List<Biljeska> GetByNaziv(string naziv)
        {
            var list = new List<Biljeska>();
            DB.OpenConnection();

            var cmd = DB.CreateCommand("SELECT * FROM Biljeska WHERE naziv = @naziv");
            cmd.Parameters.AddWithValue("@naziv", naziv);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapReaderToBiljeska(reader));
            }

            reader.Close();
            DB.CloseConnection();

            return list;
        }

        public List<Biljeska> GetByDijeteId(int dijeteId)
        {
            var list = new List<Biljeska>();
            DB.OpenConnection();

            var cmd = DB.CreateCommand("SELECT * FROM Biljeska WHERE dijete_id = @dijeteId");
            cmd.Parameters.AddWithValue("@dijeteId", dijeteId);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapReaderToBiljeska(reader));
            }

            reader.Close();
            DB.CloseConnection();

            return list;
        }

        public void Add(Biljeska b)
        {
            DB.OpenConnection();

            // Step 1: Get next ID manually
            var getIdCmd = DB.CreateCommand("SELECT ISNULL(MAX(id_biljeska), 0) + 1 FROM Biljeska");
            int nextId = (int)getIdCmd.ExecuteScalar();

            // Step 2: Insert including id_biljeska
            var cmd = DB.CreateCommand(@"
        INSERT INTO Biljeska (id_biljeska, naziv, datum, opis_biljeske, dodatne_napomene, dijete_id, zaposlenik_id)
        VALUES (@id_biljeska, @naziv, @datum, @opis, @napomene, @dijeteId, @zaposlenik_id)
    ");

            cmd.Parameters.AddWithValue("@id_biljeska", nextId);
            cmd.Parameters.AddWithValue("@naziv", b.Naziv);
            cmd.Parameters.AddWithValue("@datum", b.Datum);
            cmd.Parameters.AddWithValue("@opis", b.OpisBiljeske);
            cmd.Parameters.AddWithValue("@napomene", b.DodatneNapomene);
            cmd.Parameters.AddWithValue("@dijeteId", b.DijeteId);
            cmd.Parameters.AddWithValue("@zaposlenik_id", b.ZaposlenikId);

            cmd.ExecuteNonQuery();
            DB.CloseConnection();
        }


        private Biljeska MapReaderToBiljeska(SqlDataReader reader)
        {
            return new Biljeska
            {
                Id = (int)reader["id_biljeska"],
                Naziv = reader["naziv"].ToString(),
                Datum = (DateTime)reader["datum"],
                OpisBiljeske = reader["opis_biljeske"].ToString(),
                DodatneNapomene = reader["dodatne_napomene"].ToString(),
                DijeteId = (int)reader["dijete_id"],
                ZaposlenikId = (int)reader["zaposlenik_id"]
            };
        }
    }
}
