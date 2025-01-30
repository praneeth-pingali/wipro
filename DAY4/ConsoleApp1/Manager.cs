using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Manager : Department
    {
        public string ManagerName { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Manager Name: " + ManagerName);
        }
    }
}
