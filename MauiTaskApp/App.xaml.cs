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

        const int newWidth = 800;
        const int newHeight = 400;

        window.Width = newWidth;
        window.Height = newHeight;

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
