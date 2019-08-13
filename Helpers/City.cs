using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtlc.Helpers
{
    class City : BasicEntity
    {
        public City()
        {

        }

        public City(int id, String name, int active)
        {
            this.Id = id;
            this.Name = name;
            this.Active = active;
        }
    }
}
