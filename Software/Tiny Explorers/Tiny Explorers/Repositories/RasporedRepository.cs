using System.Collections.Generic;
using System.Data.SqlClient;
using Tiny_Explorers.Models;
using DBLayer;
using System;

public class RasporedRepository
{
    public List<Raspored> GetAll()
    {
        var list = new List<Raspored>();
        DB.OpenConnection();

        var reader = DB.GetDataReader("SELECT * FROM Raspored");

        while (reader.Read())
        {
            list.Add(new Raspored
            {
                Id = (int)reader["id_raspored"],
                Datum = (DateTime)reader["datum"],
                Smjena = reader["smjena"].ToString(),
                Zamjena = reader["zamjena"].ToString(),
                ZaposlenikId = (int)reader["zaposlenik_id"]
            });
        }

        reader.Close();
        DB.CloseConnection();

        return list;
    }

    public void Add(Raspored r)
    {
        DB.OpenConnection();

        var cmd = DB.CreateCommand(
            "INSERT INTO Raspored (id_raspored, datum, smjena, zamjena, zaposlenik_id) " +
            "VALUES (@id, @datum, @smjena, @zamjena, @zaposlenik_id)"
        );
        cmd.Parameters.AddWithValue("@id", r.Id);  // 🆕 Include ID manually
        cmd.Parameters.AddWithValue("@datum", r.Datum);
        cmd.Parameters.AddWithValue("@smjena", r.Smjena);
        cmd.Parameters.AddWithValue("@zamjena", r.Zamjena);
        cmd.Parameters.AddWithValue("@zaposlenik_id", r.ZaposlenikId);

        cmd.ExecuteNonQuery();
        DB.CloseConnection();
    }


    public void Update(Raspored r)
    {
        DB.OpenConnection();

        var cmd = DB.CreateCommand("UPDATE Raspored SET datum = @datum, smjena = @smjena, zamjena = @zamjena, zaposlenik_id = @zaposlenik_id WHERE id_raspored = @id");
        cmd.Parameters.AddWithValue("@datum", r.Datum);
        cmd.Parameters.AddWithValue("@smjena", r.Smjena);
        cmd.Parameters.AddWithValue("@zamjena", r.Zamjena);
        cmd.Parameters.AddWithValue("@zaposlenik_id", r.ZaposlenikId);
        cmd.Parameters.AddWithValue("@id", r.Id);

        cmd.ExecuteNonQuery();
        DB.CloseConnection();
    }

    public void Delete(int id)
    {
        DB.OpenConnection();

        var cmd = DB.CreateCommand("DELETE FROM Raspored WHERE id_raspored = @id");
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
        DB.CloseConnection();
    }

    public int GetNextId()
    {
        DB.OpenConnection();

        var cmd = DB.CreateCommand("SELECT ISNULL(MAX(id_raspored), 0) + 1 FROM Raspored");
        int nextId = (int)cmd.ExecuteScalar();

        DB.CloseConnection();
        return nextId;
    }

}
