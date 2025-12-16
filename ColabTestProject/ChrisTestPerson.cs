using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColabTestProject
{
    internal class ChrisTestPerson(string name)
    {
        public string Name { get; set; } = name;

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
