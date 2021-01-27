using System;
using System.Collections.Generic;
using System.Text;

namespace DenemeInterface
{
    class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string HomeAddress { get; set; }
    }
}
