using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace SharpCrossAppFramework.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware //BaseViewModel
	{
		private INavigationService _navigationService;
		private string _title = "Hello Sharp Cross";
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				SetProperty(ref _title, value);
			}
		}

		public DelegateCommand LoadSecondCommand { get; set; }

		public MainPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			LoadSecondCommand = new DelegateCommand(Navigate);
		}

		private async void Navigate()
		{
			await _navigationService.NavigateAsync("SecondPage");
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("title"))
			{
				Title = (string)parameters["title"] + " and prism";
			}
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
