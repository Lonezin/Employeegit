using System.Globalization;

namespace NewProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public double Salary { get; set; }      

        public Employee (int id, string name, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void IncreaseSalary (double percetange)
        {
            Salary += Salary * percetange / 100;
        }
        
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}