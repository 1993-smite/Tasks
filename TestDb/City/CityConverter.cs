using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Npgsql;

namespace TestDb
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class CityConverter
    {
        public static City ConvertOne(DbDataRecord row)
        {
            var city = new City
            {
                Id = row["id"].GetValue<int>(),
                Name = row["name"].GetValue<string>()
            };
            return city;
        }

        public static IEnumerable<City> Convert(NpgsqlDataReader table)
        {
            List<City> cities = new List<City>();
            if (table.HasRows)
            {
                foreach(DbDataRecord row in table)
                {
                    cities.Add(ConvertOne(row));
                }
            }
            return cities;
        }
    }
}
