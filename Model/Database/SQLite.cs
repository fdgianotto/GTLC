using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Globalization;
using System.Diagnostics;

namespace gtlc.Model.Database
{
    class SQLite
    {
        private readonly SQLiteConnection _dbConnection;

        /// <summary>
        /// Default Constructor for SQLiteDatabase Class.
        /// </summary>
        public SQLite()
        {
            _dbConnection = new SQLiteConnection("Data Source=default.db");
        }

        public bool OpenConnection()
        {
            try
            {
                if (_dbConnection.State == ConnectionState.Closed)
                    _dbConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }

            return false;
        }

        public bool CloseConnection()
        {
            try
            {
                _dbConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }

            return false;
        }

        /// <summary>
        /// Gets the specified table from the Database.
        /// </summary>
        /// <param name="sql">The table to retrieve from the database.</param>
        /// <returns>A DataTable containing the result set.</returns>
        public DataTable GetDataTable(string sql)
        {
            var table = new DataTable();

            try
            {
                using (SQLiteTransaction transaction = _dbConnection.BeginTransaction())
                {
                    using (var cmd = new SQLiteCommand(_dbConnection) { Transaction = transaction, CommandText = sql })
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            table.Load(reader);
                            transaction.Commit();
                        }
                    }
                }

                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }
            finally
            {
                table.Dispose();
            }

            return null;
        }


        /// <summary>
        /// Executes a NonQuery against the database.
        /// </summary>
        /// <param name="sql">The SQL to execute.</param>
        /// <returns>A double containing the time elapsed since the method has been executed.</returns>
        public double? ExecuteNonQuery(string sql)
        {
            Stopwatch s = Stopwatch.StartNew();

            try
            {
                using (SQLiteTransaction transaction = _dbConnection.BeginTransaction())
                {
                    using (var cmd = new SQLiteCommand(_dbConnection) { Transaction = transaction })
                    {
                        cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        
                        transaction.Commit();
                    }
                }
                s.Stop();

                return s.Elapsed.TotalMinutes;
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }

            return null;
        }

        /// <summary>
        /// Gets a single value from the database.
        /// </summary>
        /// <param name="sql">The SQL to execute.</param>
        /// <returns>Returns the value retrieved from the database.</returns>
        public string ExecuteScalar(string sql)
        {
            try
            {
                using (SQLiteTransaction transaction = _dbConnection.BeginTransaction())
                {
                    using (var cmd = new SQLiteCommand(_dbConnection) { Transaction = transaction, CommandText = sql })
                    {
                        object value = cmd.ExecuteScalar();
                        transaction.Commit();
                        return value != null ? value.ToString() : "";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }

            return null;
        }

        /// <summary>
        /// Updates specific rows in the database.
        /// </summary>
        /// <param name="tableName">The table to update.</param>
        /// <param name="data">A dictionary containing Column names and their new values.</param>
        /// <param name="where">The where clause for the update statement.</param>
        /// <returns>A boolean true or false to signify success or failure.</returns>
        public bool Update(String tableName, Dictionary<String, String> data, String where)
        {
            string vals = "";
            if (data.Count >= 1)
            {
                vals = data.Aggregate(vals,
                                      (current, val) =>
                                      current +
                                      String.Format(" {0} = '{1}',", val.Key.ToString(CultureInfo.InvariantCulture),
                                                    val.Value.ToString(CultureInfo.InvariantCulture)));
                vals = vals.Substring(0, vals.Length - 1);
            }
            try
            {

                Debug.WriteLine("update {0} set {1} where {2};", tableName, vals, where);
                ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }

            return false;
        }

        /// <summary>
        /// Deletes specific rows in the database.
        /// </summary>
        /// <param name="tableName">The table from which to delete.</param>
        /// <param name="where">The where clause for the delete.</param>
        /// <returns>A boolean true or false to signify success or failure.</returns>
        public bool Delete(String tableName, String where)
        {
            try
            {
                ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }

            return false;
        }

        /// <summary>
        /// Inserts new data to the database.
        /// </summary>
        /// <param name="tableName">The table into which the data will be inserted.</param>
        /// <param name="data">A dictionary containing Column names and data to be inserted.</param>
        /// <returns>A boolean true or false to signify success or failure.</returns>
        public bool Insert(String tableName, Dictionary<String, String> data)
        {
            string columns = "";
            string values = "";
            foreach (var val in data)
            {
                columns += String.Format(" {0},", val.Key);
                values += String.Format(" '{0}',", val.Value);
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            try
            {
                ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("SQLite Exception : {0}", e.Message);
            }

            return false;
        }
    }
}
