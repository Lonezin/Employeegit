using System.Globalization;

namespace NewProject
{
    class GitHub
    {
        static void Main (string[]args)
        {
            System.Console.WriteLine("how many employees will be registered?");
            int number = int.Parse(Console.ReadLine());
            List <Employee> list = new List <Employee>();
            for (int i = 1; i <= number; i++)
            {
                System.Console.WriteLine("Employee #" + i + ":");
                System.Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                System.Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));                
            }
            System.Console.WriteLine();
            System.Console.WriteLine("enter the employee id that will have salary increase:");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = list.FindLast(x => x.Id == searchId);
            if (emp != null)
            {
                System.Console.WriteLine("enter the percentage: ");
                int percentage = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }            
            else
            {
                System.Console.WriteLine("this id does not exist");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("the new list: ");
            foreach (Employee obj in list)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}