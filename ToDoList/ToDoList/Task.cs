using System;

namespace ToDoList
{
	class Task
	{
		private string description;
		public Complexity Complexity { get; set; }
		public Priority Priority { get; set; }

		public string Description
		{
			get { return description; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					Console.WriteLine("Please enter some value. Description cannot be empty.");
				}
				else
				{
					description = value;
				}
			}
		}
	}
}