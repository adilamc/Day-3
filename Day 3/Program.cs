using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Employee
    {
        private int employeeId;
        private string employeeName;

        public Employee(int _employeeId, string _employeeName)
        {
            employeeId = _employeeId;
            employeeName = _employeeName;
        }
        //public Employee()
        //{
        //    Console.WriteLine("Iam a default constructor");
        //}
        //static Employee()
        //{
         //   Console.WriteLine("Iam a static constructor");
        //}
       // private Employee()
        //{
        //    Console.WriteLine("Iam a private constructor");
        //}
        public Employee(Employee employee)
        {
            employeeId = employee.employeeId;
            employeeName = employee.employeeName;
        }
        public void ShowEmpolyeeDetails()
        {
            Console.WriteLine("Employee name" + employeeName);
            Console.WriteLine("Employee Id" + employeeId);

        }
    ~Employee()
        {

        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Adila");
            Employee emp2 = new Employee(emp1);
            //Employee emp = new Employee();
            emp2.ShowEmpolyeeDetails();
            Console.ReadLine();
        }
    }
}
