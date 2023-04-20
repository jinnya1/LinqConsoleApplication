using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LinqOperations
{
	 public class linqoperations
	{
		List<Employe> employees = new List<Employe>()
        {
	      new Employe() { Id = 1, Name = "John", Age = 25, Salary = 50000 },
	      new Employe() { Id = 2, Name = "Jane", Age = 30, Salary = 60000 },
	      new Employe() { Id = 3, Name = "Bob", Age = 35, Salary = 70000 },
	      new Employe() { Id = 4, Name = "Alice", Age = 40, Salary = 80000 },
	      new Employe() { Id = 5, Name = "Tom", Age = 45, Salary = 90000 }
        };

		public void HighSalaryEmployees_Where()
		{
			var highSalaryEmployees = from e in employees
									  where e.Salary > 60000
									  select e;

			foreach (var employee in highSalaryEmployees)
			{
				Console.WriteLine(employee.Name);
			}

		}

		public void SortedEmployees_Orderby()
		{
			var sortedEmployees = employees.OrderBy(e => e.Age);

			foreach (var employee in sortedEmployees)
			{
				Console.WriteLine($"{employee.Name} - {employee.Age}");
			}

		}

		public void GroupedEmployees_GroupBy()
		{
			var groupedEmployees = employees.GroupBy(e => e.Age);

			foreach (var group in groupedEmployees)
			{
				Console.WriteLine($"Age: {group.Key}");
				foreach (var employee in group)
				{
					Console.WriteLine($"- {employee.Name}");
				}
			}
		}

		public void AverageSalary_Average()
		{
			var averageSalary = employees.Average(e => e.Salary);

			Console.WriteLine($"Average salary: {averageSalary}");

		}
	}
}
