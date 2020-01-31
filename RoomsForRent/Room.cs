using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomsForRent
{
    class Room
    {
        public Student Student { get; set; }

        public override string ToString()
        {
            return Student.Name + ", " + Student.Email;
        }
    }
}
