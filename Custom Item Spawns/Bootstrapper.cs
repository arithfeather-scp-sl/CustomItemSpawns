using ArithFeather.CustomItemSpawns.ViewModels;
using ReactiveUI;
using Splat;
using System.Reflection;

namespace ArithFeather.CustomItemSpawns
{
	public class Bootstrapper : ReactiveObject, IScreen
	{
		public Bootstrapper(IMutableDependencyResolver dependencyResolver = null, RoutingState testRouter = null)
		{
			Router = testRouter ?? new RoutingState();
			dependencyResolver = dependencyResolver ?? Locator.CurrentMutable;

			RegisterTypes(dependencyResolver);



			Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

			Router.Navigate.Execute(Locator.Current.GetService<IMainViewModel>());
		}

		public RoutingState Router { get; }

		public void RegisterTypes(IMutableDependencyResolver dependencyResolver)
		{
			dependencyResolver.RegisterConstant(this, typeof(IScreen));

			dependencyResolver.Register<IMainViewModel>(() => new MainViewModel(this));
		}
	}
}