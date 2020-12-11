using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerate
{

    //THIS SINGLETON CLASS IS FOR CONNECTING TO THE DATABASE
    //USED FOR ADDING/SETTING VALUES, AND RETURNING TABLES

    /// <summary>
    /// Used to add and set values to database, as well as remove. Anything that needs more than a single value returned
    /// </summary>
    /// <returns>
    /// Single instance of the connection, dataSet
    /// </returns>
    class DBConnection
    {
        private static DBConnection _instance;
        private string connStr; //Our connection string is here 
        private SqlConnection connToDB; 


        private DBConnection()
        {
            connStr = Properties.Settings.Default.MainDBConnStr;
        
        }

        public static DBConnection getInstanceOfDBConnection() //Allows a single instance at a time 
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(connStr)) //Takes user's query as the paramters into this
            {
                connToDB.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);
                dataAdapter.Fill(dataSet);
            }
            return dataSet;
        }

        
        }




    }
