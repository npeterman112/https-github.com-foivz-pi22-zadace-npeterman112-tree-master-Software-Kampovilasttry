using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampovilasttry.Repositories
{
    public static Guest GetGuest(int id)
    {
        SetConfiguration{npeterman_DB npeterman_DB npeterman_DB }

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

}
