using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.hafta
{
    internal class Employee
    {
        public int _id { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public Employee(string firstName, string lastName, int id )
        {
            
            this._firstName = firstName;
            this._lastName = lastName;
            this._id = id;
        }


    }
}