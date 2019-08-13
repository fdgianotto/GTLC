using gtlc.Model.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtlc.Model.DAO
{
    class DefaultDAO
    {
        public virtual void Create(String enumString, Dictionary<String, String> createDictionary)
        {
            SQLite database = new SQLite();

            database.OpenConnection();

            database.Insert(enumString, createDictionary);

            database.CloseConnection();
        }

        public virtual DataTable Read(String column, String enumString, String filter)
        {
            SQLite database = new SQLite();

            database.OpenConnection();

            DataTable dataTable = database.GetDataTable(String.Format("SELECT {0} FROM {1} {2}", column, enumString, filter));

            database.CloseConnection();

            return dataTable;
        }

        public DataTable ReadActive(String enumString, String searchText, Boolean listSwitch)
        {
            SQLite database = new SQLite();

            database.OpenConnection();

            int active;

            if (listSwitch)
            {
                active = 0;
            }
            else
            {
                active = 1;
            }

            DataTable dataTable = database.GetDataTable(String.Format("SELECT * FROM {0} WHERE Active = {1} AND Name LIKE '%{2}%'", enumString, active, searchText));

            database.CloseConnection();

            return dataTable;
        }

        public virtual void Update(String enumString, String idFieldName, Dictionary<String, String> updateDictionary, int idFieldValue)
        {
            SQLite database = new SQLite();

            database.OpenConnection();

            database.Update(enumString, updateDictionary, idFieldName + " LIKE " + idFieldValue);

            database.CloseConnection();
        }
    }
}
