using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtlc.Helpers
{
    class Role : BasicEntity
    {
        public Role()
        {

        }

        public Role(int id, String name, int active)
        {
            this.Id = id;
            this.Name = name;
            this.Active = active;
        }
    }
}
