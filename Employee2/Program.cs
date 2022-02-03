using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);


            Employee o4 = new Employee(101,"DNAYNESHWAR",7000);
            Console.WriteLine(o4.EmpNo);
            Console.WriteLine(o4.DeptNo);
            Console.WriteLine(o4.Name);
            Console.WriteLine(o4.Basic);
        

            Console.ReadLine();


        }
    }


    class Employee
    {

        
        private static int counter = 125;
        private string name;
        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("name can't be blank");
                }
                else
                {
                    name = value;

                }
            }
            get
            {
                return name;
            }
        }
        private int empNo = 0;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value < 5000 || value > 10000)
                {
                    Console.WriteLine("Basic Salary between 5000-10000");
                }
                else
                {
                    basic = value;
                }
            }
            get
            {
                return basic;

            }
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("DeptNo must be > 0");
                }
                else
                {
                    deptNo = value;
                }
            }
            get
            {
                return deptNo;
            }
        }
    

        public Employee( short DeptNo, string Name, decimal Basic)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            this.empNo = ++counter;

        }
        public Employee( decimal Basic, string Name)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.empNo = ++counter;

        }
        public Employee(string Name)
        {
            this.Name = Name;
            this.empNo = ++counter;

        }

        public Employee()
        {
            this.empNo = ++counter;


        }
      
        public decimal GetNetSalary()
        {
            decimal tax = 100;
            decimal houseAllowance = 1000;
            decimal provident = 500;
            return this.Basic + tax + houseAllowance + provident;
        }


    }


}
