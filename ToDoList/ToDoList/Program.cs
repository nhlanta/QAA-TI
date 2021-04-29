using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Task> tasks = new List<Task>();

			Console.WriteLine("Provide comma separated task with Description, Priority, Complexity");
			Console.WriteLine("Please follow a format \'Prepare documentation,High,Medium\'");
			Console.WriteLine("Priority can be High, Medium, Low");
			Console.WriteLine("Complexity can be High, Medium, Low\n");
			Console.WriteLine("Once all tasks are provided please click ESC to continue.\n");

			do
			{
				string userInput = Console.ReadLine();
				string[] userInputValues = userInput.Split(',');
				var complexityLevel = (Complexity.ComplexityLevel)Enum.Parse(typeof(Complexity.ComplexityLevel), userInputValues[2]);

				Task task = new Task
				{
					Description = userInputValues[0],
					Priority = (Priority)Enum.Parse(typeof(Priority), userInputValues[1]),
					Complexity = new Complexity(complexityLevel)
				};

				tasks.Add(task);
			}
			while (Console.ReadKey().Key != ConsoleKey.Escape);

				CalculateTotalTimeToExecute(tasks);
				GetDescriptionByPriority(tasks);
				GetTaskOrderedByPriority(tasks);
		}


		static void GetTaskOrderedByPriority(List<Task> tasks)
		{
			Console.WriteLine("\nEnter a number of days to display tasks to do: ");

			int daysNumber = Convert.ToInt32(Console.ReadLine());
			int hoursNumber = daysNumber * 8;
			int remainingHours = hoursNumber;

			var sortedTasks = tasks.OrderBy(o => o.Priority).ToList();

			foreach (Task t in sortedTasks)
			{
				if (remainingHours >= t.Complexity.TimeToExecute || sortedTasks.Count <1)
				{
					tasks.Add(t);
					remainingHours = remainingHours - t.Complexity.TimeToExecute;
					Console.WriteLine(t.Description);
				}
			}
		}

		static void GetDescriptionByPriority(List<Task> tasks)
		{
			Console.WriteLine("\nPlease enter a priority for which you want to see a list of tasks: ");
			string userPriority = Console.ReadLine();

			var filteredTasks = tasks.Where(t => t.Priority.ToString().Equals(userPriority, StringComparison.OrdinalIgnoreCase)).ToList();
			Console.WriteLine("\nA list of tasks for {0} priority is: \n", userPriority);
			foreach (Task t in filteredTasks)
			{
				Console.WriteLine(t.Description);
			}
		}

		static void CalculateTotalTimeToExecute(List<Task> tasks)
		{
			int sum = 0;
			foreach (Task t in tasks)
			{
				sum = sum + t.Complexity.TimeToExecute;
			}
			Console.WriteLine("\nTThe total time to execute all tasks is {0} hours", sum);
		}
	}
}