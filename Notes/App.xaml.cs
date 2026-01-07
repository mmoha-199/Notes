namespace Notes;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	    Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
	    //MainPage = new AppShell();
	}
	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}