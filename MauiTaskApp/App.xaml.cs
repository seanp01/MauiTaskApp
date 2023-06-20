using Microsoft.Maui.Controls;

namespace MauiTaskApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell() { BackgroundColor = Colors.Transparent};
    }
    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);
        
        const double newWidth = 1400;
        const double newHeight = 400;

        window.Width = newWidth;
        window.Height = newHeight;

        window.MinimumHeight = newHeight;
        window.MaximumHeight = newHeight;
        window.MinimumWidth = newWidth;
        window.MaximumWidth = newWidth;

        return window;
    }
    protected override void OnStart()
    {
        base.OnStart();
    }
    protected override void OnResume()
    {
        base.OnResume();
    }
    protected override void OnSleep()
    {
        base.OnSleep();
    }
}
