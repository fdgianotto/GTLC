using gtlc.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtlc.Controller
{
    class DefaultController
    {
        public static String GetTable(Enum enumInt)
        {
            switch (enumInt)
            {
                case TablesEnum.RECORD: return "Records";
                case TablesEnum.TEAM: return "Teams";
                case TablesEnum.ROLE: return "Roles";
                case TablesEnum.CITY: return "Cities";
            }

            return null;
        }

        public static String GetIdFieldName(Enum enumInt)
        {
            switch (enumInt)
            {
                case TablesEnum.RECORD: return "RecordID";
                case TablesEnum.TEAM: return "TeamID";
                case TablesEnum.ROLE: return "RoleID";
                case TablesEnum.CITY: return "CityID";
            }

            return null;
        }
    }
}
