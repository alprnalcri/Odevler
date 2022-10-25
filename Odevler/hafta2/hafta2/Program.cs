using _2.hafta;
using System;

namespace hafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Alperen", "Alaçeri",1);
            Employee employee1 = new Employee("Burak", "Özen",2);
            Employee employee2 = new Employee("Ali", "Dağ",3);



            EmployeeeAddRem employeeManager = new EmployeeeAddRem();

            employeeManager.Create(employee);
            employeeManager.Create(employee1);
            employeeManager.Delete(2);
            employeeManager.Delete(552);
            employeeManager.ReadList();



        }
    }
}
