using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Examen;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);

        var AlfiBtn = this.FindControl<Button>("Alfi");
        AlfiBtn.Click += OnAlfiClick;

        var RootBtn = this.FindControl<Button>("Root");
        RootBtn.Click += OnRootClick;

        var SiriBtn = this.FindControl<Button>("Siri");
        SiriBtn.Click += OnSiriClick;

        var PrfctBtn = this.FindControl<Button>("Prfct");
        PrfctBtn.Click += OnPrfctClick;
        
        var SmnaBtn = this.FindControl<Button>("Smna");
        SmnaBtn.Click += OnSmnaClick;
    }

    private void OnAlfiClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var secondWindow = new Alfi();
        secondWindow.Show();
    }

    private void OnRootClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var thirdWindow = new Root();
        thirdWindow.Show();
    }

    private void OnSiriClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var thirdWindow = new Siri();
        thirdWindow.Show();
    }

    private void OnPrfctClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var fourthWindow = new Prfct();
        fourthWindow.Show();
    }

    private void OnSmnaClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var fourthWindow = new Smna();
        fourthWindow.Show();
    }
}