using System;
using System.Collections.Generic;
using System.Linq;

namespace TourBooker.Logic
{
	public class AppData
	{
		public List<Country> AllCountries { get; private set; }
        public Dictionary<string, Country> AllCountriesByKey { get; set; }

		public void Initialize(string csvFilePath)
		{
			CsvReader reader = new CsvReader(csvFilePath);
			AllCountries = reader.ReadAllCountries().OrderBy(x => x.Name)
                .ToList();

            AllCountriesByKey = AllCountries.ToDictionary(x => x.Code, StringComparer.OrdinalIgnoreCase);
        }
	}
}
