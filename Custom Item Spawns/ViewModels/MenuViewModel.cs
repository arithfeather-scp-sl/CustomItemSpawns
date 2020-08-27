using ReactiveUI;
using System.Windows.Input;

namespace ArithFeather.CustomItemSpawns.ViewModels
{
	public interface IMenuViewModel
	{
		ICommand LoadCommand { get; }
		ICommand NewCommand { get; }
		ICommand SaveCommand { get; }
	}

	public class MenuViewModel : ReactiveObject, IMenuViewModel
	{
		public MenuViewModel()
		{
		}

		public ICommand NewCommand { get; }
		public ICommand LoadCommand { get; }
		public ICommand SaveCommand { get; }

		private void New()
		{

		}

		private void Load()
		{

		}

		private void Save()
		{

		}
	}
}
