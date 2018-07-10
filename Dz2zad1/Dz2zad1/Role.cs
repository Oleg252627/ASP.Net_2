using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz2zad1
{
    public class Role
    {
        public string Name { get; set; }

        public Role(string name)
        {
            Name = name;
        }

        public void Rename_Role(string name)
        {
            Name = name;
        }
    }
}