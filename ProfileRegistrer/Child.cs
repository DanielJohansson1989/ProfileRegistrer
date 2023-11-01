using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileRegistrer
{
    internal class Child : Person
    {
        private string _ageCathegory = "Child";

        public Child(string name, int age, string gender, string address) : base (name, age, gender, address)
        { 
        
        }

        public string AgeCathegory
        {
            get { return _ageCathegory; }
        }
    }
}
