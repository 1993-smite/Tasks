using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace TestDb
{
    public class UserRepository : DBRepository
    {
        public UserRepository() : base()
        {
        }

        public NpgsqlDataReader GetUsers()
        {
            return Execute("SELECT * FROM public.users");
        }

        private NpgsqlDataReader InsertUser(User user)
        {
            return Execute("INSERT INTO " +
                "public.users(id, name, age, city_id) " +
                $"VALUES({user.Id}, '{user.Name}', {user.Age}, {user.City?.Id}); ");
        }

        private NpgsqlDataReader UpdateUser(User user)
        {
            return Execute("UPDATE public.users " +
                $"SET name='{user.Name}', age={user.Age}, city_id={user.City?.Id} " +
                $"WHERE users.id={user.Id}; ");
        }

        public NpgsqlDataReader GetUser(int userId)
        {
            return Execute($"SELECT * FROM public.users where users.id={userId}");
        }

        public void SaveUser(User user)
        {
            var usr = GetUser(user.Id);
            var isUser = usr.HasRows;
            base.Close();
            if (isUser)
            {
                UpdateUser(user);
            }
            else
            {
                InsertUser(user);
            }
            base.Close();
        }
    }
}
