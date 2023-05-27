using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningSolutions.Models
{
    public class Owner : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
