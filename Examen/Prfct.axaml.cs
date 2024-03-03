using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Examen;

public partial class Prfct : Window
{
    public Prfct()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        N1 = this.FindControl<TextBox>("N1");
        N1.Watermark = "Ingrese número de términos a generar";
        Res = this.FindControl<TextBlock>("Res");
    }
    private string GetNextTerm(string currentTerm)
        {
            string nextTerm = "";
            int count = 1;
            char currentDigit = currentTerm[0];

            for (int i = 1; i < currentTerm.Length; ++i)
            {
                if (currentTerm[i] == currentDigit)
                {
                    ++count;
                }
                else
                {
                    nextTerm += count.ToString();
                    nextTerm += currentDigit;
                    count = 1;
                    currentDigit = currentTerm[i];
                }
            }

            nextTerm += count.ToString();
            nextTerm += currentDigit;

            return nextTerm;
        }

        private void ClcBtn(object sender, RoutedEventArgs e)
        {
            N1.Background = default;
            Res.Text = string.Empty;
            string currentTerm = "1";
            if (!int.TryParse(N1.Text, out int numTerms) || numTerms <= 0)
            {
                N1.Background = Brushes.Red;
                Res.Text = "Campo Invalido";
            }

            for (int i = 0; i < numTerms; ++i)
            {
                Res.Text += currentTerm + Environment.NewLine;
                currentTerm = GetNextTerm(currentTerm);
            }
        }
    }