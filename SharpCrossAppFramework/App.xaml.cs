using Prism.Unity;

namespace SharpCrossAppFramework
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null)
			: base(initializer)
		{

		}

		/// <summary>
		/// Init Component and Nav to MainPage
		/// </summary>
		protected override void OnInitialized()
		{
			InitializeComponent();
			NavigationService.NavigateAsync("MainPage");
		}

		/// <summary>
		/// Registers the types.
		/// </summary>
		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<SecondPage>();
		}

	}
}
