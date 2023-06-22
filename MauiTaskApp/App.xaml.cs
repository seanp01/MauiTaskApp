using Microsoft.Maui.Controls;

namespace MauiTaskApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell() { BackgroundColor = Colors.Transparent };
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
