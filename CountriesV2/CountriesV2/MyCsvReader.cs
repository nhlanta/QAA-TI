using System;
using System.IO;


namespace CountriesV2
{
	public class MyCsvReader
	{
		public CountryDictionary ReadData (string filePath)
		{
			CountryDictionary countries = new CountryDictionary();
			
			using (StreamReader stream = new StreamReader(filePath))
			{
				
				while (!stream.EndOfStream)
				{
					string line = stream.ReadLine();
					string[] lineValues = line.Split(',');

					int id = Convert.ToInt32(lineValues[0]);
					Country country = new Country
					{
						Name = lineValues[1],
						IsTelenorSupported = Convert.ToBoolean(lineValues[2])
					};

					countries.Countries.Add(id, country);
				}
			}
			return countries;
		}
	}
}
