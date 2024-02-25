using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MCD_Fibo_Alfil
{
    public partial class Fibo : Window
    {

        public Fibo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            N1 = this.FindControl<TextBox>("N1");
            N2 = this.FindControl<TextBox>("N2");
            ResultLabel = this.FindControl<Label>("ResultLabel");
        }

        private void CalBtn(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (N1 != null && N2 != null && ResultLabel != null)
            {
                if (int.TryParse(N1.Text, out int num1) && int.TryParse(N2.Text, out int num2))
                {
                    int[] serie = new int[num2];

                    string series = "";
                    
                    for (int i = 0; i < num2; ++i)
                    {
                        // Prints the first two terms.
                        if (i == 0 || i == 1)
                        {
                            serie[i] = num1;
                        }
                        else
                        {
                            serie[i] = serie[i - 1] + serie[i - 2];
                        }

                        series += serie[i] + " ";
                    }

                    ResultLabel.Content = series;
                }
                else
                {
                    ResultLabel.Content = "Numeros invalidos";
                }
            }
        }
    }
}