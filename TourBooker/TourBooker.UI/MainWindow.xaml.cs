using System.Windows;
using System.Windows.Controls;
using TourBooker.Logic;

namespace TourBooker.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private AppData AllData { get; } = new AppData();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			AllData.Initialize(@"G:\projects\Courses\Pluralsight\AdvancedCollections\TourBooker\PopByLargest.csv");
			DataContext = AllData;
		}

		private void tbxCountryCode_TextChanged(object sender, TextChangedEventArgs e)
		{
			var code = tbxCountryCode.Text;
			grdSelectCountry.DataContext = GetCountryWithCode(code);
		}

		private Country GetCountryWithCode(string code)
		{
			//return code.Length != 3 ? null : AllData.AllCountries.Find(x => x.Code == code);
            //return code.Length != 3 ? null : AllData.AllCountriesByKey[code];
            if (code.Length != 3)
            {
                return null;
            }
            
            AllData.AllCountriesByKey.TryGetValue(new CountryCode(code), out var result);
            return result;
        }
	}
}
