using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace BE
{
    public class Tester : Person
    {
        private bool[,] schedule = new bool[5,6];
        public CarType Expertise { get; set; }
        public int Experience { get; set; }
        public int MaxTestWeekly { get; set; }
        public int MaxDistance { get; set; }

        public bool[,] Schedule { get => schedule; set => schedule = value; }

        public override string ToString()
        {
            return this.ToStringProperty();
        }

        public new Tester Clone()
        {
            Tester result = null;
            result =  new Tester
            {
                Address = this.Address.Clone(),
                DayOfBirth = this.DayOfBirth,
                Expertise = this.Expertise,
                Gender = this.Gender,
                ID = this.ID,
                MaxDistance = this.MaxDistance,
                Name = this.Name,
                Experience = this.Experience,
                MaxTestWeekly = this.MaxTestWeekly,
             };
            result.Schedule = new bool[5,6];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++) 
                {
                    result.Schedule[i, j] = this.Schedule[i, j];
                }
            }

            return result;
        }
    }
}
