using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileRegistrer
{
    internal class Adult : Person
    {
        private string _ageCathegory = "Adult";
        public Adult(string name, int age, string gender, string address) : base (name, age, gender, address)
        {
            
        }

        public string AgeCathegory 
        {
            get { return _ageCathegory; }
        }
    }
}
