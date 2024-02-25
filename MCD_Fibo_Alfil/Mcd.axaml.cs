using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MCD_Fibo_Alfil
{
    public partial class Mcd : Window
    {

        public Mcd()
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
                    int mcd = Calcular(num1, num2);

                    ResultLabel.Content = $"El MCD de {num1} y {num2} es {mcd}";
                }
                else
                {
                    ResultLabel.Content = "Numeros invalidos";
                }
            }
        }

        private int Calcular(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }

            return num1;
        }
    }
}