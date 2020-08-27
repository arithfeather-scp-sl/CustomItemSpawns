using ArithFeather.CustomItemSpawns.ViewModels;
using MahApps.Metro.Controls;
using ReactiveUI;
using System;
using System.Windows.Controls;

namespace ArithFeather.CustomItemSpawns.Views
{
	public abstract class MenuViewBase : ReactiveUserControl<IMenuViewModel>
	{

	}

	/// <summary>
	/// Interaction logic for Menu.xaml
	/// </summary>
	public partial class MenuView : MenuViewBase
	{
		public MenuView() {
			InitializeComponent();
		}
	}
}
