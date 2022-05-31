namespace Kampovilasttry
{


    partial class npeterman_DBDataSet
    {
        partial class DataTable1DataTable
        {
            readonly int _ID;


            private readonly int _GuestId;
            private readonly string _FirstName;
            private readonly string _LastName;
            readonly string _Phone;
            string _OIB;

            public DataTable1DataTable(string oIB)
            {
                _OIB = oIB;
            }

            int _Age;

            public override bool Equals(object obj)
            {
                return obj is DataTable1DataTable table &&
                       _GuestId == table._GuestId;
            }

            public override int GetHashCode()
            {
                return 432852671 + _GuestId.GetHashCode();
            }
        }
    }
}
