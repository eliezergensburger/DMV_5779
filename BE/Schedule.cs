using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Schedule
    {
        public bool[,] data = new bool[5, 6];

        public Schedule()
        {

        }

        public Schedule(bool[,] data)
        {
            this.data = data;
        }

        public Schedule Clone()
        {
            Schedule result = new Schedule((bool[,])this.data.Clone());
            return result;
        }
        public override string ToString()
        {
            int starttime = 9;
            string result = null;
            for (int i = 0; i < 5; i++)
            {
                result += ((Day)i).ToString() + "\n";
                for (int j = 0; j < 6; j++)
                {
                    result += (data[i, j] == true) ? ("\t" + (starttime + i) + ":00-" + (starttime + i + 1).ToString() + ":00\n") : "";
                }
            }
            return result;
        }
    }
}
