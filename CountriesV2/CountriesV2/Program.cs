using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleTables;

namespace CountriesV2
{
	class Program
	{
		static void Main(string[] args)
		{
			MyCsvReader reader = new MyCsvReader();
			CountryDictionary countryDictionary = reader.ReadData("D:\\Countries.csv");

			countryDictionary.Countries.Add(28, new Country { Name = "Ukraine", IsTelenorSupported = false });

			countryDictionary.ChangeTelenorOption("Denmark", true);
			countryDictionary.ChangeTelenorOption("Hungary", true);

			MyCsvWriter writer = new MyCsvWriter();
			writer.WriteData("D:\\CountriesUpdated.csv", countryDictionary);

			countryDictionary.PrintTelenorFalseCountries();
			Console.ReadLine();
		}
	}
}

