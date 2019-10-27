using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreMVC.Models;

namespace WebCoreMVC.Datas
{
    public static class UserFactoryDatas
    {
        public static IEnumerable<User> GetUsers(int fromIndex = 1, int count = 100, string filter="")
        {
            for(int i = fromIndex; i < fromIndex + count; i++)
            {
                yield return new User(i, $"Test {filter} {i} {DateTime.Now:HH:mm}", $"Deptr {i}", $"Role {i}");
            }
        }

        public static User GetUser(int id)
        {
            return new User(id, $"Test {id} {DateTime.Now:HH:mm}", $"Deptr {id}", $"Role {id}");
        }
    }
}
