using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDb
{
    public class DBRepository
    {
        protected string connectionString = "Host=localhost;Username=postgres;Password=sasov1993;Database=test";

        protected NpgsqlConnection connect;

        public DBRepository()
        {
        }

        protected void Open()
        {
            connect = new NpgsqlConnection(connectionString);
            connect.Open();
        }

        public NpgsqlDataReader Execute(string command)
        {
            connect = new NpgsqlConnection(connectionString);
            connect.Open();
            var cmd = new NpgsqlCommand(command, this.connect);
            var res = cmd.ExecuteReader();
            return res;
        }

        public void Close()
        {
            connect.Close();
        }

        ~DBRepository()
        {
            connect.Close();
        }
    }
}
