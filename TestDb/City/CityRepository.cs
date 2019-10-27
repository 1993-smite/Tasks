using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace TestDb
{
    public class CityRepository : DBRepository
    {
        public CityRepository() : base()
        {
        }

        public NpgsqlDataReader GetCities()
        {
            return Execute("SELECT * FROM public.cities");
        }

        private NpgsqlDataReader InsertCity(City city)
        {
            return Execute("INSERT INTO " +
                "public.cities(id, name) " +
                $"VALUES({city.Id}, '{city.Name}');");
        }

        private NpgsqlDataReader UpdateCity(City city)
        {
            return Execute("UPDATE public.cities " +
                $"SET name='{city.Name}'" +
                $"WHERE cities.id={city.Id}; ");
        }

        public NpgsqlDataReader GetCity(int cityId)
        {
            return Execute($"SELECT * FROM public.cities where cities.id={cityId}");
        }

        public void SaveCity(City city)
        {
            var usr = GetCity(city.Id);
            var isUser = usr.HasRows;
            base.Close();
            if (isUser)
            {
                UpdateCity(city);
            }
            else
            {
                InsertCity(city);
            }
            base.Close();
        }
    }
}
