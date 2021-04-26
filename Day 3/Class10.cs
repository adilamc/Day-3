using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    abstract class Employee//abstract
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        //public abstract string AbstractMethod()
        //{
        //    return "i'm derived class abstractMethod";
        //}
        public Employee(int _employeeId, string _employeeName)
        {
            EmployeeId = _employeeId;
            EmployeeName = _employeeName;
        }
        
    }
    class Class10:Employee//concrete class
    {
        Class10(int _employeeId, string _employeeName):base(_employeeId,_employeeName)
        {

        }
        public void PrintData()
        {
            Console.WriteLine("EmployeeId" + EmployeeId);
            Console.WriteLine("EmployeeName" + EmployeeName);
        }
        public static void Main()
        {
            Class10 e = new Class10(101,"Adila");

            e.PrintData();
            Console.ReadLine();
        }
    }
}
