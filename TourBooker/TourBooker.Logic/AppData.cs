using System.Collections.Generic;
using System.Linq;

namespace TourBooker.Logic
{
	public class AppData
	{
		public List<Country> AllCountries { get; private set; }
        public Dictionary<CountryCode, Country> AllCountriesByKey { get; private set; }

		public void Initialize(string csvFilePath)
		{
			CsvReader reader = new CsvReader(csvFilePath);
			AllCountries = reader.ReadAllCountries().OrderBy(x => x.Name)
                .ToList();

            var countriesDictionary = AllCountries.ToDictionary(x => x.Code);
            AllCountriesByKey = countriesDictionary;
        }
	}
}
