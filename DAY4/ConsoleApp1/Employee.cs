using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string EmpName { get; set; }
        public int EmpId { get; set; }
        public virtual void Display()
        {
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Employee ID: " + EmpId);
        }
    }
}
