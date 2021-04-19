using System;
using System.Collections.Generic;

namespace CountriesV2
{
	public class CountryDictionary
	{
		public Dictionary<int, Country> Countries { get; private set; } = new Dictionary<int, Country>();

		public void PrintCountries()
		{
			foreach (KeyValuePair<int, Country> keyValue in Countries)
			{
				Console.WriteLine(keyValue.Key + "  " + keyValue.Value.Name + " " + keyValue.Value.IsTelenorSupported);
			}
		}

		public void ChangeTelenorOption(string name,bool isTelenorSupported) 
		{
			foreach (KeyValuePair<int, Country> keyValue in Countries)
			{
				if (keyValue.Value.Name == name)
				{
					keyValue.Value.IsTelenorSupported = isTelenorSupported;
				}
			}
		}

		public void PrintTelenorFalseCountries()
		{
			foreach (KeyValuePair<int, Country> keyValue in Countries)
			{
				if (keyValue.Value.IsTelenorSupported == false)
				{
					Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name + " " + keyValue.Value.IsTelenorSupported);
				}
			}
		}

	}
}
