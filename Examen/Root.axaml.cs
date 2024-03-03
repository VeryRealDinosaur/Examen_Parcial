using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Examen;

public partial class Root : Window
{
    public Root()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        N1 = this.FindControl<TextBox>("N1");
        Res = this.FindControl<Label>("Res");
        N1.Watermark = "Ingrese un número";
    }
    
    private void CalBtn(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        N1.Background = default;
        Res.Content = "";
        if (int.TryParse(N1.Text, out int num1) && num1>=0)
        {
            double root = Math.Sqrt(num1);
            Res.Content = $"La raíz cuadrada de {num1} es de {root}";
        }
        else
        {
            N1.Background=Brushes.Red;
            Res.Content = "Campo Invalido";
        }
    }
    
}