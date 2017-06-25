using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace SharpCrossAppFramework.ViewModels
{
	/// <summary>
	/// Base viewmodel.
	/// </summary>
	public class BaseViewModel : BindableBase, INavigationAware
	{
		protected INavigationService _navigationService;
		public BaseViewModel()
		{
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}
	}
}
