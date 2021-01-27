using System;
using System.Collections.Generic;
using System.Text;

namespace DenemeInterface
{
    class Student : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int StudentNumber { get; set; }
    }
}
