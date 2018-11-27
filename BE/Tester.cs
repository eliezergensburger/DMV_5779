﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace BE
{
    public class Tester : Person
    {
        public Schedule Luz { get; set; }
        public CarType Expertise { get; set; }
        public int Experience { get; set; }
        public int MaxTestWeekly { get; set; }
        public int MaxDistance { get; set; }

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
                Luz = this.Luz.Clone()
             };
             return result;
        }
    }
}
