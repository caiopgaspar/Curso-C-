using System;
using System.Collections.Generic;
using System.Text;

namespace AulaComposicao1.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }
    }
}
