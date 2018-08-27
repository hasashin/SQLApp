using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
using System.Collections.Generic;

namespace SQLConnections
{
    public class Querry
    {
        public string Select;
        public string From;
        public string Where;
        public string GetCommand()
        {
            return "SELECT " + Select + " FROM " + From + " WHERE " + Where + ";";
        }
    }

    static public class SqlConnect
    {
        private static OdbcConnection Connection = new OdbcConnection();
        private static OdbcCommand Command = new OdbcCommand();
        private static Querry querry = new Querry();
        public static void OpenConnection(string SQLName, string DBName, string Passwd)
        {
            if (SQLName != null && DBName != null && Passwd != null)
            {
                Connection.ConnectionString = "Driver={SQL Server};Server=" + SQLName + ";Database=" + DBName + ";Uid=sa;Pwd=" + Passwd + ";";
                Connection.Open();
            }
            else throw new Exception("Niepowodzenie podczas łączenia się z serwerem SQL. (SqlConnect.OpenConnection() got null)");
        }

        public static void CloseConnection()
        {
            if (Connection.State != ConnectionState.Closed) Connection.Close();
        }

        public static OdbcConnection GetConnection()
        {
            return Connection;
        }
        public static ConnectionState GetConnectionState()
        {
            return Connection.State;
        }
        public static OdbcDataReader ExecuteDataReader(string select, string from, string where)
        {
            querry.Select = select;
            querry.From = from;
            querry.Where = where;
            Command.CommandText = querry.GetCommand();
            Command.Connection = Connection;
            return Command.ExecuteReader();
        }
        public static OdbcDataReader ExecuteDataReader(string command)
        {
            Command.CommandText = command;
            Command.Connection = Connection;
            return Command.ExecuteReader();
        }
        public static bool ExecuteCommand(string command)
        {
            Command.CommandText = command;
            Command.Connection = Connection;
            OdbcDataReader rd = Command.ExecuteReader();
            rd.Close();
            return rd.RecordsAffected != 0;
        }
    }
}
