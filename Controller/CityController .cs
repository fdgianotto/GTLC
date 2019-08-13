using gtlc.Helpers;
using gtlc.Model.DAO;
using gtlc.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtlc.Controller
{
    class CityController : DefaultController
    {
        public readonly String TABLE = GetTable(TablesEnum.CITY);
        public readonly String IDFIELDNAME = GetIdFieldName(TablesEnum.CITY);

        public void Create(City city)
        {
            CityDAO cityDAO = new CityDAO();

            cityDAO.Create(TABLE, city.AssembleDictionary());
        }

        public DataTable Read(String searchText, Boolean listSwitch)
        {
            RoleDAO roleDAO = new RoleDAO();

            return roleDAO.ReadActive(TABLE, searchText, listSwitch);
        }

        public void Update(City city)
        {
            RoleDAO roleDAO = new RoleDAO();

            roleDAO.Update(TABLE, IDFIELDNAME, city.AssembleDictionary(), city.Id);
        }

        public void Delete(City city)
        {
            RoleDAO roleDAO = new RoleDAO();

            city.Active = 0;

            roleDAO.Update(TABLE, IDFIELDNAME, city.AssembleDictionary(), city.Id);
        }
    }
}
