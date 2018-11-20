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
        public CarType Expertise { get; set; }
        public int MaxDistance { get; set; }

        public override string ToString()
        {
            return this.ToStringProperty();
        }

        public new Tester Clone()
        {
            return new Tester
            {
                Address = this.Address.Clone(),
                DayOfBirth = this.DayOfBirth,
                Expertise = this.Expertise,
                Gender = this.Gender,
                ID = this.ID,
                MaxDistance = this.MaxDistance,
                Name = this.Name
            };
          }
    }
}
