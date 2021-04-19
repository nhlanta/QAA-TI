using System.Collections.Generic;
using System.IO;

namespace CountriesV2
{
	public class MyCsvWriter
	{

		public void WriteData(string filePath, CountryDictionary countries)
		{
			
			using (StreamWriter writer = new StreamWriter(filePath, false))
			{
				foreach (KeyValuePair<int, Country> keyValue in countries.Countries)
				{
					writer.WriteLine("{0},{1},{2}", keyValue.Key, keyValue.Value.Name, keyValue.Value.IsTelenorSupported);
				}
			}
		}

	
	}

}

