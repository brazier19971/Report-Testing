using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ReportGenerate
{
    //ALISTAIR BRAZIER 2020

    /// <summary>
    /// A singleton design pattern class that gets a single STRING value from a database
    /// </summary>
    /// <returns>
    /// Single instance of connection, read (single value).
    /// </returns>

    class SingleValueDB
    {
        private static SingleValueDB _instance;
        private string dbString;
        private SqlConnection databaseConnection;

       
        private SingleValueDB()
        {
            dbString = Properties.Settings.Default.MainDBConnStr;

        }

        public static SingleValueDB databaseInstance()
        {
            if (_instance == null)
                _instance = new SingleValueDB();
            return _instance;
        }

        public string getString(string sqlQuery)
        {
            string read;

            using (databaseConnection = new SqlConnection(dbString))
            {
               
                SqlCommand command = new SqlCommand(sqlQuery, databaseConnection);
                databaseConnection.Open();
                read= command.ExecuteScalar().ToString();
                //Microsoft Docs. SqlCommand.ExecuteScalar Method. [online] Available at: <https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.executescalar?view=dotnet-plat-ext-5.0> [Accessed 29 November 2020].
            }

            return read;
        }
    }
}
