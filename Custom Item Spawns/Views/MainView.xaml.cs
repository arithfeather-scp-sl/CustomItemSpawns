using ArithFeather.CustomItemSpawns.ViewModels;
using ReactiveUI;
using System.Windows.Controls;

namespace ArithFeather.CustomItemSpawns.Views
{
	public abstract class MainViewBase : ReactiveUserControl<IMainViewModel> { }

	/// <summary>
	/// Interaction logic for MainView.xaml
	/// </summary>
	public partial class MainView : MainViewBase
	{
		public MainView()
		{
			InitializeComponent();
		}
	}
}
