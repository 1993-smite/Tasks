using Npgsql;
using System;

namespace TestDb
{
    class Program
    {
        static void Main(string[] args)
        {

            //CityRepository cityRep = new CityRepository();
            UserRepository userRep = new UserRepository();
            Random rand = new Random();
            //var users = UserConverter.Convert(rep.GetUsers());
            var start = DateTime.Now;
            /*for(int i = 1; i < 1000; i++)
            {
                rep.SaveCity(new City { Id = i, Name = $"City{i}" });
            }*/
            var users = UserConverter.Convert(userRep.GetUsers());
            foreach(var user in users)
            {
                user.City = new City { Id = rand.Next(0, 800) };
                //user.Age = rand.Next(10, 100);
                userRep.SaveUser(user);
            }

            userRep.Close();
            var stop = DateTime.Now;
            Console.WriteLine($"{(stop-start).TotalMilliseconds}");
            Console.ReadLine();
        }
    }
}
