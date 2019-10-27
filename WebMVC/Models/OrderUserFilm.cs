using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.Models
{
    public class OrderUserFilm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public Film Film { get; set; }
    }
}
