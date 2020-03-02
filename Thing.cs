using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Thing
    {
        public object Data = default(object);
        public string Process(object input)
        {

            if(Data == input)
            {

                return "Data and input are the same";

            }
            else
            {

                return "Data and input are not the same.";

            }

        }

    }
}
