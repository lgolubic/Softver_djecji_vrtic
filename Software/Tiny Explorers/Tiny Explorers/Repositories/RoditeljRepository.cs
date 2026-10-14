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
    public class RoditeljRepository
    {
            public static Roditelj GetRoditelj(int id)
            {
                Roditelj roditelj = null;
                string sql = $"SELECT * FROM Roditelj WHERE id_roditelj = {id}";
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                if (reader.HasRows)
                {
                    reader.Read();
                    roditelj = CreateObject(reader);
                    reader.Close();
                }
                DB.CloseConnection();
                return roditelj;
            }

            public static List<Roditelj> GetRoditelji()
            {
                List<Roditelj> roditelji = new List<Roditelj>();
                string sql = "SELECT * FROM Roditelj";
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    Roditelj roditelj = CreateObject(reader);
                    roditelji.Add(roditelj);
                }
                reader.Close();
                DB.CloseConnection();
                return roditelji;
            }

            private static Roditelj CreateObject(SqlDataReader reader)
            {
                int id = int.Parse(reader["Id_roditelj"].ToString());
                string ime = reader["Ime"].ToString();
                string prezime = reader["Prezime"].ToString();
                string email = reader["Email"].ToString();
                string telefon = reader["Telefon"].ToString();

            var roditelj = new Roditelj
                {
                    Id_roditelj = id,
                    Ime = ime,
                    Prezime = prezime,
                    Email = email,
                    Telefon = telefon,
                };
                return roditelj;
            }
    }
}
