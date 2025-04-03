using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGenerics
{
    internal class Person
    {
        public string  Fname { get; set; }
        public string  Lname { get; set; }
        public override string ToString() => $"{Fname} - {Lname}";
        

    }
}
