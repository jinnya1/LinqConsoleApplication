using System;
using System.Collections;
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

		public void SortedEmployees_Orderbydescending()
		{
			var sortedEmployees = employees.OrderByDescending(e => e.Age);

			foreach (var employee in sortedEmployees)
			{
				Console.WriteLine($"{employee.Name} - {employee.Age}");
			}

		}

		public void SortedEmployees_ThenBy()
		{
			var sortedEmployees = employees.OrderBy(e => e.Salary).ThenBy(e => e.Age);

			foreach (var employee in sortedEmployees)
			{
				Console.WriteLine($"{employee.Name} - {employee.Age}");
			}

		}

		public void SortedEmployees_ThenByDescending()
		{
			var sortedEmployees = employees.OrderBy(e => e.Salary).ThenByDescending(e => e.Age);

			foreach (var employee in sortedEmployees)
			{
				Console.WriteLine($"{employee.Name} - {employee.Age}");
			}

		}

		public void Groupby()
		{
			var groupedResult = from s in employees
								group s by s.Age;

			foreach (var ageGroup in groupedResult)
			{
				Console.WriteLine("Age Group: {0}", ageGroup.Key);
			}

		}

		public void ToLookup()
		{
			var lookupResult = employees.ToLookup(s => s.Age);

			foreach (var group in lookupResult)
			{
				Console.WriteLine("Age Group: {0}", group.Key);
			}
		}

		public void All()
		{
			bool areAllemplyoeyounguster = employees.All(s => s.Age > 25 && s.Age < 45);

			Console.WriteLine(areAllemplyoeyounguster);
		}

		public void Any()
		{
			bool areAnyemplyoeyounguster = employees.Any(s => s.Age > 25 && s.Age < 45);

			Console.WriteLine(areAnyemplyoeyounguster);
		}

		public void Count()
		{
			var totalElements = employees.Count();
			Console.WriteLine(totalElements);

		}

		public void Max()
		{
			decimal maxSalary = employees.Max(e => e.Salary);
			string employeeWithMaxSalary = employees.Where(e => e.Salary == maxSalary).FirstOrDefault()?.Name;
			Console.WriteLine(employeeWithMaxSalary);
		}

		public void ElementAt()
		{
			var employee = employees.ElementAt(0);
			Console.WriteLine("1st Element in employeelist: {0}", employee.Name);

		}

		public void ElementAtOrDefault()
		{
			var elementAtOrDefault = employees.ElementAtOrDefault(4);
			Console.WriteLine(" Element in employeelist: {0}", elementAtOrDefault.Name);

		}
		public void First()
		{
			var employedetails = employees.First(x=>x.Age>30);
			Console.WriteLine("  Element in employeelist: {0}", employedetails.Name);
		}
		public void FirstorDefault()
		{
			var employedetails = employees.FirstOrDefault(x => x.Age > 40);
			Console.WriteLine("  Element in employeelist: {0}", employedetails.Name);

		}

		public void single()
		{
			var employedetails = employees.Single(x => x.Age > 40);
			Console.WriteLine("  Element in employeelist: {0}", employedetails.Name);
		}

		public void SingleOrDefault()
		{
			var employedetails = employees.SingleOrDefault(x => x.Age > 40);
			Console.WriteLine("  Element in employeelist: {0}", employedetails.Name);
		}

		public void Last()
		{
			var employedetails = employees.Last(x => x.Age > 40);
			Console.WriteLine("  Element in employeelist: {0}", employedetails.Name);
		}

		public void LastOrDefault()
		{
			var employedetails = employees.LastOrDefault(x => x.Age > 40);
			Console.WriteLine("  Element in employeelist: {0}", employedetails.Name);
		}

		public void skip()
		{
			var newList = employees.Skip(2);

			foreach (var str in newList)
				Console.WriteLine(str);

		}
		public void Take()
		{
			var newList = employees.Take(2);

			foreach (var str in newList)
				Console.WriteLine(str);

		}
	}
}