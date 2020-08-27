using MahApps.Metro.Controls;

namespace ArithFeather.CustomItemSpawns
{

	public partial class Shell : MetroWindow
	{
		public Shell()
		{
			InitializeComponent();

			DataContext = new Bootstrapper();
		}
	}
}
