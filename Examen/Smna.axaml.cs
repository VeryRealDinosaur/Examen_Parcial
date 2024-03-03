using System;
using System.Globalization;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Examen;

public partial class Smna : Window
{
    public Smna()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        N1 = this.FindControl<TextBox>("N1");
        Res = this.FindControl<Label>("Res");
        N1.Watermark = "YYYY-MM-DD";
    }

    private void CalBtn(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        N1.Background = default;
        Res.Content = "";

        if (DateTime.TryParseExact(
                N1.Text,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime date))
        {
            int dia = (date.Day % 7)+1;
                switch (dia)
                {
                    case 1:
                        Res.Content = "Domingo";
                        break;
                    case 2:
                        Res.Content = "Lunes";
                        break;
                    case 3:
                        Res.Content = "Martes";
                        break;
                    case 4:
                        Res.Content = "Miercoles";
                        break;
                    case 5:
                        Res.Content = "Jueves";
                        break;
                    case 6:
                        Res.Content = "Viernes";
                        break;
                    case 7:
                        Res.Content = "Sabado";
                        break;
                }
            }
        else
        {
            N1.Background = Brushes.Red;
            Res.Content = "Campo Invalido";
        }
    }
}