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
			AllData.Initialize(@"G:\projects\Courses\Pluralsight\AdvancedCollections\LinkedLists\PopByLargest.csv");
			this.DataContext = AllData;
		}

		private void tbxCountryCode_TextChanged(object sender, TextChangedEventArgs e)
		{
			string code = tbxCountryCode.Text;
			this.grdSelectCountry.DataContext = GetCountryWithCode(code);
		}

		private Country GetCountryWithCode(string code)
		{
			if (code.Length != 3)
				return null;
			return AllData.AllCountries.Find(x => x.Code == code);
		}
	}
}
