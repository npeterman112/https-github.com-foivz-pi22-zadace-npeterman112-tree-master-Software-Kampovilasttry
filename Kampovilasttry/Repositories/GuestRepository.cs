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
    public class GuestRepository {
       

        public static Guest GetGuest(int id, npeterman_DBDataSet npeterman_DBDataSet)
        {
            

            Guest guest = null;
            string sql = $"SELECT * FROM Guests WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                guest = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return guest;
        }

        private static void SetConfiguration(npeterman_DBDataSet npeterman_DBDataSet)
        {
            throw new NotImplementedException();
        }

        public static List<Guest> GetGuests()
        {
            var guests = new List<Guest>();
            string sql = "SELECT * FROM Guests";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Guest guest = CreateObject(reader);
                guests.Add(guest);
            }
            reader.Close();
            DB.CloseConnection();
            return guests;
        }
        private static Guest CreateObject(SqlDataReader reader)
        {
            int guestid = int.Parse(reader["GuestId"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string phone = reader["Phone"].ToString();
            string oib = reader["OIB"].ToString();
            int age = int.Parse(reader["Age"].ToString());
            var guest = new Guest
            {
                GuestId = guestid,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                OIB = oib,
                Age = age
            };
            return guest;
        }

    }

}
