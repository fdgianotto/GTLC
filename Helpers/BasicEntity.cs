using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtlc.Helpers
{
    class BasicEntity
    {
        private int id;
        private String name;
        private int active;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Active { get => active; set => active = value; }

        public Dictionary<String, String> AssembleDictionary()
        {
            Dictionary<String, String> basicEntityDictionary = new Dictionary<String, String>
            {
                { "Name", Name },
                { "Active", Active.ToString() }
            };

            return basicEntityDictionary;
        }
    }
}
