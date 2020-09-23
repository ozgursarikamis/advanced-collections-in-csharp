using System.Collections.Generic;
using System.Linq;

namespace TourBooker.Logic
{
	public class AppData
	{
		public List<Country> AllCountries { get; private set; }
		public void Initialize(string csvFilePath)
		{
			CsvReader reader = new CsvReader(csvFilePath);
			AllCountries = reader.ReadAllCountries();

			// during the module, the above line is changed to
			//this.AllCountries = reader.ReadAllCountries().OrderBy(x=>x.Name).ToList();

            AllCountries = reader.ReadAllCountries().OrderBy(x => x.Name)
                .ToList();
        }
	}
}
