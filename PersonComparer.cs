using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class PersonComparer : IComparer<Personen>
    {
        public int Compare(Personen x, Personen y)
        {

            int result = x.Name.Length.CompareTo(y.Name.Length);
            if(result == 0)
            {

                return x.Name.CompareTo(y.Name);

            }
            else
            {

                return result;

            }

        }
    }
}
