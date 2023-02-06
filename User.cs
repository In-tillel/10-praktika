using System;
using System.Collections.Generic;
using System.Text;

namespace _10_praktika
{
    internal class User
    {
        public string Name { get; set; }
        public string Salt { get; set; }
        public string SaltedHashedPassword { get; set; }
        public string[] Roles { get; set; }
    }
}
