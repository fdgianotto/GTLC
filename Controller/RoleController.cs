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
    class RoleController : DefaultController
    {
        public readonly String TABLE = GetTable(TablesEnum.ROLE);
        public readonly String IDFIELDNAME = GetIdFieldName(TablesEnum.ROLE);

        public void Create(Role role)
        {
            RoleDAO roleDAO = new RoleDAO();

            roleDAO.Create(TABLE, role.AssembleDictionary());
        }

        public DataTable Read(String searchText, Boolean listSwitch)
        {
            RoleDAO roleDAO = new RoleDAO();

            return roleDAO.ReadActive(TABLE, searchText, listSwitch);
        }

        public void Update(Role role)
        {
            RoleDAO roleDAO = new RoleDAO();

            roleDAO.Update(TABLE, IDFIELDNAME, role.AssembleDictionary(), role.Id);
        }

        public void Delete(Role role)
        {
            RoleDAO roleDAO = new RoleDAO();

            role.Active = 0;

            roleDAO.Update(TABLE, IDFIELDNAME, role.AssembleDictionary(), role.Id);
        }
    }
}
