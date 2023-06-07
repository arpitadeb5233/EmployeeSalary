using System;
using System.Collections.Generic;


namespace EmployeeConsole
{
    
    public abstract class EmployeeVacation
    {
        public float VacationDays { get; set; }

        protected EmployeeVacation()
        {
            VacationDays = 0;
        }

        public abstract void Work(int days);

        public void TakeVacation(float days)
        {
            if (days <= VacationDays)
            {
                VacationDays -= days;
                Console.WriteLine($"Took {days} vacation days. Remaining vacation days: {VacationDays}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not enough vacation days available.");
                Console.ReadLine();
            }
        }
    }

    public class HourlyEmployee : EmployeeVacation
    {
        public HourlyEmployee()
        {
            VacationDays = 10;
        }

        public override void Work(int days)
        {
            if (days >= 0 && days <= 260)
            {
                Console.WriteLine($"Hourly Employee: Worked {days} days. Vacation days accumulated: {VacationDays}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid number of work days.");
                Console.ReadLine();
            }
        }
    }

    public class SalariedEmployee : EmployeeVacation
    {
        public SalariedEmployee()
        {
            VacationDays = 15;
        }

        public override void Work(int days)
        {
            if (days >= 0 && days <= 260)
            {
                    Console.WriteLine(
                        $"Salaried Employee: Worked {days} days. Vacation days accumulated: {VacationDays}");
                    Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Invalid number of work days.");
            }
        }
    }

    /* public class Manager : SalariedEmployee
     {
         public Manager()
         {
         VacationDays = 30;
         }
     }*/

    public class Manager : EmployeeVacation
    {
        public Manager()
        {
            VacationDays = 30;
        }

        public override void Work(int days)
        {
            if (days >= 0 && days <= 260)
            {
                //VacationDays = 30;
                Console.WriteLine($"Manager Employee: Worked {days} days. Vacation days accumulated: {VacationDays}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid number of work days.");
                Console.ReadLine();
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<EmployeeVacation> employees = new List<EmployeeVacation>();

            // Create 10 instances of each type of employee
            for (int i = 0; i < 10; i++)
            {
                employees.Add(new HourlyEmployee());
                employees.Add(new SalariedEmployee());
                employees.Add(new Manager());

                Console.WriteLine(employees.Count);
            }

            // Perform actions on employees
           foreach (EmployeeVacation employee in employees)
            {
                Console.WriteLine("Employee took 11 days Vacation");
                employee.Work(5);
                employee.TakeVacation(11);

                //Console.WriteLine("Take Vacation 9 days");
                //employee.Work(5);
                //employee.TakeVacation(9);

            }
        }
    }
}
