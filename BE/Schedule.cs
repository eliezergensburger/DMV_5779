using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Schedule
    {
        public bool[][] Data { get; set; }// = new bool[5][];
        public override string ToString()
        {
           // sarting working hour of the day
            int starttime = 9;
            //flag designing if the driver work in this day
            bool oved = false;
            string result = null;
            string hayom = null;
            for (int i = 0; i < 5; i++)
            {
                oved = false;
                hayom = null;
                //result += ((Day)i).ToString() + "\n";
                //working only 6 hours a day
                for (int j = 0; j < 6; j++)
                {
                    if (Data[i][j] == true)
                    {
                        oved = true;
                        hayom += "\t" + (starttime + j) + ":00-";
                        hayom += (starttime + j + 1).ToString() + ":00\n";
                    }
                }
                if (oved == true)
                {
                    result += ((Day)i).ToString() + "\n";
                    result += hayom;
                }
            }
            if (result !=null && result.Length > 1)
            {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }
    }
}
