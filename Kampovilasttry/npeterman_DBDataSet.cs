namespace Kampovilasttry
{


    partial class npeterman_DBDataSet
    {
        partial class PersonDataTable
        {
        }

        partial class GuestsDataTable
        {
            readonly int _ID;


            private readonly int _GuestId;
            private readonly string _FirstName;
            private readonly string _LastName;
            readonly string _Phone;
            string _OIB;

            public GuestsDataTable(string oIB)
            {
                _OIB = oIB;
            }

            int _Age;

            public override bool Equals(object obj)
            {
                return obj is GuestsDataTable table &&
                       _GuestId == table._GuestId;
            }

            public override int GetHashCode()
            {
                return 432852671 + _GuestId.GetHashCode();
            }
        }
    }
}
