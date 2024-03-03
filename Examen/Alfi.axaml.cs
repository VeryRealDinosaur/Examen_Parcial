using System;
using System.Text;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Examen;

public partial class Alfi : Window
{
    private TextBlock _tablero;

    private int _alfiX;
    private int _alfiY;

    public Alfi()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        N1 = this.FindControl<TextBox>("N1");
        N2 = this.FindControl<TextBox>("N2");
        Board = this.FindControl<Label>("Board");
        _tablero = this.FindControl<TextBlock>("ChessboardText");
        N1.Watermark = "Ingrese coordenadas horizontales";
        N2.Watermark = "Ingrese coordenadas verticales";
    }

    private void CalBtn(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        N1.Background = default;
        N2.Background = default;
        Board.Content = "";
        if (N1 != null && N2 != null && Board != null)
        {
            if (int.TryParse(N1.Text, out int num1)  && num1 <9  && num1 > 0  )
            {
                if (int.TryParse(N2.Text, out int num2) && num2 < 9 && num2 > 0)
                {
                    _alfiX = num1 - 1;
                    _alfiY = 7 - (num2 - 1);
                    UpdateChessboard();
                }
                else
                {
                    N2.Background=Brushes.Red;
                    Board.Content = "Campo Invalido";
                }
            }
            else
            {
                N1.Background=Brushes.Red;
                Board.Content = "Campo Invalido";
            }
        }
    }

    private void UpdateChessboard()
    {
        var gridBuilder = new StringBuilder();

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (i == _alfiY && j == _alfiX)
                {
                    gridBuilder.Append("[A]");
                }
                else if (CanAlfiMove(i, j))
                {
                    gridBuilder.Append("[*]");
                }
                else
                {
                    gridBuilder.Append("[ ]");
                }
            }
            gridBuilder.AppendLine();
        }

        _tablero.Text = gridBuilder.ToString();
    }

    private bool CanAlfiMove(int x, int y)
    {
        return Math.Abs(x - _alfiY) == Math.Abs(y - _alfiX);
    }
}