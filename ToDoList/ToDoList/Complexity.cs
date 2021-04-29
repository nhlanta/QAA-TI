namespace ToDoList
{
	public class Complexity
	{
		public enum ComplexityLevel
		{
			High,
			Medium,
			Low
		}

		public int TimeToExecute
		{
			get;
			private set;
		}

		public Complexity(ComplexityLevel complexityLevel)
		{
			if (complexityLevel is ComplexityLevel.High)
			{
				TimeToExecute = 4;
			}
			else if (complexityLevel is ComplexityLevel.Medium)
			{
				TimeToExecute = 2;
			}
			else
			{
				TimeToExecute = 1;
			}
		}
	}
}