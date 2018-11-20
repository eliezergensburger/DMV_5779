using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;
namespace BE
{
    public class Address
    {
        public String StreetName { get; set; }
        public int Number { get; set; }
        public String City { get; set; }
        public int ZipCode { get; set; }

        public override string ToString()
        {
            return this.ToStringProperty();
        }

    }
}
