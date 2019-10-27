using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Npgsql;

namespace TestDb
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public City City { get; set; }
    }

    public static class UserConverter
    {
        public static User ConvertOne(DbDataRecord row)
        {
            var usr = new User
            {
                Id = row["id"].GetValue<int>(),
                Name = row["name"].GetValue<string>(),
                Age = row["age"].GetValue<int>(),
                City = new City { Id = row["city_id"].GetValue<int>() }
            };
            return usr;
        }

        public static IEnumerable<User> Convert(NpgsqlDataReader table)
        {
            List<User> users = new List<User>();
            if (table.HasRows)
            {
                foreach(DbDataRecord row in table)
                { 
                    users.Add(ConvertOne(row));
                }
            }
            return users;
        }
    }
}
