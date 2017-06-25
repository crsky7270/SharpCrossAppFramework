using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace SharpCrossAppFramework.ViewModels
{
	public class SecondPageViewModel: BindableBase, INavigationAware
	{
		public SecondPageViewModel()
		{
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			//throw new NotImplementedException();
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			//throw new NotImplementedException();
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			//throw new NotImplementedException();
		}
	}
}
