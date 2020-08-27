using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithFeather.CustomItemSpawns.ViewModels
{
	public interface IMainViewModel : IRoutableViewModel
	{

	}

	public class MainViewModel : ReactiveObject, IMainViewModel
	{
		public MainViewModel(IScreen screen)
		{
			HostScreen = screen;
		}

		public string UrlPathSegment => string.Empty;

		public IScreen HostScreen { get; }

		public IMenuViewModel MenuViewModel { get; } = Locator.Current.GetService<IMenuViewModel>();

		public string text { get; } = "testetststsetstes";
	}
}
