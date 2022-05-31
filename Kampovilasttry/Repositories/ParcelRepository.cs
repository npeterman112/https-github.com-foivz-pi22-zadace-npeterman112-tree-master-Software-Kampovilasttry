using DBLayer;
using Kampovilasttry.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampovilasttry.Repositories
{
    public class ParcelRepository
    {
        public static Parcel GetParcel(int id)
        {
            Parcel parcel = null;
            string sql = $"SELECT * FROM Parcels WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                parcel = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return parcel;
        }
        public static List<Parcel> GetParcels()
        {

            List<Parcel> parcels = new List<Parcel>();
            string sql = "SELECT * FROM PArcels";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Parcel parcel = CreateObject(reader);
                parcels.Add(parcel);
            }
            reader.Close();
            DB.CloseConnection();
            return parcels;
        }
        private static Parcel CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string type = reader["Type"].ToString();
            string season = reader["Season"].ToString();
            int capacity = int.Parse(reader["Capacity"].ToString());
            int price = int.Parse(reader["Price"].ToString());
            

            var parcel = new Parcel
            {
                Id = id,
                Type = type,
                Season = season,
                Capacity = capacity,
                Price=price,
              
            };

            return parcel;
        }
    }
}
