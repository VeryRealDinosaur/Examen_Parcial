using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Examen;

public partial class Siri : Window
{
    public Siri()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        N1 = this.FindControl<TextBox>("N1");
        Res = this.FindControl<Label>("Res");
        N1.Watermark = "Ingrese el número de términos a generar";
    }
    
    private void CalBtn(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Res.Content = "";
        N1.Background = default;
        if (int.TryParse(N1.Text, out int num1) && num1 > 0)
        {
            for (int i = 0; i < num1; i++)
            {
                Res.Content += $"{i*i}, ";
            }
        }
        else
        {
            N1.Background=Brushes.Red;
            Res.Content = "Campo Invalido";
        }
    }
    
}