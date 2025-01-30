using System;
using ConsoleApp1;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpName = "David";
            emp.EmpId = 101;
            emp.Display();

            Department dept = new Department();
            dept.EmpName = "James";
            dept.EmpId = 102;
            dept.DeptName = "IT";
            dept.Salary = 10000;
            dept.Display();

            Manager mgr = new Manager();
            mgr.EmpName = "John";
            mgr.EmpId = 103;
            mgr.DeptName = "HR";
            mgr.Salary = 20000;
            mgr.ManagerName = "Robert";
            mgr.Display();

        }
    }
}